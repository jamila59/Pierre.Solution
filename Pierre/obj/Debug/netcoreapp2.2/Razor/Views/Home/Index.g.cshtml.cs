#pragma checksum "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c648b7f91e789de9cde94355c28b5410167d7b3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/_ViewImports.cshtml"
using Pierre;

#line default
#line hidden
#line 2 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/_ViewImports.cshtml"
using Pierre.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c648b7f91e789de9cde94355c28b5410167d7b3d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc20d470a0c0d7db4e2ce9f78a5834f7898a8234", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Home/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 47, true);
            WriteLiteral("\r\n<h1>Welcome to the Pierre\'s Bakery!</h1>\r\n<p>");
            EndContext();
            BeginContext(78, 52, false);
#line 6 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Home/Index.cshtml"
Write(Html.ActionLink("See all treats", "Index", "Treats"));

#line default
#line hidden
            EndContext();
            BeginContext(130, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(140, 54, false);
#line 7 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Home/Index.cshtml"
Write(Html.ActionLink("See all flavors", "Index", "Flavors"));

#line default
#line hidden
            EndContext();
            BeginContext(194, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(204, 56, false);
#line 8 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Home/Index.cshtml"
Write(Html.ActionLink("Create an account", "Index", "Account"));

#line default
#line hidden
            EndContext();
            BeginContext(260, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
