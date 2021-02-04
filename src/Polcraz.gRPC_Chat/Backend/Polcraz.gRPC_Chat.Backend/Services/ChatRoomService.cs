﻿using System;
using System.Collections.Generic;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Polcraz.gRPC_Chat.Database;
using Polcraz.gRPC_Chat.Protos;
using ChatMessage = Polcraz.gRPC_Chat.Protos.ChatMessage;

namespace Polcraz.gRPC_Chat.Backend
{
    public class ChatRoomService : ChatRoom.ChatRoomBase
    {
        private readonly ChatRoomManager _chatRoomManager;

        private List<IServerStreamWriter<ChatMessage>> _listeners = new List<IServerStreamWriter<ChatMessage>>();

        public ChatRoomService(ChatRoomManager chatRoomManager)
        {
            _chatRoomManager = chatRoomManager;

            _chatRoomManager.MessageSended += ChatRoomService_MessageSended;
        }

        public override async Task JoinChat(ChatRequest request, IServerStreamWriter<ChatMessage> responseStream, ServerCallContext context)
        {
            foreach (var chatMessage in _chatRoomManager.GetMessages())
            {
                await responseStream.WriteAsync(new ChatMessage
                {
                    Message = chatMessage.Message
                });
            }

            _listeners.Add(responseStream);

            while (!context.CancellationToken.IsCancellationRequested)
            {
                await Task.Delay(100);
            }

            _listeners.Remove(responseStream);
        }

        private void ChatRoomService_MessageSended(string message)
        {
            foreach (var streamWriter in _listeners)
            {
                streamWriter.WriteAsync(new ChatMessage
                {
                    Message = message
                });
            }
        }

        public override async Task<ChatRequest> Send(ChatMessage request, ServerCallContext context)
        {
            var chatMessage = new Polcraz.gRPC_Chat.Database.ChatMessage
            {
                Message = request.Message
            };

            await _chatRoomManager.AddMessageAsync(chatMessage);

            return new ChatRequest();
        }
    }
}
