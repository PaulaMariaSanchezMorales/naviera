#pragma checksum "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f8bd15e508fca25dafeb7b0adbf578ca4e10900"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyectoMaersk.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\_Imports.razor"
using ProyectoMaersk;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\_Imports.razor"
using ProyectoMaersk.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Shared\MainLayout.razor"
using Clases;

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
            __builder.AddAttribute(2, "b-84teipiy1q");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-84teipiy1q");
            __builder.OpenComponent<ProyectoMaersk.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-84teipiy1q");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "top-row");
            __builder.AddAttribute(13, "style", "background-color:#778DA9");
            __builder.AddAttribute(14, "b-84teipiy1q");
            __builder.OpenComponent<ProyectoMaersk.Shared.LoginDisplay>(15);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "content px-4");
            __builder.AddAttribute(19, "b-84teipiy1q");
            __builder.AddContent(20, 
#nullable restore
#line 14 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Shared\MainLayout.razor"
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
