#pragma checksum "C:\Users\LENOVO\source\repos\PluralSightMVC_App\PluralSightMVC_App\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b0938d6aa44bd6b6cee3a692f8b9585d0e9ae6c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b0938d6aa44bd6b6cee3a692f8b9585d0e9ae6c", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PluralSightMVC_App.ViewModels.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 31, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<h2>\r\n    ");
            EndContext();
            BeginContext(84, 11, false);
#line 6 "C:\Users\LENOVO\source\repos\PluralSightMVC_App\PluralSightMVC_App\Views\Home\Index.cshtml"
Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(95, 9, true);
            WriteLiteral("\r\n</h2>\r\n");
            EndContext();
#line 8 "C:\Users\LENOVO\source\repos\PluralSightMVC_App\PluralSightMVC_App\Views\Home\Index.cshtml"
 foreach (var pie in Model.Pies)
{

#line default
#line hidden
            BeginContext(141, 23, true);
            WriteLiteral("    <div>\r\n        <h2>");
            EndContext();
            BeginContext(165, 8, false);
#line 11 "C:\Users\LENOVO\source\repos\PluralSightMVC_App\PluralSightMVC_App\Views\Home\Index.cshtml"
       Write(pie.Name);

#line default
#line hidden
            EndContext();
            BeginContext(173, 19, true);
            WriteLiteral("</h2>\r\n        <h3>");
            EndContext();
            BeginContext(193, 23, false);
#line 12 "C:\Users\LENOVO\source\repos\PluralSightMVC_App\PluralSightMVC_App\Views\Home\Index.cshtml"
       Write(pie.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(216, 19, true);
            WriteLiteral("</h3>\r\n    </div>\r\n");
            EndContext();
#line 14 "C:\Users\LENOVO\source\repos\PluralSightMVC_App\PluralSightMVC_App\Views\Home\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PluralSightMVC_App.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591