#pragma checksum "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Flavors/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ae3c6e7a6e5c4839eb62850efe62b951c851183"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flavors_Index), @"mvc.1.0.view", @"/Views/Flavors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Flavors/Index.cshtml", typeof(AspNetCore.Views_Flavors_Index))]
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
#line 5 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Flavors/Index.cshtml"
using Pierre.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ae3c6e7a6e5c4839eb62850efe62b951c851183", @"/Views/Flavors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc20d470a0c0d7db4e2ce9f78a5834f7898a8234", @"/Views/_ViewImports.cshtml")]
    public class Views_Flavors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Pierre.Models.Flavor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Flavors/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(85, 17, true);
            WriteLiteral("\n<h1>Items</h1>\n\n");
            EndContext();
#line 10 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Flavors/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(128, 43, true);
            WriteLiteral("  <h3>No flavors have been added yet!</h3>\n");
            EndContext();
#line 13 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Flavors/Index.cshtml"
} 

#line default
#line hidden
            BeginContext(174, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 15 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Flavors/Index.cshtml"
 foreach (Flavor flavor in Model)
{

#line default
#line hidden
            BeginContext(211, 6, true);
            WriteLiteral("  <li>");
            EndContext();
            BeginContext(218, 81, false);
#line 17 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Flavors/Index.cshtml"
 Write(Html.ActionLink($"{flavor.Description}", "Details", new { id = flavor.FlavorId }));

#line default
#line hidden
            EndContext();
            BeginContext(299, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 18 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Flavors/Index.cshtml"
}

#line default
#line hidden
            BeginContext(307, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(312, 45, false);
#line 20 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Flavors/Index.cshtml"
Write(Html.ActionLink("Add a new flavor", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(357, 9, true);
            WriteLiteral("</p>\n\n<p>");
            EndContext();
            BeginContext(367, 40, false);
#line 22 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Flavors/Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(407, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Pierre.Models.Flavor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
