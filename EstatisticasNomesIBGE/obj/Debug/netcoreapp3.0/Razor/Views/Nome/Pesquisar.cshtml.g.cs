#pragma checksum "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\Nome\Pesquisar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c548b000e2937d49027b0bf540b7f7cc4e698b0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nome_Pesquisar), @"mvc.1.0.view", @"/Views/Nome/Pesquisar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c548b000e2937d49027b0bf540b7f7cc4e698b0c", @"/Views/Nome/Pesquisar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64fd5e0cf45c9c496a482be19ebff83bd6f16b38", @"/Views/_ViewImports.cshtml")]
    public class Views_Nome_Pesquisar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EstatisticasNomesIBGE.Models.Dados>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\Nome\Pesquisar.cshtml"
  
    ViewData["Title"] = "Resultado";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\Nome\Pesquisar.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h1>");
#nullable restore
#line 11 "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\Nome\Pesquisar.cshtml"
       Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <h5>");
#nullable restore
#line 12 "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\Nome\Pesquisar.cshtml"
       Write(Html.DisplayFor(modelItem => item.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <h5>");
#nullable restore
#line 13 "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\Nome\Pesquisar.cshtml"
       Write(Html.DisplayFor(modelItem => item.Localidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    </div>\r\n");
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 21 "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\Nome\Pesquisar.cshtml"
               Write(Html.DisplayNameFor(modelItem => item.Res.FirstOrDefault().Periodo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 24 "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\Nome\Pesquisar.cshtml"
               Write(Html.DisplayNameFor(modelItem => item.Res.FirstOrDefault().Frequencia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 29 "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\Nome\Pesquisar.cshtml"
             foreach (var estatistica in item.Res)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 33 "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\Nome\Pesquisar.cshtml"
                   Write(Html.DisplayFor(modelItem => estatistica.Periodo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 36 "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\Nome\Pesquisar.cshtml"
                   Write(Html.DisplayFor(modelItem => estatistica.Frequencia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 42 "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\Nome\Pesquisar.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 45 "C:\Users\Elian\source\repos\EstatisticasNomesIBGE\EstatisticasNomesIBGE\Views\Nome\Pesquisar.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EstatisticasNomesIBGE.Models.Dados>> Html { get; private set; }
    }
}
#pragma warning restore 1591
