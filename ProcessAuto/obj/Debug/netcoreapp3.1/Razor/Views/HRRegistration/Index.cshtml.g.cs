#pragma checksum "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\HRRegistration\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eff7bc5329d5275b074ae893ca77cdbbd1261a47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HRRegistration_Index), @"mvc.1.0.view", @"/Views/HRRegistration/Index.cshtml")]
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
#line 1 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\_ViewImports.cshtml"
using ProcessAuto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\HRRegistration\Index.cshtml"
using ProcessAuto.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\HRRegistration\Index.cshtml"
using ProcessAuto.Models.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eff7bc5329d5275b074ae893ca77cdbbd1261a47", @"/Views/HRRegistration/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5aa460c1eed1005e6a5998363494f8e1837c1e9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_HRRegistration_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HumanResources>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"   
    
        <table class=""table"">

            <tr>                
                <th>Surname</th>                
                <th>Name</th>                
                <th>MiddleName</th>                
                <th>Email</th>
                <th>Password</th>
                <th>Company</th>
            </tr>
");
#nullable restore
#line 16 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\HRRegistration\Index.cshtml"
             foreach (HumanResources user in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>                    \r\n                    <td>");
#nullable restore
#line 19 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\HRRegistration\Index.cshtml"
                   Write(user.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                    \r\n                    <td>");
#nullable restore
#line 20 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\HRRegistration\Index.cshtml"
                   Write(user.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                    \r\n                    <td>");
#nullable restore
#line 21 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\HRRegistration\Index.cshtml"
                   Write(user.MiddleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                    \r\n                    <td>");
#nullable restore
#line 22 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\HRRegistration\Index.cshtml"
                   Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\HRRegistration\Index.cshtml"
                   Write(user.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\HRRegistration\Index.cshtml"
                    Write((CompanyNames)user.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 26 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\HRRegistration\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    \r\n\r\n");
#nullable restore
#line 30 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\HRRegistration\Index.cshtml"
     using (Html.BeginForm("Index", "HRRegistration", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <input class=\"btn btn-outline-primary mt-3\" type=\"submit\" value=\"Добавить HR\"/>\r\n");
#nullable restore
#line 33 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\HRRegistration\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HumanResources>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
