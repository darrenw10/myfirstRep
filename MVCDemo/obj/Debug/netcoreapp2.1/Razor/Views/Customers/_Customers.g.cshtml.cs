#pragma checksum "C:\ASP NET Core\JF Mimic\JF Mimic\MVCDemo - PreDashboardLab\MVCDemo\Views\Customers\_Customers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cf7ddaf882f63eaed5de02f5fc460bbf135fefd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers__Customers), @"mvc.1.0.view", @"/Views/Customers/_Customers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customers/_Customers.cshtml", typeof(AspNetCore.Views_Customers__Customers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cf7ddaf882f63eaed5de02f5fc460bbf135fefd", @"/Views/Customers/_Customers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20c82645f380a66647f653cb87c3f0bf90f91097", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers__Customers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 46, true);
            WriteLiteral("\r\n<div class=\"panel panel-default\">\r\n    <div>");
            EndContext();
            BeginContext(64, 10, false);
#line 4 "C:\ASP NET Core\JF Mimic\JF Mimic\MVCDemo - PreDashboardLab\MVCDemo\Views\Customers\_Customers.cshtml"
    Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(74, 17, true);
            WriteLiteral("</div>\r\n    <div>");
            EndContext();
            BeginContext(92, 10, false);
#line 5 "C:\ASP NET Core\JF Mimic\JF Mimic\MVCDemo - PreDashboardLab\MVCDemo\Views\Customers\_Customers.cshtml"
    Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(102, 14, true);
            WriteLiteral("</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
