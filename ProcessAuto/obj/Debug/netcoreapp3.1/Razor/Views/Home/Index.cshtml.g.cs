#pragma checksum "C:\Users\ukwim\Documents\GitHub\Projects\ProcessAuto\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81e551a0e1413993ce42a3782f15ba339be5b9c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\ukwim\Documents\GitHub\Projects\ProcessAuto\Views\_ViewImports.cshtml"
using ProcessAuto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ukwim\Documents\GitHub\Projects\ProcessAuto\Views\_ViewImports.cshtml"
using ProcessAuto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81e551a0e1413993ce42a3782f15ba339be5b9c3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5aa460c1eed1005e6a5998363494f8e1837c1e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProcessAuto.Areas.Identity.Data.PAUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ukwim\Documents\GitHub\Projects\ProcessAuto\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3 class=\"display-4\">Данные пользователя</h3>\r\n\r\n<div class=\"container text-center\">\r\n    <div class=\"row\">\r\n        <div class=\"col-2\">\r\n            <p class=\"b\">");
#nullable restore
#line 12 "C:\Users\ukwim\Documents\GitHub\Projects\ProcessAuto\Views\Home\Index.cshtml"
                    Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-2\">\r\n            <p class=\"b\">");
#nullable restore
#line 15 "C:\Users\ukwim\Documents\GitHub\Projects\ProcessAuto\Views\Home\Index.cshtml"
                    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-2\">\r\n            <p class=\"b\">");
#nullable restore
#line 18 "C:\Users\ukwim\Documents\GitHub\Projects\ProcessAuto\Views\Home\Index.cshtml"
                    Write(Model.MiddleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-2\">\r\n            <p>");
#nullable restore
#line 23 "C:\Users\ukwim\Documents\GitHub\Projects\ProcessAuto\Views\Home\Index.cshtml"
          Write(Model.DateOfBirth.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProcessAuto.Areas.Identity.Data.PAUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
