#pragma checksum "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dac7113fbfc8cc33a81585d0d745505520129f4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CuentasPendientesCP_Index), @"mvc.1.0.view", @"/Views/CuentasPendientesCP/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dac7113fbfc8cc33a81585d0d745505520129f4f", @"/Views/CuentasPendientesCP/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba7bc4482e732b495e27471032f90489653d037d", @"/Views/_ViewImports.cshtml")]
    public class Views_CuentasPendientesCP_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Riviera_Business.Models.CuentasPendientesCP>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CuentasPagar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CuentasCobrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""text-center"">Cuentas en general</h1>

<style>
    .CuentasPP {
        background-color: orangered;
    }

    .CuentasPC {
        background-color: forestgreen;
    }

    .OtrasC {
        background-color: cornflowerblue;
    }
</style>

<p>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dac7113fbfc8cc33a81585d0d745505520129f4f6681", async() => {
                WriteLiteral("Llenar cuentas por pagar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dac7113fbfc8cc33a81585d0d745505520129f4f7941", async() => {
                WriteLiteral("Llenar cuentas por cobrar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dac7113fbfc8cc33a81585d0d745505520129f4f9202", async() => {
                WriteLiteral("Llenar otras cuentas");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<table border=""0"" cellspacing=""5"" cellpadding=""5"" class=""w-100"">
    <tbody class=""bg-secondary"">
        <tr>
            <td>Fecha Inicial:</td>
            <td><input type=""text"" id=""min"" name=""min"" class=""form-control""></td>
        </tr>
        <tr>
            <td>Fecha Final:</td>
            <td><input type=""text"" id=""max"" name=""max"" class=""form-control""></td>
        </tr>
    </tbody>
</table>
<table class=""table"" id=""dataTable1"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 44 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CuentasCobrarPagarOtras));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Folio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 53 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdProveedor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 56 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 59 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Anticipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 62 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Importe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 65 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Detalle));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </th>
            <th>
                Numero de Serie
            </th>
            <th>
                Version
            </th>
            <th>
                Modelo
            </th>
            <th>
                Marca
            </th>
            <th>
                Concepto
            </th>
            <th>
                ");
#nullable restore
#line 83 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdEstadoNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 89 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n");
#nullable restore
#line 93 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
                     if (item.CuentasCobrarPagarOtras == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label");
            BeginWriteAttribute("value", " value=\"", 2642, "\"", 2679, 1);
#nullable restore
#line 95 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
WriteAttributeValue("", 2650, item.CuentasCobrarPagarOtras, 2650, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 2680, "\"", 2688, 0);
            EndWriteAttribute();
            WriteLiteral(">Cuenta por Cobrar</label>\r\n");
#nullable restore
#line 96 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
                     if (item.CuentasCobrarPagarOtras == 2)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label");
            BeginWriteAttribute("value", " value=\"", 2854, "\"", 2891, 1);
#nullable restore
#line 99 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
WriteAttributeValue("", 2862, item.CuentasCobrarPagarOtras, 2862, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 2892, "\"", 2900, 0);
            EndWriteAttribute();
            WriteLiteral(">Cuenta por Pagar</label>\r\n");
#nullable restore
#line 100 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
                     if (item.CuentasCobrarPagarOtras == 3)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label");
            BeginWriteAttribute("value", " value=\"", 3065, "\"", 3102, 1);
#nullable restore
#line 103 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
WriteAttributeValue("", 3073, item.CuentasCobrarPagarOtras, 3073, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 3103, "\"", 3111, 0);
            EndWriteAttribute();
            WriteLiteral(">Otras Cuentas </label>\r\n");
#nullable restore
#line 104 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 106 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CuentasCobrarPagarOtras));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 109 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Folio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 112 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 115 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IdProveedor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 118 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IdCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 121 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Anticipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 124 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Importe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 127 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Detalle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 130 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IdCarroNavigation.NoSerie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 133 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IdCarroNavigation.IdVersionNavigation.VersionCarro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 136 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation.ModeloCarro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 139 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation.IdMarcaNavigation.NombreMarca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 142 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IdConceptoNavigation.DescripcionConcepto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 145 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IdEstadoNavigation.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dac7113fbfc8cc33a81585d0d745505520129f4f23151", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 148 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
                                           WriteLiteral(item.IdCuentaPendiente);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dac7113fbfc8cc33a81585d0d745505520129f4f25440", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 149 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
                                              WriteLiteral(item.IdCuentaPendiente);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dac7113fbfc8cc33a81585d0d745505520129f4f27735", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 150 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
                                             WriteLiteral(item.IdCuentaPendiente);

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
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 153 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\CuentasPendientesCP\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>


<script>

    $.fn.dataTable.ext.search.push(
        function (settings, data, dataIndex) {
            var min = $(""#min"").val();
            min = min.split(""/"");
            min = new Date(min[2], min[1], min[0]);

            var max = $(""#max"").val();
            max = max.split(""/"");
            max = new Date(max[2], max[1], max[0]);

            var age = data[2].split("" "")[0];
            age = age.split(""/"");
            age = new Date(age[2], age[1], age[0]);

            if ((isNaN(min.getTime()) && isNaN(max.getTime())) ||
                (isNaN(min.getTime()) && age.getTime() <= max.getTime()) ||
                (min.getTime() <= age.getTime() && isNaN(max.getTime())) ||
                (min.getTime() <= age.getTime() && age.getTime() <= max.getTime())) {
                return true;
            }
            return false;
        }
    );


    $(document).ready(function () {
        var table = $(""#dataTable1"").DataTable({
            s");
            WriteLiteral("crollX: \"true\"\r\n        });\r\n        $(\'#min, #max\').keyup(function () {\r\n            table.draw();\r\n        });\r\n    });\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Riviera_Business.Models.CuentasPendientesCP>> Html { get; private set; }
    }
}
#pragma warning restore 1591
