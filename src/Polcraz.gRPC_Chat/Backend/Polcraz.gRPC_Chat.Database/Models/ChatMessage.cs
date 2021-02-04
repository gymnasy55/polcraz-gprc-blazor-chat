using System;

namespace Polcraz.gRPC_Chat.Database
{
    public class ChatMessage
    {
        public string Id { get; set; }

        public string Message { get; set; }

        public ChatMessage()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}