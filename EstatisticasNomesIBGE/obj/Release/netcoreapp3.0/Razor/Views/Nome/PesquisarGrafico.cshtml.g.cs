#pragma checksum "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\Nome\PesquisarGrafico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0771a163148af5104abb9e9019ba86e1fac621e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nome_PesquisarGrafico), @"mvc.1.0.view", @"/Views/Nome/PesquisarGrafico.cshtml")]
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
#line 1 "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\_ViewImports.cshtml"
using EstatisticasNomesIBGE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\_ViewImports.cshtml"
using EstatisticasNomesIBGE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0771a163148af5104abb9e9019ba86e1fac621e8", @"/Views/Nome/PesquisarGrafico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64fd5e0cf45c9c496a482be19ebff83bd6f16b38", @"/Views/_ViewImports.cshtml")]
    public class Views_Nome_PesquisarGrafico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EstatisticasNomesIBGE.Models.Dados>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\Nome\PesquisarGrafico.cshtml"
  
    ViewData["Title"] = "Resultado";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h1>");
#nullable restore
#line 8 "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\Nome\PesquisarGrafico.cshtml"
   Write(Html.DisplayFor(modelItem => modelItem.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h5>");
#nullable restore
#line 9 "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\Nome\PesquisarGrafico.cshtml"
   Write(Html.DisplayFor(modelItem => modelItem.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <h5>");
#nullable restore
#line 10 "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\Nome\PesquisarGrafico.cshtml"
   Write(Html.DisplayFor(modelItem => modelItem.Localidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n</div>\r\n\r\n<br />\r\n\r\n<canvas id=\"mChart1\"></canvas>\r\n\r\n");
            WriteLiteral("<script>\r\n\r\n    var context = document.getElementById(\'mChart1\');\r\n\r\n    var chartGraphic = new Chart(context, {\r\n        type: \'line\',\r\n        data: {\r\n            labels: [\r\n");
#nullable restore
#line 26 "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\Nome\PesquisarGrafico.cshtml"
                 for (int i = 0; i < Model.Res.Count(); i++)
                {
                    if (i < Model.Res.Count())
                    {
                       

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\Nome\PesquisarGrafico.cshtml"
                  Write(Html.Raw("'" + Model.Res[i].Periodo + "',"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\Nome\PesquisarGrafico.cshtml"
                                                                   ;
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\Nome\PesquisarGrafico.cshtml"
                   Write(Html.Raw("'" + Model.Res[i].Periodo + "'").ToString());

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\Nome\PesquisarGrafico.cshtml"
                                                                              ;

                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ],\r\n            datasets: [{\r\n                    label: \'Frequencia\',\r\n                data: [\r\n");
#nullable restore
#line 42 "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\Nome\PesquisarGrafico.cshtml"
                         for (int i = 0; i < Model.Res.Count(); i++)
                        {
                            if (i < Model.Res.Count())
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\Nome\PesquisarGrafico.cshtml"
                           Write(Html.Raw("'" + Model.Res[i].Frequencia + "',"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\Nome\PesquisarGrafico.cshtml"
                                                                               ;
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\Nome\PesquisarGrafico.cshtml"
                           Write(Html.Raw("'" + Model.Res[i].Frequencia + "'"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\Nome\PesquisarGrafico.cshtml"
                                                                              ;

                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("],\r\n                borderwidth: 6,\r\n                backgourdColor: \'transparent\',\r\n                    borderColor: \'rgba(77,166,253,0.85)\'\r\n                }]\r\n        }\r\n    });\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EstatisticasNomesIBGE.Models.Dados> Html { get; private set; }
    }
}
#pragma warning restore 1591