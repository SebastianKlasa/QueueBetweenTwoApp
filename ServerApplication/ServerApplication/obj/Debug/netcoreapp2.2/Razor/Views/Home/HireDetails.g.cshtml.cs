#pragma checksum "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4f2ac35b04b6000256ec1dc2e3a1d3528b59464"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HireDetails), @"mvc.1.0.view", @"/Views/Home/HireDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/HireDetails.cshtml", typeof(AspNetCore.Views_Home_HireDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4f2ac35b04b6000256ec1dc2e3a1d3528b59464", @"/Views/Home/HireDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b304e6cde7ad94e6dc263c9c6bdff8e7d702c93f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_HireDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ServerApplication.Models.Hire>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "changeStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PayForHire", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml"
  
    ViewData["Title"] = "HireDetails";

#line default
#line hidden
            BeginContext(87, 214, true);
            WriteLiteral("\r\n<h1>HireDetails</h1>\r\n\r\n<div>\r\n    <h4>Szczegóły</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            Rozpoczęcie wynajmu\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(302, 43, false);
#line 17 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml"
       Write(Html.DisplayFor(model => model.DataWynajmu));

#line default
#line hidden
            EndContext();
            BeginContext(345, 140, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Zakończenie wynajmu\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(486, 54, false);
#line 23 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml"
       Write(Html.DisplayFor(model => model.DataZakonczeniaWynajmu));

#line default
#line hidden
            EndContext();
            BeginContext(540, 133, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Cena wynajmu\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(674, 43, false);
#line 29 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml"
       Write(Html.DisplayFor(model => model.CenaWynajmu));

#line default
#line hidden
            EndContext();
            BeginContext(717, 73, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n<div id=\"yourdivid\"></div>\r\n<div>\r\n");
            EndContext();
#line 36 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml"
     if (Model.StatusWypozyczenia != "usuniety")
    {

#line default
#line hidden
            BeginContext(847, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(855, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4f2ac35b04b6000256ec1dc2e3a1d3528b594647240", async() => {
                BeginContext(913, 14, true);
                WriteLiteral("|Zmień status|");
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
#line 38 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml"
                                       WriteLiteral(Model.HireId);

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
            BeginContext(931, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(941, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4f2ac35b04b6000256ec1dc2e3a1d3528b594649588", async() => {
                BeginContext(993, 6, true);
                WriteLiteral("|Usuń|");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml"
                                 WriteLiteral(Model.HireId);

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
            BeginContext(1003, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1013, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4f2ac35b04b6000256ec1dc2e3a1d3528b5946411923", async() => {
                BeginContext(1069, 22, true);
                WriteLiteral("|Oznacz jako opłacone|");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml"
                                     WriteLiteral(Model.HireId);

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
            BeginContext(1095, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 41 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml"
    }

#line default
#line hidden
            BeginContext(1104, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1108, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4f2ac35b04b6000256ec1dc2e3a1d3528b5946414506", async() => {
                BeginContext(1130, 9, true);
                WriteLiteral("|Zakończ|");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1143, 117, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    <h4>Pojazd</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1261, 45, false);
#line 50 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Car.Marka));

#line default
#line hidden
            EndContext();
            BeginContext(1306, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1368, 41, false);
#line 53 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml"
       Write(Html.DisplayFor(model => model.Car.Marka));

#line default
#line hidden
            EndContext();
            BeginContext(1409, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1470, 45, false);
#line 56 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Car.Model));

#line default
#line hidden
            EndContext();
            BeginContext(1515, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1577, 41, false);
#line 59 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml"
       Write(Html.DisplayFor(model => model.Car.Model));

#line default
#line hidden
            EndContext();
            BeginContext(1618, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1679, 47, false);
#line 62 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Car.Rocznik));

#line default
#line hidden
            EndContext();
            BeginContext(1726, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1788, 43, false);
#line 65 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml"
       Write(Html.DisplayFor(model => model.Car.Rocznik));

#line default
#line hidden
            EndContext();
            BeginContext(1831, 147, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n<div>\r\n    <h4>Użytkownik</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1979, 45, false);
#line 75 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.User.Imie));

#line default
#line hidden
            EndContext();
            BeginContext(2024, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2086, 41, false);
#line 78 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml"
       Write(Html.DisplayFor(model => model.User.Imie));

#line default
#line hidden
            EndContext();
            BeginContext(2127, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2188, 49, false);
#line 81 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.User.Nazwisko));

#line default
#line hidden
            EndContext();
            BeginContext(2237, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2299, 45, false);
#line 84 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml"
       Write(Html.DisplayFor(model => model.User.Nazwisko));

#line default
#line hidden
            EndContext();
            BeginContext(2344, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2405, 48, false);
#line 87 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.User.Telefon));

#line default
#line hidden
            EndContext();
            BeginContext(2453, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2515, 44, false);
#line 90 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml"
       Write(Html.DisplayFor(model => model.User.Telefon));

#line default
#line hidden
            EndContext();
            BeginContext(2559, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2620, 54, false);
#line 93 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.User.DataUrodzenia));

#line default
#line hidden
            EndContext();
            BeginContext(2674, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2736, 50, false);
#line 96 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml"
       Write(Html.DisplayFor(model => model.User.DataUrodzenia));

#line default
#line hidden
            EndContext();
            BeginContext(2786, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2847, 46, false);
#line 99 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.User.Adres));

#line default
#line hidden
            EndContext();
            BeginContext(2893, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2955, 42, false);
#line 102 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml"
       Write(Html.DisplayFor(model => model.User.Adres));

#line default
#line hidden
            EndContext();
            BeginContext(2997, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3058, 46, false);
#line 105 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.User.Email));

#line default
#line hidden
            EndContext();
            BeginContext(3104, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3166, 42, false);
#line 108 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml"
       Write(Html.DisplayFor(model => model.User.Email));

#line default
#line hidden
            EndContext();
            BeginContext(3208, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(3246, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4f2ac35b04b6000256ec1dc2e3a1d3528b5946423767", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3307, 231, true);
            WriteLiteral("\r\n<script src=\"https://code.jquery.com/jquery-1.11.0.min.js\"></script>\r\n<script>\r\n    \"use strict\";\r\n\r\n    function drawHires() {\r\n        $.ajax({\r\n            type: \'GET\',\r\n            url: \"https://localhost:44324/api/GetHire/\"+");
            EndContext();
            BeginContext(3539, 12, false);
#line 121 "E:\KSRprojekt\ServerApplication\ServerApplication\Views\Home\HireDetails.cshtml"
                                                   Write(Model.HireId);

#line default
#line hidden
            EndContext();
            BeginContext(3551, 1029, true);
            WriteLiteral(@",
            data: { get_param: 'value' },
            dataType: 'json',
            success: function (data) {
                var status = data.StatusWypozyczenia;
                var zaplacone = data.CzyOplacone;
                var zaplaconeStatus;
                if (zaplacone == true) {
                    zaplaconeStatus = ""tak"";
                }
                else {
                    zaplaconeStatus = ""nie"";
                }
                var content = ""<ul><li>Status wypozyczenia: ""+ status +""</li><li>Opłacone: ""+ zaplaconeStatus +""</li></ul>"";
                console.log(data);
                $('#yourdivid').html(content);
            },
            error: function (e) {
                console.log(e);
            }
        });
    }

    drawHires();

    var connection = new signalR.HubConnectionBuilder().withUrl(""/listHub"").build();

    connection.on(""ReceiveMessage"", function (user, message) {
        drawHires();
    });

    connection.start();

</sc");
            WriteLiteral("ript>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServerApplication.Models.Hire> Html { get; private set; }
    }
}
#pragma warning restore 1591
