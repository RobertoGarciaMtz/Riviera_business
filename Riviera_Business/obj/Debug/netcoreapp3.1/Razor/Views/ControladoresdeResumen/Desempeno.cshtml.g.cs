#pragma checksum "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\ControladoresdeResumen\Desempeno.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a378e2674ef776fc64271518343737dcb49ac37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ControladoresdeResumen_Desempeno), @"mvc.1.0.view", @"/Views/ControladoresdeResumen/Desempeno.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a378e2674ef776fc64271518343737dcb49ac37", @"/Views/ControladoresdeResumen/Desempeno.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba7bc4482e732b495e27471032f90489653d037d", @"/Views/_ViewImports.cshtml")]
    public class Views_ControladoresdeResumen_Desempeno : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\ControladoresdeResumen\Desempeno.cshtml"
  
    ViewData["Title"] = "Desempeno";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Desempeño</h1>
<hr />
<div class=""content"">

    <div class=""row"">

        <div class=""col-md-1""></div>
        <div class=""col-md-1"">
            <label for=""id_ase"">Asesor: </label>
        </div>
        <div class=""col-md-4"">
            <select id=""id_ase"" class=""form-control"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a378e2674ef776fc64271518343737dcb49ac374083", async() => {
                WriteLiteral("Seleccionar Asesor");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\ControladoresdeResumen\Desempeno.cshtml"
                 foreach (var ase in ViewBag.asesores)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a378e2674ef776fc64271518343737dcb49ac375566", async() => {
#nullable restore
#line 21 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\ControladoresdeResumen\Desempeno.cshtml"
                                               Write(ase.Nombre);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\ControladoresdeResumen\Desempeno.cshtml"
                       WriteLiteral(ase.IdAsesores);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\ControladoresdeResumen\Desempeno.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
        </div>
        <div class=""col-md-1"">
            <button class=""btn btn-lg btn-success"" id=""btnSearch"">Buscar</button>
        </div>
    </div>
    <div class=""row bg-white"">
        <div class=""col-md-11"">
            <div class=""box-header with-border"">
                <h3 class=""box-title"">Criterios</h3>
            </div>
            <!-- /.box-header -->
            <div class=""box-body"">
                <table class=""table table-bordered"">
                    <tbody>
                        <tr>
                            <th>Descripción</th>
                            <th>Cantidad</th>
                        </tr>
                        <tr>
                            <td>Cantidad de seguimientos realizados</td>
                            <td id=""infoSeg""></td>
                        </tr>
                        <tr>
                            <td>Número de pruebas de manejo</td>
                            <td id=""numP""></td>
         ");
            WriteLiteral(@"               </tr>
                        <tr>
                            <td>Número de citas</td>
                            <td id=""numC""></td>
                        </tr>
                        <tr>
                            <td>Número de anticipos</td>
                            <td id=""numA""></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>

</div>


");
#nullable restore
#line 67 "C:\Users\01\source\repos\Riviera_Business\Riviera_Business\Views\ControladoresdeResumen\Desempeno.cshtml"
Write(ViewBag.tventa);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script>

    $(document).ready(function () {
        $(""#btnSearch"").on(""click"", function () {

            var data = document.getElementById(""id_ase"").value;
            //var v = document.getElementById(""infoSeg"");
            //var x = document.getElementById(""numP"");
            //var y = document.getElementById(""numC"");
            //var z = document.getElementById(""numA"");

            $.ajax({
                url: '/ControladoresdeResumen/Search',
                method: ""POST"",
                data: { id: data },
                success: function (e) {
                    $(""#infoSeg"").html( e[0] );
                    $(""#numP"").html(e[1]);
                    $(""#numC"").html(e[2]);
                    $(""#numA"").html(e[3]);
                }
            });

        });
    });

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
