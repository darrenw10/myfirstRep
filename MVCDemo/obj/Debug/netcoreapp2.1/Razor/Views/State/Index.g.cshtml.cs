#pragma checksum "C:\ASP NET Core\JF Mimic\JF Mimic\MVCDemo - PreDashboardLab\MVCDemo\Views\State\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c4527672165c28c89e8f311dc39642650d4b6a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_State_Index), @"mvc.1.0.view", @"/Views/State/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/State/Index.cshtml", typeof(AspNetCore.Views_State_Index))]
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
#line 1 "C:\ASP NET Core\JF Mimic\JF Mimic\MVCDemo - PreDashboardLab\MVCDemo\Views\_ViewImports.cshtml"
using MVCDemo;

#line default
#line hidden
#line 2 "C:\ASP NET Core\JF Mimic\JF Mimic\MVCDemo - PreDashboardLab\MVCDemo\Views\_ViewImports.cshtml"
using MVCDemo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c4527672165c28c89e8f311dc39642650d4b6a7", @"/Views/State/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20c82645f380a66647f653cb87c3f0bf90f91097", @"/Views/_ViewImports.cshtml")]
    public class Views_State_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StateViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\ASP NET Core\JF Mimic\JF Mimic\MVCDemo - PreDashboardLab\MVCDemo\Views\State\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(64, 47, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    QueryStringCount: ");
            EndContext();
            BeginContext(112, 22, false);
#line 9 "C:\ASP NET Core\JF Mimic\JF Mimic\MVCDemo - PreDashboardLab\MVCDemo\Views\State\Index.cshtml"
                 Write(Model.QueryStringCount);

#line default
#line hidden
            EndContext();
            BeginContext(134, 28, true);
            WriteLiteral("\r\n</p>\r\n<p>\r\n    FormCount: ");
            EndContext();
            BeginContext(163, 15, false);
#line 12 "C:\ASP NET Core\JF Mimic\JF Mimic\MVCDemo - PreDashboardLab\MVCDemo\Views\State\Index.cshtml"
          Write(Model.FormCount);

#line default
#line hidden
            EndContext();
            BeginContext(178, 31, true);
            WriteLiteral("\r\n</p>\r\n<p>\r\n    SessionCount: ");
            EndContext();
            BeginContext(210, 18, false);
#line 15 "C:\ASP NET Core\JF Mimic\JF Mimic\MVCDemo - PreDashboardLab\MVCDemo\Views\State\Index.cshtml"
             Write(Model.SessionCount);

#line default
#line hidden
            EndContext();
            BeginContext(228, 30, true);
            WriteLiteral("\r\n</p>\r\n<p>\r\n    CookieCount: ");
            EndContext();
            BeginContext(259, 17, false);
#line 18 "C:\ASP NET Core\JF Mimic\JF Mimic\MVCDemo - PreDashboardLab\MVCDemo\Views\State\Index.cshtml"
            Write(Model.CookieCount);

#line default
#line hidden
            EndContext();
            BeginContext(276, 10, true);
            WriteLiteral("\r\n</p>\r\n\r\n");
            EndContext();
            BeginContext(286, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e14e47ee1906413bafc2e26ccb773931", async() => {
                BeginContext(361, 5, true);
                WriteLiteral("Click");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-queryStringCount", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 21 "C:\ASP NET Core\JF Mimic\JF Mimic\MVCDemo - PreDashboardLab\MVCDemo\Views\State\Index.cshtml"
                                      WriteLiteral(Model.QueryStringCount);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["queryStringCount"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-queryStringCount", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["queryStringCount"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(370, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(558, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
