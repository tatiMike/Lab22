#pragma checksum "C:\Users\theP4\source\repos\CoffeeShop\CoffeeShop\Views\Home\Registered.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4071111d1835454bef2800fbc011896c495c06b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Registered), @"mvc.1.0.view", @"/Views/Home/Registered.cshtml")]
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
#line 1 "C:\Users\theP4\source\repos\CoffeeShop\CoffeeShop\Views\_ViewImports.cshtml"
using CoffeeShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\theP4\source\repos\CoffeeShop\CoffeeShop\Views\_ViewImports.cshtml"
using CoffeeShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4071111d1835454bef2800fbc011896c495c06b1", @"/Views/Home/Registered.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0280a23aa28fddc99a39f5869bf0f0a5a4076c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Registered : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Registerer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\theP4\source\repos\CoffeeShop\CoffeeShop\Views\Home\Registered.cshtml"
  
    ViewData["Title"] = "Registered";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    <h1>Thanks for registering ");
#nullable restore
#line 9 "C:\Users\theP4\source\repos\CoffeeShop\CoffeeShop\Views\Home\Registered.cshtml"
                          Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "C:\Users\theP4\source\repos\CoffeeShop\CoffeeShop\Views\Home\Registered.cshtml"
                                           Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h1>\r\n<h2>Your email: ");
#nullable restore
#line 10 "C:\Users\theP4\source\repos\CoffeeShop\CoffeeShop\Views\Home\Registered.cshtml"
           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>Your phone number: ");
#nullable restore
#line 11 "C:\Users\theP4\source\repos\CoffeeShop\CoffeeShop\Views\Home\Registered.cshtml"
                  Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<!--<h1>");
#nullable restore
#line 12 "C:\Users\theP4\source\repos\CoffeeShop\CoffeeShop\Views\Home\Registered.cshtml"
   Write(Model.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>-->");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Registerer> Html { get; private set; }
    }
}
#pragma warning restore 1591