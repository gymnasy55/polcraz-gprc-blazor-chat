#pragma checksum "C:\Users\polcr\source\repos\Ilya\web\gRPC_Chat\polcraz-gprc-blazor-chat\src\Polcraz.gRPC_Chat\Frontend\Web\Polcraz.gRPC_Chat.Web\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea88abfdc203fe16a6e69e29a315b139d6220b19"
// <auto-generated/>
#pragma warning disable 1591
namespace Polcraz.gRPC_Chat.Web.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "<a class=\"navbar-brand\" href>Polcraz.gRPC_Chat.Web</a>\r\n    ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "navbar-toggler");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\polcr\source\repos\Ilya\web\gRPC_Chat\polcraz-gprc-blazor-chat\src\Polcraz.gRPC_Chat\Frontend\Web\Polcraz.gRPC_Chat.Web\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(6, "<span class=\"navbar-toggler-icon\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", 
#nullable restore
#line 8 "C:\Users\polcr\source\repos\Ilya\web\gRPC_Chat\polcraz-gprc-blazor-chat\src\Polcraz.gRPC_Chat\Frontend\Web\Polcraz.gRPC_Chat.Web\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\polcr\source\repos\Ilya\web\gRPC_Chat\polcraz-gprc-blazor-chat\src\Polcraz.gRPC_Chat\Frontend\Web\Polcraz.gRPC_Chat.Web\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(11, "ul");
            __builder.AddAttribute(12, "class", "nav flex-column");
            __builder.OpenElement(13, "li");
            __builder.AddAttribute(14, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(15);
            __builder.AddAttribute(16, "class", "nav-link");
            __builder.AddAttribute(17, "href", "");
            __builder.AddAttribute(18, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "C:\Users\polcr\source\repos\Ilya\web\gRPC_Chat\polcraz-gprc-blazor-chat\src\Polcraz.gRPC_Chat\Frontend\Web\Polcraz.gRPC_Chat.Web\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(20, "<span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\polcr\source\repos\Ilya\web\gRPC_Chat\polcraz-gprc-blazor-chat\src\Polcraz.gRPC_Chat\Frontend\Web\Polcraz.gRPC_Chat.Web\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591