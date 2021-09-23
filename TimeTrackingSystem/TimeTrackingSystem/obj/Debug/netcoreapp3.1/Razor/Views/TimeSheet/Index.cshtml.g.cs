#pragma checksum "D:\.NET\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\TimeSheet\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "821c649ad0ead5445b690533cb791cf62a7a0141"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TimeSheet_Index), @"mvc.1.0.view", @"/Views/TimeSheet/Index.cshtml")]
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
#line 1 "D:\.NET\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\_ViewImports.cshtml"
using TimeTrackingSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.NET\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\_ViewImports.cshtml"
using TimeTrackingSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"821c649ad0ead5445b690533cb791cf62a7a0141", @"/Views/TimeSheet/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"019f640501e4b5f2222f632afe9004f8add10111", @"/Views/_ViewImports.cshtml")]
    public class Views_TimeSheet_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TimeTrackingSystem.Application.ViewModels.TimeSheet.ListOfTimeSheetsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-aciton", new global::Microsoft.AspNetCore.Html.HtmlString("Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TimeSheet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\.NET\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\TimeSheet\Index.cshtml"
  
    ViewData["Title"] = "TimeSheet";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "821c649ad0ead5445b690533cb791cf62a7a01414559", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <table class=""table table-striped table-hover table-light table-bordered"">
            <thead class=""bg-gradient-light"">
                <tr>
                    <th>
                        Date
                    </th>
                    <th>
                        Time from
                    </th>
                    <th>
                        Time to
                    </th>
                    <th>
                        Comments
                    </th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 28 "D:\.NET\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\TimeSheet\Index.cshtml"
                 foreach (var item in Model.TimeSheets)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 32 "D:\.NET\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\TimeSheet\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TimeSheet.Date.GetDateTimeFormats()[0]));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 35 "D:\.NET\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\TimeSheet\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TimeSheet.Time_from.Date.TimeOfDay));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 38 "D:\.NET\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\TimeSheet\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TimeSheet.Time_to.Date.TimeOfDay));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 41 "D:\.NET\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\TimeSheet\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TimeSheet.Comments));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 44 "D:\.NET\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\TimeSheet\Index.cshtml"
                       Write(Html.ActionLink("Edit", "EditTimeSheet", new { id = item.TimeSheet.Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                            ");
#nullable restore
#line 45 "D:\.NET\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\TimeSheet\Index.cshtml"
                       Write(Html.ActionLink("Details", "ViewTimeSheet", new { id = item.TimeSheet.Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                            ");
#nullable restore
#line 46 "D:\.NET\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\TimeSheet\Index.cshtml"
                       Write(Html.ActionLink("Delete", "RemoveTimeSheet", new { id = item.TimeSheet.Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 49 "D:\.NET\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\TimeSheet\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <div class=\"row\">\r\n        <table>\r\n            <tr>\r\n");
#nullable restore
#line 56 "D:\.NET\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\TimeSheet\Index.cshtml"
                  
                    var rounded = Math.Ceiling(Model.Count / (double)Model.PageSize);
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "D:\.NET\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\TimeSheet\Index.cshtml"
                 for (int i = 1; i <= Math.Ceiling(Model.Count / (double)Model.PageSize); i++)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>\r\n");
#nullable restore
#line 62 "D:\.NET\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\TimeSheet\Index.cshtml"
                         if (i != Model.CurrentPage)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a");
                BeginWriteAttribute("href", " href=\"", 2467, "\"", 2499, 3);
                WriteAttributeValue("", 2474, "javascript:PagerClick(", 2474, 22, true);
#nullable restore
#line 64 "D:\.NET\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\TimeSheet\Index.cshtml"
WriteAttributeValue("", 2496, i, 2496, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2498, ")", 2498, 1, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 64 "D:\.NET\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\TimeSheet\Index.cshtml"
                                                           Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 65 "D:\.NET\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\TimeSheet\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <span>");
#nullable restore
#line 68 "D:\.NET\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\TimeSheet\Index.cshtml"
                             Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 69 "D:\.NET\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\TimeSheet\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </td>\r\n");
#nullable restore
#line 71 "D:\.NET\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\TimeSheet\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tr>\r\n        </table>\r\n        <input type=\"hidden\" name=\"pageNo\" id=\"pageNo\" />\r\n        <input type=\"hidden\" name=\"pageSize\" id=\"pageSize\" value=\"2\" />\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        function PagerClick(index) {\r\n            document.getElementById(\"pageNo\").value = index;\r\n            document.forms[0].submit();\r\n        }\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TimeTrackingSystem.Application.ViewModels.TimeSheet.ListOfTimeSheetsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
