#pragma checksum "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\CarsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17173941216eba012fdd6c05c52e501026fd1dc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CarsList), @"mvc.1.0.view", @"/Views/Home/CarsList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CarsList.cshtml", typeof(AspNetCore.Views_Home_CarsList))]
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
#line 1 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\_ViewImports.cshtml"
using ServerApplication;

#line default
#line hidden
#line 2 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\_ViewImports.cshtml"
using ServerApplication.Models;

#line default
#line hidden
#line 2 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\CarsList.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17173941216eba012fdd6c05c52e501026fd1dc6", @"/Views/Home/CarsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b304e6cde7ad94e6dc263c9c6bdff8e7d702c93f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CarsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ServerApplication.Models.Cars>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Hire", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(86, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\CarsList.cshtml"
  
    ViewData["Title"] = "CarsList";

#line default
#line hidden
            BeginContext(132, 109, true);
            WriteLiteral("\r\n<h1>CarsList</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(242, 41, false);
#line 15 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\CarsList.cshtml"
           Write(Html.DisplayNameFor(model => model.Marka));

#line default
#line hidden
            EndContext();
            BeginContext(283, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(339, 41, false);
#line 18 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\CarsList.cshtml"
           Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
            EndContext();
            BeginContext(380, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(436, 43, false);
#line 21 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\CarsList.cshtml"
           Write(Html.DisplayNameFor(model => model.Rocznik));

#line default
#line hidden
            EndContext();
            BeginContext(479, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(535, 47, false);
#line 24 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\CarsList.cshtml"
           Write(Html.DisplayNameFor(model => model.LiczbaDrzwi));

#line default
#line hidden
            EndContext();
            BeginContext(582, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(638, 44, false);
#line 27 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\CarsList.cshtml"
           Write(Html.DisplayNameFor(model => model.Nadwozie));

#line default
#line hidden
            EndContext();
            BeginContext(682, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(738, 49, false);
#line 30 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\CarsList.cshtml"
           Write(Html.DisplayNameFor(model => model.CenaZaGodzine));

#line default
#line hidden
            EndContext();
            BeginContext(787, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(843, 46, false);
#line 33 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\CarsList.cshtml"
           Write(Html.DisplayNameFor(model => model.Dostepnosc));

#line default
#line hidden
            EndContext();
            BeginContext(889, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 39 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\CarsList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1024, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1085, 40, false);
#line 43 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\CarsList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Marka));

#line default
#line hidden
            EndContext();
            BeginContext(1125, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1193, 40, false);
#line 46 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\CarsList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Model));

#line default
#line hidden
            EndContext();
            BeginContext(1233, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1301, 42, false);
#line 49 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\CarsList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Rocznik));

#line default
#line hidden
            EndContext();
            BeginContext(1343, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1411, 46, false);
#line 52 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\CarsList.cshtml"
               Write(Html.DisplayFor(modelItem => item.LiczbaDrzwi));

#line default
#line hidden
            EndContext();
            BeginContext(1457, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1525, 43, false);
#line 55 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\CarsList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nadwozie));

#line default
#line hidden
            EndContext();
            BeginContext(1568, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1636, 48, false);
#line 58 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\CarsList.cshtml"
               Write(Html.DisplayFor(modelItem => item.CenaZaGodzine));

#line default
#line hidden
            EndContext();
            BeginContext(1684, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1752, 45, false);
#line 61 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\CarsList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Dostepnosc));

#line default
#line hidden
            EndContext();
            BeginContext(1797, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 64 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\CarsList.cshtml"
                     if (Context.Session.GetString("userEmail") == null)
                    {

#line default
#line hidden
            BeginContext(1941, 57, true);
            WriteLiteral("                        <a>zaloguj aby zarezerwować</a>\r\n");
            EndContext();
#line 67 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\CarsList.cshtml"
                    }
                    else
                    {
                        if (item.Dostepnosc == true)
                        {

#line default
#line hidden
            BeginContext(2151, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2175, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17173941216eba012fdd6c05c52e501026fd1dc611141", async() => {
                BeginContext(2221, 8, true);
                WriteLiteral("Wynajmij");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\CarsList.cshtml"
                                              WriteLiteral(item.CarId);

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
            BeginContext(2233, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 73 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\CarsList.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(2285, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 77 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\CarsList.cshtml"
        }

#line default
#line hidden
            BeginContext(2338, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ServerApplication.Models.Cars>> Html { get; private set; }
    }
}
#pragma warning restore 1591
