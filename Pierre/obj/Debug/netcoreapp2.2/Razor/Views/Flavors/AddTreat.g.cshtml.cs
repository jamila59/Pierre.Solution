#pragma checksum "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Flavors/AddTreat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8b10216217d92ff17394b4a47e227b2f1f7ca50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flavors_AddTreat), @"mvc.1.0.view", @"/Views/Flavors/AddTreat.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Flavors/AddTreat.cshtml", typeof(AspNetCore.Views_Flavors_AddTreat))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8b10216217d92ff17394b4a47e227b2f1f7ca50", @"/Views/Flavors/AddTreat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc20d470a0c0d7db4e2ce9f78a5834f7898a8234", @"/Views/_ViewImports.cshtml")]
    public class Views_Flavors_AddTreat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pierre.Models.Flavor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Flavors/AddTreat.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(56, 55, true);
            WriteLiteral("\n<h2>Add a treat</h2>\n\n<h4>Add a treat to this Flavor: ");
            EndContext();
            BeginContext(112, 43, false);
#line 9 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Flavors/AddTreat.cshtml"
                           Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(155, 7, true);
            WriteLiteral("</h4>\n\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Flavors/AddTreat.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(195, 39, false);
#line 13 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Flavors/AddTreat.cshtml"
Write(Html.HiddenFor(model => model.FlavorId));

#line default
#line hidden
            EndContext();
            BeginContext(241, 26, false);
#line 15 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Flavors/AddTreat.cshtml"
Write(Html.Label("Select Treat"));

#line default
#line hidden
            EndContext();
            BeginContext(273, 28, false);
#line 16 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Flavors/AddTreat.cshtml"
Write(Html.DropDownList("TreatId"));

#line default
#line hidden
            EndContext();
            BeginContext(303, 41, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\n");
            EndContext();
#line 19 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Flavors/AddTreat.cshtml"
}

#line default
#line hidden
            BeginContext(346, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(351, 40, false);
#line 21 "/Users/Guest/Desktop/Pierre.Solution/Pierre/Views/Flavors/AddTreat.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(391, 5, true);
            WriteLiteral("</p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pierre.Models.Flavor> Html { get; private set; }
    }
}
#pragma warning restore 1591
