#pragma checksum "C:\ASP NET Core\JF Mimic\JF Mimic\MVCDemo - PreDashboardLab\MVCDemo\Views\Home\SimpleWithModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a10a219a7bd20ac910152bdb843c079536dfd72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SimpleWithModel), @"mvc.1.0.view", @"/Views/Home/SimpleWithModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/SimpleWithModel.cshtml", typeof(AspNetCore.Views_Home_SimpleWithModel))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a10a219a7bd20ac910152bdb843c079536dfd72", @"/Views/Home/SimpleWithModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20c82645f380a66647f653cb87c3f0bf90f91097", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SimpleWithModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCDemo.Controllers.Info>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\ASP NET Core\JF Mimic\JF Mimic\MVCDemo - PreDashboardLab\MVCDemo\Views\Home\SimpleWithModel.cshtml"
  
    ViewData["Title"] = "SimpleWithModel";

#line default
#line hidden
            BeginContext(84, 33, true);
            WriteLiteral("\r\n<h2>SimpleWithModel</h2>\r\n\r\n<p>");
            EndContext();
            BeginContext(118, 13, false);
#line 8 "C:\ASP NET Core\JF Mimic\JF Mimic\MVCDemo - PreDashboardLab\MVCDemo\Views\Home\SimpleWithModel.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(131, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCDemo.Controllers.Info> Html { get; private set; }
    }
}
#pragma warning restore 1591
