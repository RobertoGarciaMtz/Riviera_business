#pragma checksum "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d056b51c8acede628ec6f1926e7ba45b6043aea5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TbCondiciones_Details), @"mvc.1.0.view", @"/Views/TbCondiciones/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\_ViewImports.cshtml"
using Riviera_Business;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\_ViewImports.cshtml"
using Riviera_Business.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d056b51c8acede628ec6f1926e7ba45b6043aea5", @"/Views/TbCondiciones/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba7bc4482e732b495e27471032f90489653d037d", @"/Views/_ViewImports.cshtml")]
    public class Views_TbCondiciones_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Riviera_Business.Models.TbCondiciones>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>TbCondiciones</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LlantaDi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 17 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
             if (Model.LlantaDi == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 395, "\"", 418, 1);
#nullable restore
#line 19 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
WriteAttributeValue("", 403, Model.LlantaDi, 403, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Nueva</label>\r\n");
#nullable restore
#line 20 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
             if (Model.LlantaDi == 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 526, "\"", 549, 1);
#nullable restore
#line 23 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
WriteAttributeValue("", 534, Model.LlantaDi, 534, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Mitad</label>\r\n");
#nullable restore
#line 24 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
             if (Model.LlantaDi == 3)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 657, "\"", 680, 1);
#nullable restore
#line 27 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
WriteAttributeValue("", 665, Model.LlantaDi, 665, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cuarto</label>\r\n");
#nullable restore
#line 28 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
             if (Model.LlantaDi == 4)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 789, "\"", 812, 1);
#nullable restore
#line 31 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
WriteAttributeValue("", 797, Model.LlantaDi, 797, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Lisa</label>\r\n");
#nullable restore
#line 32 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LlantaDd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 38 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
             if (Model.LlantaDd == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 1071, "\"", 1094, 1);
#nullable restore
#line 40 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
WriteAttributeValue("", 1079, Model.LlantaDd, 1079, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Nueva</label>\r\n");
#nullable restore
#line 41 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
             if (Model.LlantaDd == 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 1202, "\"", 1225, 1);
#nullable restore
#line 44 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
WriteAttributeValue("", 1210, Model.LlantaDd, 1210, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Mitad</label>\r\n");
#nullable restore
#line 45 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
             if (Model.LlantaDd == 3)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 1333, "\"", 1356, 1);
#nullable restore
#line 48 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
WriteAttributeValue("", 1341, Model.LlantaDd, 1341, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cuarto</label>\r\n");
#nullable restore
#line 49 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
             if (Model.LlantaDd == 4)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 1465, "\"", 1488, 1);
#nullable restore
#line 52 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
WriteAttributeValue("", 1473, Model.LlantaDd, 1473, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Lisa</label>\r\n");
#nullable restore
#line 53 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LlanraTi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n\r\n");
#nullable restore
#line 60 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
             if (Model.LlanraTi == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 1749, "\"", 1772, 1);
#nullable restore
#line 62 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
WriteAttributeValue("", 1757, Model.LlanraTi, 1757, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Nueva</label>\r\n");
#nullable restore
#line 63 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
             if (Model.LlanraTi == 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 1880, "\"", 1903, 1);
#nullable restore
#line 66 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
WriteAttributeValue("", 1888, Model.LlanraTi, 1888, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Mitad</label>\r\n");
#nullable restore
#line 67 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
             if (Model.LlanraTi == 3)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 2011, "\"", 2034, 1);
#nullable restore
#line 70 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
WriteAttributeValue("", 2019, Model.LlanraTi, 2019, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cuarto</label>\r\n");
#nullable restore
#line 71 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
             if (Model.LlanraTi == 4)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 2143, "\"", 2166, 1);
#nullable restore
#line 74 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
WriteAttributeValue("", 2151, Model.LlanraTi, 2151, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Lisa</label>\r\n");
#nullable restore
#line 75 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 78 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LlantaTd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n\r\n");
#nullable restore
#line 82 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
             if (Model.LlantaTd == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 2427, "\"", 2450, 1);
#nullable restore
#line 84 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
WriteAttributeValue("", 2435, Model.LlantaTd, 2435, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Nueva</label>\r\n");
#nullable restore
#line 85 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
             if (Model.LlantaTd == 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 2558, "\"", 2581, 1);
#nullable restore
#line 88 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
WriteAttributeValue("", 2566, Model.LlantaTd, 2566, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Mitad</label>\r\n");
#nullable restore
#line 89 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
             if (Model.LlantaTd == 3)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 2689, "\"", 2712, 1);
#nullable restore
#line 92 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
WriteAttributeValue("", 2697, Model.LlantaTd, 2697, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cuarto</label>\r\n");
#nullable restore
#line 93 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
             if (Model.LlantaTd == 4)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 2821, "\"", 2844, 1);
#nullable restore
#line 96 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
WriteAttributeValue("", 2829, Model.LlantaTd, 2829, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Lisa</label>\r\n");
#nullable restore
#line 97 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 100 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 103 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
       Write(Html.DisplayFor(model => model.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 106 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdCarroNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 109 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdCarroNavigation.IdCarros));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 112 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdEstadoNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 115 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdEstadoNavigation.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d056b51c8acede628ec6f1926e7ba45b6043aea521844", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 120 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbCondiciones\Details.cshtml"
                           WriteLiteral(Model.IdCondiciones);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d056b51c8acede628ec6f1926e7ba45b6043aea524013", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Riviera_Business.Models.TbCondiciones> Html { get; private set; }
    }
}
#pragma warning restore 1591