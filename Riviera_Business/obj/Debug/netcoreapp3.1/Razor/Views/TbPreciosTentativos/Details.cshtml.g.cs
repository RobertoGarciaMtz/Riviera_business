#pragma checksum "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPreciosTentativos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11741abe4e0dfc6e9f5d5c4603387532cf3171ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TbPreciosTentativos_Details), @"mvc.1.0.view", @"/Views/TbPreciosTentativos/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11741abe4e0dfc6e9f5d5c4603387532cf3171ef", @"/Views/TbPreciosTentativos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba7bc4482e732b495e27471032f90489653d037d", @"/Views/_ViewImports.cshtml")]
    public class Views_TbPreciosTentativos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Riviera_Business.Models.TbPreciosTentativos>
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
#line 3 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPreciosTentativos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalles</h1>\r\n\r\n<div>\r\n    <h4>Precios Tentativos</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPreciosTentativos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoVenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 17 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPreciosTentativos\Details.cshtml"
             if (Model.TipoVenta == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 411, "\"", 435, 1);
#nullable restore
#line 19 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPreciosTentativos\Details.cshtml"
WriteAttributeValue("", 419, Model.TipoVenta, 419, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Precio Retail</label>\r\n");
#nullable restore
#line 20 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPreciosTentativos\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPreciosTentativos\Details.cshtml"
             if (Model.TipoVenta == 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 552, "\"", 576, 1);
#nullable restore
#line 23 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPreciosTentativos\Details.cshtml"
WriteAttributeValue("", 560, Model.TipoVenta, 560, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Precio Interagencias</label>\r\n");
#nullable restore
#line 24 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPreciosTentativos\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPreciosTentativos\Details.cshtml"
             if (Model.TipoVenta == 3)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label");
            BeginWriteAttribute("value", " value=\"", 700, "\"", 724, 1);
#nullable restore
#line 27 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPreciosTentativos\Details.cshtml"
WriteAttributeValue("", 708, Model.TipoVenta, 708, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Precio Expo</label>\r\n");
#nullable restore
#line 28 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPreciosTentativos\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPreciosTentativos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cantidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPreciosTentativos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cantidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPreciosTentativos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ub));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPreciosTentativos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ub));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPreciosTentativos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Porcentaje));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPreciosTentativos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Porcentaje));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 49 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPreciosTentativos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EstadoNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 52 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPreciosTentativos\Details.cshtml"
       Write(Html.DisplayFor(model => model.EstadoNavigation.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 55 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPreciosTentativos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdCarroNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 58 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPreciosTentativos\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdCarroNavigation.NoSerie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11741abe4e0dfc6e9f5d5c4603387532cf3171ef10790", async() => {
                WriteLiteral("Editar");
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
#line 63 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\TbPreciosTentativos\Details.cshtml"
                           WriteLiteral(Model.IdPreciosTentativos);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11741abe4e0dfc6e9f5d5c4603387532cf3171ef12972", async() => {
                WriteLiteral("Lista de Automoviles");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Riviera_Business.Models.TbPreciosTentativos> Html { get; private set; }
    }
}
#pragma warning restore 1591
