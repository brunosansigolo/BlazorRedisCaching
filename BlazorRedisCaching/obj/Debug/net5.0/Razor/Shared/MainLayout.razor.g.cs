#pragma checksum "D:\repo\BlazorRedisCaching\BlazorRedisCaching\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05aece59e7b654d21cd5dfe402ab600e0f9385e0"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorRedisCaching.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\repo\BlazorRedisCaching\BlazorRedisCaching\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repo\BlazorRedisCaching\BlazorRedisCaching\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\repo\BlazorRedisCaching\BlazorRedisCaching\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\repo\BlazorRedisCaching\BlazorRedisCaching\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\repo\BlazorRedisCaching\BlazorRedisCaching\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\repo\BlazorRedisCaching\BlazorRedisCaching\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\repo\BlazorRedisCaching\BlazorRedisCaching\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\repo\BlazorRedisCaching\BlazorRedisCaching\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\repo\BlazorRedisCaching\BlazorRedisCaching\_Imports.razor"
using BlazorRedisCaching;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\repo\BlazorRedisCaching\BlazorRedisCaching\_Imports.razor"
using BlazorRedisCaching.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\repo\BlazorRedisCaching\BlazorRedisCaching\_Imports.razor"
using Microsoft.Extensions.Caching.Distributed;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-2ndq5st8ld");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-2ndq5st8ld");
            __builder.OpenComponent<BlazorRedisCaching.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-2ndq5st8ld");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-2ndq5st8ld><a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-2ndq5st8ld>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-2ndq5st8ld");
            __builder.AddContent(15, 
#nullable restore
#line 14 "D:\repo\BlazorRedisCaching\BlazorRedisCaching\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
