#pragma checksum "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Project\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6c01df314197fd16a639b359d1cc9fecab80755"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Index), @"mvc.1.0.view", @"/Views/Project/Index.cshtml")]
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
#line 1 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\_ViewImports.cshtml"
using TimeTrackingSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\_ViewImports.cshtml"
using TimeTrackingSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6c01df314197fd16a639b359d1cc9fecab80755", @"/Views/Project/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"019f640501e4b5f2222f632afe9004f8add10111", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TimeTrackingSystem.Application.ViewModels.Project.ListOfProjectsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-aciton", new global::Microsoft.AspNetCore.Html.HtmlString("Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Project", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Project\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6c01df314197fd16a639b359d1cc9fecab807555095", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6c01df314197fd16a639b359d1cc9fecab807556262", async() => {
                WriteLiteral(@"
    <div class=""row card"">
        <table class=""table table-striped table-hover table-light table-bordered"">
            <thead class=""bg-gradient-light"">
                <tr>
                    <th>
                        Account full name
                    </th>
                    <th>
                        Id
                    </th>
                    <th>
                        Project code
                    </th>
                    <th>
                        Name
                    </th>
                    <th>
                        Location
                    </th>
                    <th>
                        Start date
                    </th>
                    <th>
                        End date
                    </th>
                    <th>
                        Other details
                    </th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 45 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Project\Index.cshtml"
                 foreach (var item in Model.Projects)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 49 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Project\Index.cshtml"
                       Write(Html.ActionLink(item.ApplicationUser.Full_Name, "View", "Employees", new { ApplicationUserId = item.ApplicationUser.Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 53 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Project\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Project.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 56 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Project\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Project.Project_code));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 59 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Project\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Project.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 62 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Project\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Project.Location));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 65 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Project\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Project.Start_date.GetDateTimeFormats()[0]));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 68 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Project\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Project.End_date.GetDateTimeFormats()[0]));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
#nullable restore
#line 72 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Project\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Project.Other_details));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 75 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Project\Index.cshtml"
                       Write(Html.ActionLink("Edit", "EditProject", new { id = item.Project.Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                            ");
#nullable restore
#line 76 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Project\Index.cshtml"
                       Write(Html.ActionLink("Details", "ViewProject", new { id = item.Project.Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                            ");
#nullable restore
#line 77 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Project\Index.cshtml"
                       Write(Html.ActionLink("Activities", "Index", "Activity", new { Id = item.Project.Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                            ");
#nullable restore
#line 78 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Project\Index.cshtml"
                       Write(Html.ActionLink("Delete", "RemoveProject", new { id = item.Project.Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 81 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Project\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <div class=\"row\">\r\n        <table>\r\n            <tr>\r\n");
#nullable restore
#line 88 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Project\Index.cshtml"
                  
                    var rounded = Math.Ceiling(Model.Count / (double)Model.PageSize);
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Project\Index.cshtml"
                 for (int i = 1; i <= Math.Ceiling(Model.Count / (double)Model.PageSize); i++)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>\r\n");
#nullable restore
#line 94 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Project\Index.cshtml"
                         if (i != Model.CurrentPage)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a");
                BeginWriteAttribute("href", " href=\"", 3730, "\"", 3762, 3);
                WriteAttributeValue("", 3737, "javascript:PagerClick(", 3737, 22, true);
#nullable restore
#line 96 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Project\Index.cshtml"
WriteAttributeValue("", 3759, i, 3759, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3761, ")", 3761, 1, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 96 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Project\Index.cshtml"
                                                           Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 97 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Project\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <span>");
#nullable restore
#line 100 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Project\Index.cshtml"
                             Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 101 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Project\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </td>\r\n");
#nullable restore
#line 103 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Project\Index.cshtml"
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TimeTrackingSystem.Application.ViewModels.Project.ListOfProjectsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
