#pragma checksum "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Shared\_LoginPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b25c74a0d66b1a5e521408602c8a76cacd6da97d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Shared__LoginPartial), @"mvc.1.0.view", @"/Pages/Shared/_LoginPartial.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Shared\_LoginPartial.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Shared\_LoginPartial.cshtml"
using ProyectoMaersk.Clases;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b25c74a0d66b1a5e521408602c8a76cacd6da97d", @"/Pages/Shared/_LoginPartial.cshtml")]
    public class Pages_Shared__LoginPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<ul class=\"navbar-nav\">\r\n");
#nullable restore
#line 8 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Shared\_LoginPartial.cshtml"
 if (SignInManager.IsSignedIn(User))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"nav-item\">\r\n        <form id=\"logoutForm\" class=\"form-inline\" asp-area=\"Identity\" asp-page=\"/Account/Logout\"");
            BeginWriteAttribute("asp-route-returnUrl", " asp-route-returnUrl=\"", 365, "\"", 425, 1);
#nullable restore
#line 11 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Shared\_LoginPartial.cshtml"
WriteAttributeValue("", 387, Url.Page("/Index", new { area = "" }), 387, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <button id=\"logout\" type=\"submit\" class=\"nav-link btn btn-link text-dark\">Logout</button>\r\n        </form>\r\n    </li>\r\n");
#nullable restore
#line 15 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Shared\_LoginPartial.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"nav-item\">\r\n        <a class=\"nav-link text-dark\" id=\"login\" asp-area=\"Identity\" asp-page=\"/Account/Login\">Login</a>\r\n    </li>\r\n");
#nullable restore
#line 21 "C:\Users\osanc\source\repos\naviera\ProyectoMaersk\Pages\Shared\_LoginPartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<UsuarioIdentity> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<UsuarioIdentity> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591