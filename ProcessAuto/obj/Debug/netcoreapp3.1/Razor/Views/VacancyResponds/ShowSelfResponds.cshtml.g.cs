#pragma checksum "C:\Users\ukwim\Documents\proc\AutoProcesses\ProcessAuto\Views\VacancyResponds\ShowSelfResponds.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79a8916af747453e60b3ad0d7eb3528f2c768e8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VacancyResponds_ShowSelfResponds), @"mvc.1.0.view", @"/Views/VacancyResponds/ShowSelfResponds.cshtml")]
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
#line 1 "C:\Users\ukwim\Documents\proc\AutoProcesses\ProcessAuto\Views\_ViewImports.cshtml"
using ProcessAuto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ukwim\Documents\proc\AutoProcesses\ProcessAuto\Views\_ViewImports.cshtml"
using ProcessAuto.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ukwim\Documents\proc\AutoProcesses\ProcessAuto\Views\VacancyResponds\ShowSelfResponds.cshtml"
using ProcessAuto.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ukwim\Documents\proc\AutoProcesses\ProcessAuto\Views\VacancyResponds\ShowSelfResponds.cshtml"
using System.Collections;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79a8916af747453e60b3ad0d7eb3528f2c768e8c", @"/Views/VacancyResponds/ShowSelfResponds.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5aa460c1eed1005e6a5998363494f8e1837c1e9", @"/Views/_ViewImports.cshtml")]
    public class Views_VacancyResponds_ShowSelfResponds : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "VacancyResponds", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AcceptOffer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeclineOffer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\ukwim\Documents\proc\AutoProcesses\ProcessAuto\Views\VacancyResponds\ShowSelfResponds.cshtml"
  
    ViewData["Title"] = "Мои отклики";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>");
#nullable restore
#line 11 "C:\Users\ukwim\Documents\proc\AutoProcesses\ProcessAuto\Views\VacancyResponds\ShowSelfResponds.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\ukwim\Documents\proc\AutoProcesses\ProcessAuto\Views\VacancyResponds\ShowSelfResponds.cshtml"
  
    IEnumerable<VacancyRespondViewModel> responds = ViewData["Responds"] as IEnumerable<VacancyRespondViewModel>; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""modDialog"" class=""modal fade"" >
    <div id=""dialogContent"" class=""modal-dialog""></div>
</div>

<div class=""list-group"">

    <div id=""modDialog"" class=""modal fade"" >
        <div id=""dialogContent"" class=""modal-dialog""></div>
    </div>

");
#nullable restore
#line 27 "C:\Users\ukwim\Documents\proc\AutoProcesses\ProcessAuto\Views\VacancyResponds\ShowSelfResponds.cshtml"
 foreach (VacancyRespondViewModel r in responds)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Отклик на вакансию в ");
#nullable restore
#line 30 "C:\Users\ukwim\Documents\proc\AutoProcesses\ProcessAuto\Views\VacancyResponds\ShowSelfResponds.cshtml"
                        Write(r.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral(". </h3>    \r\n");
            WriteLiteral("    <p class=\"mb-1\">Позиция: ");
#nullable restore
#line 32 "C:\Users\ukwim\Documents\proc\AutoProcesses\ProcessAuto\Views\VacancyResponds\ShowSelfResponds.cshtml"
                        Write(r.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>    \r\n    <p class=\"mb-1\">Cтэк: ");
#nullable restore
#line 33 "C:\Users\ukwim\Documents\proc\AutoProcesses\ProcessAuto\Views\VacancyResponds\ShowSelfResponds.cshtml"
                     Write(r.VacancyStack);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>   \r\n    <p class=\"mb-1\">Количество мест: ");
#nullable restore
#line 34 "C:\Users\ukwim\Documents\proc\AutoProcesses\ProcessAuto\Views\VacancyResponds\ShowSelfResponds.cshtml"
                                Write(r.Slots);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>           \r\n");
