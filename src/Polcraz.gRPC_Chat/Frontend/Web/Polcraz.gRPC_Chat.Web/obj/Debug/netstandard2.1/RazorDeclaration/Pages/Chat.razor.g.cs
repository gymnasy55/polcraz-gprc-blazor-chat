// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Polcraz.gRPC_Chat.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\polcr\source\repos\Ilya\web\gRPC_Chat\polcraz-gprc-blazor-chat\src\Polcraz.gRPC_Chat\Frontend\Web\Polcraz.gRPC_Chat.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\polcr\source\repos\Ilya\web\gRPC_Chat\polcraz-gprc-blazor-chat\src\Polcraz.gRPC_Chat\Frontend\Web\Polcraz.gRPC_Chat.Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\polcr\source\repos\Ilya\web\gRPC_Chat\polcraz-gprc-blazor-chat\src\Polcraz.gRPC_Chat\Frontend\Web\Polcraz.gRPC_Chat.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\polcr\source\repos\Ilya\web\gRPC_Chat\polcraz-gprc-blazor-chat\src\Polcraz.gRPC_Chat\Frontend\Web\Polcraz.gRPC_Chat.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\polcr\source\repos\Ilya\web\gRPC_Chat\polcraz-gprc-blazor-chat\src\Polcraz.gRPC_Chat\Frontend\Web\Polcraz.gRPC_Chat.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\polcr\source\repos\Ilya\web\gRPC_Chat\polcraz-gprc-blazor-chat\src\Polcraz.gRPC_Chat\Frontend\Web\Polcraz.gRPC_Chat.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\polcr\source\repos\Ilya\web\gRPC_Chat\polcraz-gprc-blazor-chat\src\Polcraz.gRPC_Chat\Frontend\Web\Polcraz.gRPC_Chat.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\polcr\source\repos\Ilya\web\gRPC_Chat\polcraz-gprc-blazor-chat\src\Polcraz.gRPC_Chat\Frontend\Web\Polcraz.gRPC_Chat.Web\_Imports.razor"
using Polcraz.gRPC_Chat.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\polcr\source\repos\Ilya\web\gRPC_Chat\polcraz-gprc-blazor-chat\src\Polcraz.gRPC_Chat\Frontend\Web\Polcraz.gRPC_Chat.Web\_Imports.razor"
using Polcraz.gRPC_Chat.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\polcr\source\repos\Ilya\web\gRPC_Chat\polcraz-gprc-blazor-chat\src\Polcraz.gRPC_Chat\Frontend\Web\Polcraz.gRPC_Chat.Web\_Imports.razor"
using Polcraz.gRPC_Chat.Web.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\polcr\source\repos\Ilya\web\gRPC_Chat\polcraz-gprc-blazor-chat\src\Polcraz.gRPC_Chat\Frontend\Web\Polcraz.gRPC_Chat.Web\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\polcr\source\repos\Ilya\web\gRPC_Chat\polcraz-gprc-blazor-chat\src\Polcraz.gRPC_Chat\Frontend\Web\Polcraz.gRPC_Chat.Web\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\polcr\source\repos\Ilya\web\gRPC_Chat\polcraz-gprc-blazor-chat\src\Polcraz.gRPC_Chat\Frontend\Web\Polcraz.gRPC_Chat.Web\Pages\Chat.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\polcr\source\repos\Ilya\web\gRPC_Chat\polcraz-gprc-blazor-chat\src\Polcraz.gRPC_Chat\Frontend\Web\Polcraz.gRPC_Chat.Web\Pages\Chat.razor"
using Grpc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\polcr\source\repos\Ilya\web\gRPC_Chat\polcraz-gprc-blazor-chat\src\Polcraz.gRPC_Chat\Frontend\Web\Polcraz.gRPC_Chat.Web\Pages\Chat.razor"
using Polcraz.gRPC_Chat.Protos;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Chat : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\polcr\source\repos\Ilya\web\gRPC_Chat\polcraz-gprc-blazor-chat\src\Polcraz.gRPC_Chat\Frontend\Web\Polcraz.gRPC_Chat.Web\Pages\Chat.razor"
 
    private readonly List<string> _messages = new List<string>();

    private string _message;

    private readonly CancellationTokenSource _cancelTokenSource = new CancellationTokenSource();

    protected override async Task OnInitializedAsync()
    {
        NavigationManager.LocationChanged += NavigationManagerOnLocationChanged;

        var serverStream = ChatRoomClient.JoinChat(new ChatRequest(), cancellationToken: _cancelTokenSource.Token);
        var stream = serverStream.ResponseStream;

        try
        {
            await foreach (var message in stream.ReadAllAsync())
            {
                _messages.Add(message.Message);
                this.StateHasChanged();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            serverStream.Dispose();
        }
    }

    private void NavigationManagerOnLocationChanged(object sender, LocationChangedEventArgs e)
    {
        Dispose();
    }

    public void Dispose()
    {
        _cancelTokenSource.Cancel();
    }

    private async Task SendMessageAsync()
    {
        if (string.IsNullOrEmpty(_message))
            return;

        await ChatRoomClient.SendAsync(new ChatMessage
        {
            Message = _message
        });

        _message = string.Empty;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ChatRoom.ChatRoomClient ChatRoomClient { get; set; }
    }
}
#pragma warning restore 1591
