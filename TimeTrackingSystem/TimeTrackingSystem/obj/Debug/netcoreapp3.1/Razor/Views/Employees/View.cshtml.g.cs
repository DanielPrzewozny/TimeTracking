#pragma checksum "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Employees\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f0df74aa219d0b7ee1d45c19a7e7a502c5fe13a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_View), @"mvc.1.0.view", @"/Views/Employees/View.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f0df74aa219d0b7ee1d45c19a7e7a502c5fe13a", @"/Views/Employees/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"019f640501e4b5f2222f632afe9004f8add10111", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TimeTrackingSystem.Application.ViewModels.EmployeeDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Employees\View.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>View</h1>\r\n\r\n<div>\r\n    <h4>EmployeeDetailsViewModel</h4>\r\n    <hr />\r\n    <dl class=\"row card\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Employees\View.cshtml"
       Write(Html.DisplayNameFor(model => model.Full_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Employees\View.cshtml"
       Write(Html.DisplayFor(model => model.Full_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Employees\View.cshtml"
       Write(Html.DisplayNameFor(model => model.First_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Employees\View.cshtml"
       Write(Html.DisplayFor(model => model.First_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Employees\View.cshtml"
       Write(Html.DisplayNameFor(model => model.Last_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Employees\View.cshtml"
       Write(Html.DisplayFor(model => model.Last_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Employees\View.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Employees\View.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Employees\View.cshtml"
       Write(Html.DisplayNameFor(model => model.PhotoProfile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Employees\View.cshtml"
       Write(Html.DisplayFor(model => model.PhotoProfile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 46 "C:\Users\DP\Documents\Project\jcszr3-On-c-eHuman\TimeTrackingSystem\TimeTrackingSystem\Views\Employees\View.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f0df74aa219d0b7ee1d45c19a7e7a502c5fe13a7864", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TimeTrackingSystem.Application.ViewModels.EmployeeDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
