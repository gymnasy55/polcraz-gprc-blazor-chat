#pragma checksum "C:\Users\polcr\source\repos\Ilya\web\gRPC_Chat\polcraz-gprc-blazor-chat\src\Polcraz.gRPC_Chat\Frontend\Web\Polcraz.gRPC_Chat.Web\Components\ChatMessagesView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2483f55f502308a07f980460f847e9bab57bda6"
// <auto-generated/>
#pragma warning disable 1591
namespace Polcraz.gRPC_Chat.Web.Components
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
    public partial class ChatMessagesView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\polcr\source\repos\Ilya\web\gRPC_Chat\polcraz-gprc-blazor-chat\src\Polcraz.gRPC_Chat\Frontend\Web\Polcraz.gRPC_Chat.Web\Components\ChatMessagesView.razor"
 foreach(var message in Messages)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "h2");
            __builder.AddContent(1, 
#nullable restore
#line 3 "C:\Users\polcr\source\repos\Ilya\web\gRPC_Chat\polcraz-gprc-blazor-chat\src\Polcraz.gRPC_Chat\Frontend\Web\Polcraz.gRPC_Chat.Web\Components\ChatMessagesView.razor"
         message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 4 "C:\Users\polcr\source\repos\Ilya\web\gRPC_Chat\polcraz-gprc-blazor-chat\src\Polcraz.gRPC_Chat\Frontend\Web\Polcraz.gRPC_Chat.Web\Components\ChatMessagesView.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\polcr\source\repos\Ilya\web\gRPC_Chat\polcraz-gprc-blazor-chat\src\Polcraz.gRPC_Chat\Frontend\Web\Polcraz.gRPC_Chat.Web\Components\ChatMessagesView.razor"
       
    [Parameter]
    public List<string> Messages { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
