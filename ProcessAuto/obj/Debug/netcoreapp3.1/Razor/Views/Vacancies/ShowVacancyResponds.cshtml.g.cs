#pragma checksum "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "679c4f3b6663dbee3a8131d0429487338133528d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vacancies_ShowVacancyResponds), @"mvc.1.0.view", @"/Views/Vacancies/ShowVacancyResponds.cshtml")]
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
#line 1 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
using ProcessAuto.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
using ProcessAuto.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
using System.Collections;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"679c4f3b6663dbee3a8131d0429487338133528d", @"/Views/Vacancies/ShowVacancyResponds.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5aa460c1eed1005e6a5998363494f8e1837c1e9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Vacancies_ShowVacancyResponds : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "VacancyResponds", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AssignInterview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SetStatusNoOffer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SetStatusOfferSent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
  
    ViewData["Title"] = "Vacancy Responds";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
  
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
#line 28 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
 foreach (VacancyRespondViewModel r in responds)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Vacancy of user ");
#nullable restore
#line 31 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
                   Write(r.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(". </h3>    \r\n");
            WriteLiteral("    <p class=\"mb-1\">About Yourself: ");
#nullable restore
#line 33 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
                               Write(r.AboutYourself);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>    \r\n    <p class=\"mb-1\">Stack: ");
#nullable restore
#line 34 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
                      Write(r.Stack);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>   \r\n    <p class=\"mb-1\">Programming Languages: ");
#nullable restore
#line 35 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
                                      Write(r.ProgrammingLanguages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>   \r\n    <p class=\"mb-1\">Hobbies: ");
#nullable restore
#line 36 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
                        Write(r.Hobbies);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>       \r\n    <p class=\"mb-1\">Working Experience: ");
#nullable restore
#line 37 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
                                   Write(r.WorkingExperience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>         \r\n");
#nullable restore
#line 38 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
    
    if (r.RespondStage == VacancyStage.Sent)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4>Current stage: Получен отклик от студента</h4>\r\n");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "679c4f3b6663dbee3a8131d0429487338133528d9408", async() => {
                WriteLiteral("Assign an Interview");
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
#line 43 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
                                                                                                                                WriteLiteral(r.RespondId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["respondId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-respondId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["respondId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
                                                                                                                                                               WriteLiteral(ViewData["VacId"]);

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
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "679c4f3b6663dbee3a8131d0429487338133528d12945", async() => {
                WriteLiteral("Not interested");
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
#line 44 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
                                                                                                                                WriteLiteral(r.RespondId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["respondId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-respondId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["respondId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
                                                                                                                                                               WriteLiteral(ViewData["VacId"]);

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
#line 45 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
    }
    if (r.RespondStage == VacancyStage.InterviewAssigned)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <h4>Current stage: Назначено собеседование. Текущая дата: ");
#nullable restore
#line 48 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
                                                              Write(r.InterviewDate.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
            WriteLiteral("         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "679c4f3b6663dbee3a8131d0429487338133528d17191", async() => {
                WriteLiteral("Change interview date");
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
#line 50 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
                                                                                                                                 WriteLiteral(r.RespondId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["respondId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-respondId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["respondId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
                                                                                                                                                                WriteLiteral(ViewData["VacId"]);

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
            WriteLiteral("\r\n         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "679c4f3b6663dbee3a8131d0429487338133528d20734", async() => {
                WriteLiteral("Send offer");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-respondId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
                                                                                                                                   WriteLiteral(r.RespondId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["respondId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-respondId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["respondId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
                                                                                                                                                                  WriteLiteral(ViewData["VacId"]);

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
            WriteLiteral("\r\n         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "679c4f3b6663dbee3a8131d0429487338133528d24270", async() => {
                WriteLiteral("No offer");
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
#line 52 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
                                                                                                                                 WriteLiteral(r.RespondId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["respondId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-respondId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["respondId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
                                                                                                                                                                WriteLiteral(ViewData["VacId"]);

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
#line 53 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
    }
    if (r.RespondStage == VacancyStage.NoOffer)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4>Current stage: Оффера не будет.</h4>\r\n");
#nullable restore
#line 57 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
    }
    if (r.RespondStage == VacancyStage.OfferSent)
    {        
        if (r.StudentsVerdict == StudentsVerdict.Awaiting)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h4>Current stage: Проведено собеседование. Студент получил оффер. Ожидается вердикт студента.</h4>\r\n            <div>No answer yet</div>\r\n");
#nullable restore
#line 64 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
        }
        if (r.StudentsVerdict == StudentsVerdict.Declined)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h4>Current stage: Студент отклонил полученный оффер.</h4>\r\n            <div>Offer was DECLINED by student</div> \r\n");
#nullable restore
#line 69 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
        }
        if (r.StudentsVerdict == StudentsVerdict.Accepted) 
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h4>Current stage: Оффер принят студентом.</h4>\r\n            <div>Offer was accepted by student</div>\r\n");
#nullable restore
#line 74 "C:\Users\uz1mane\source\repos\AutoProcesses\ProcessAuto\Views\Vacancies\ShowVacancyResponds.cshtml"
        }
    }

}    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
 
        $(function () {
            $.ajaxSetup({ cache: false });
           $("".respondItem"").click(function (e) {
 
                e.preventDefault();
                $.get(this.href, function (data) {
                    $('#dialogContent').html(data);
                    $('#modDialog').modal('show');
                });
            });
        })
    </script>
");
            }
            );
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
