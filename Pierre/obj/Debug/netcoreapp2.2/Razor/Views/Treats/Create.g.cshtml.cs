#pragma checksum "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Treats/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd11a05b5efe7ff8fd8bcfb428fe53d7f394ec63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Treats_Create), @"mvc.1.0.view", @"/Views/Treats/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Treats/Create.cshtml", typeof(AspNetCore.Views_Treats_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd11a05b5efe7ff8fd8bcfb428fe53d7f394ec63", @"/Views/Treats/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc20d470a0c0d7db4e2ce9f78a5834f7898a8234", @"/Views/_ViewImports.cshtml")]
    public class Views_Treats_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pierre.Models.Treat>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Treats/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(55, 20, true);
            WriteLiteral("\n<h4>Add treat</h4>\n");
            EndContext();
#line 8 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Treats/Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(108, 34, false);
#line 10 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Treats/Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(148, 36, false);
#line 11 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Treats/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(185, 50, true);
            WriteLiteral("    <input type=\"submit\" value=\"Add new treat\" />\n");
            EndContext();
#line 13 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Treats/Create.cshtml"
}

#line default
#line hidden
            BeginContext(237, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(241, 43, false);
#line 14 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Treats/Create.cshtml"
Write(Html.ActionLink("Show all treats", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(284, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pierre.Models.Treat> Html { get; private set; }
    }
}
#pragma warning restore 1591
