#pragma checksum "C:\Users\LENOVO\source\repos\PluralSightMVC_App\PluralSightMVC_App\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42697b3a6c6d0602efe038d3fc6d60c44f79a113"
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
#line 1 "C:\Users\LENOVO\source\repos\PluralSightMVC_App\PluralSightMVC_App\Views\_ViewImports.cshtml"
using PluralSightMVC_App.Models;

#line default
#line hidden
#line 2 "C:\Users\LENOVO\source\repos\PluralSightMVC_App\PluralSightMVC_App\Views\_ViewImports.cshtml"
using PluralSightMVC_App.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42697b3a6c6d0602efe038d3fc6d60c44f79a113", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f5c1ddd19fc8ca0a1b23ca8e247b829191c4354", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(22, 31, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<h2>\r\n    ");
            EndContext();
            BeginContext(54, 11, false);
#line 6 "C:\Users\LENOVO\source\repos\PluralSightMVC_App\PluralSightMVC_App\Views\Home\Index.cshtml"
Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(65, 9, true);
            WriteLiteral("\r\n</h2>\r\n");
            EndContext();
#line 8 "C:\Users\LENOVO\source\repos\PluralSightMVC_App\PluralSightMVC_App\Views\Home\Index.cshtml"
 foreach (var pie in Model.Pies)
{

#line default
#line hidden
            BeginContext(111, 95, true);
            WriteLiteral("    <div class=\"col-sm-4 col-lg-4 col-md-4\">\r\n        <div class=\"thumbnail\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 206, "\"", 234, 1);
#line 12 "C:\Users\LENOVO\source\repos\PluralSightMVC_App\PluralSightMVC_App\Views\Home\Index.cshtml"
WriteAttributeValue("", 212, pie.ImageThumbnailUrl, 212, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(235, 86, true);
            WriteLiteral(" alt=\"\" />\r\n            <div class=\"caption\">\r\n                <h3 class=\"pull-right\">");
            EndContext();
            BeginContext(322, 23, false);
#line 14 "C:\Users\LENOVO\source\repos\PluralSightMVC_App\PluralSightMVC_App\Views\Home\Index.cshtml"
                                  Write(pie.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(345, 49, true);
            WriteLiteral("</h3>\r\n                <h3>\r\n                    ");
            EndContext();
            BeginContext(394, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42697b3a6c6d0602efe038d3fc6d60c44f79a1135516", async() => {
                BeginContext(465, 8, false);
#line 16 "C:\Users\LENOVO\source\repos\PluralSightMVC_App\PluralSightMVC_App\Views\Home\Index.cshtml"
                                                                                     Write(pie.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 16 "C:\Users\LENOVO\source\repos\PluralSightMVC_App\PluralSightMVC_App\Views\Home\Index.cshtml"
                                                                    WriteLiteral(pie.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(477, 44, true);
            WriteLiteral("\r\n                </h3>\r\n                <p>");
            EndContext();
            BeginContext(522, 20, false);
#line 18 "C:\Users\LENOVO\source\repos\PluralSightMVC_App\PluralSightMVC_App\Views\Home\Index.cshtml"
              Write(pie.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(542, 54, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 22 "C:\Users\LENOVO\source\repos\PluralSightMVC_App\PluralSightMVC_App\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