#nullable restore
#line 35 "C:\Users\ukwim\Documents\proc\AutoProcesses\ProcessAuto\Views\VacancyResponds\ShowSelfResponds.cshtml"

    if (r.RespondStage == VacancyStage.Sent)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4>Current stage: Ожидается реакция HR\'а компании</h4>       \r\n");
#nullable restore
#line 39 "C:\Users\ukwim\Documents\proc\AutoProcesses\ProcessAuto\Views\VacancyResponds\ShowSelfResponds.cshtml"
    }
    if (r.RespondStage == VacancyStage.InterviewAssigned)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <h4>Current stage: Назначено собеседование. Текущая дата: ");
#nullable restore
#line 42 "C:\Users\ukwim\Documents\proc\AutoProcesses\ProcessAuto\Views\VacancyResponds\ShowSelfResponds.cshtml"
                                                              Write(r.InterviewDate.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>         \r\n");
#nullable restore
#line 43 "C:\Users\ukwim\Documents\proc\AutoProcesses\ProcessAuto\Views\VacancyResponds\ShowSelfResponds.cshtml"
    }
    if (r.RespondStage == VacancyStage.NoOffer)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4>Current stage: Оффера не будет.</h4>\r\n");
#nullable restore
#line 47 "C:\Users\ukwim\Documents\proc\AutoProcesses\ProcessAuto\Views\VacancyResponds\ShowSelfResponds.cshtml"
    }
    if (r.RespondStage == VacancyStage.OfferSent)
    {       
        if (r.StudentsVerdict == StudentsVerdict.Awaiting)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h4>Current stage: Поздравляем! Вы получили оффер по этому отклику. Вы можете принять либо отклонить его.</h4>\r\n");
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79a8916af747453e60b3ad0d7eb3528f2c768e8c10153", async() => {
                WriteLiteral("Принять оффер");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-respondId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\ukwim\Documents\proc\AutoProcesses\ProcessAuto\Views\VacancyResponds\ShowSelfResponds.cshtml"
                                                                                                                                WriteLiteral(r.RespondId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["respondId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-respondId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["respondId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\ukwim\Documents\proc\AutoProcesses\ProcessAuto\Views\VacancyResponds\ShowSelfResponds.cshtml"
                                                                                                                                                               WriteLiteral(r.VacancyId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["vacId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-vacId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["vacId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79a8916af747453e60b3ad0d7eb3528f2c768e8c13689", async() => {
                WriteLiteral("Отказаться от оффера");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-respondId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\ukwim\Documents\proc\AutoProcesses\ProcessAuto\Views\VacancyResponds\ShowSelfResponds.cshtml"
                                                                                                                                WriteLiteral(r.RespondId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["respondId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-respondId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["respondId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\ukwim\Documents\proc\AutoProcesses\ProcessAuto\Views\VacancyResponds\ShowSelfResponds.cshtml"
                                                                                                                                                               WriteLiteral(r.VacancyId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["vacId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-vacId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["vacId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 56 "C:\Users\ukwim\Documents\proc\AutoProcesses\ProcessAuto\Views\VacancyResponds\ShowSelfResponds.cshtml"
        }
        
        if (r.StudentsVerdict == StudentsVerdict.Declined)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h4>Current stage: Вы отклонили данный оффер.</h4>\r\n            <div>Offer was DECLINED by student</div> \r\n");
#nullable restore
#line 62 "C:\Users\ukwim\Documents\proc\AutoProcesses\ProcessAuto\Views\VacancyResponds\ShowSelfResponds.cshtml"
        }
        if (r.StudentsVerdict == StudentsVerdict.Accepted) 
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h4>Current stage: Поздравляем! Вы приняли данный оффер.</h4>\r\n            <div>Offer was ACCEPTED by student</div>\r\n");
#nullable restore
#line 67 "C:\Users\ukwim\Documents\proc\AutoProcesses\ProcessAuto\Views\VacancyResponds\ShowSelfResponds.cshtml"
        }
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr>\r\n");
#nullable restore
#line 71 "C:\Users\ukwim\Documents\proc\AutoProcesses\ProcessAuto\Views\VacancyResponds\ShowSelfResponds.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591