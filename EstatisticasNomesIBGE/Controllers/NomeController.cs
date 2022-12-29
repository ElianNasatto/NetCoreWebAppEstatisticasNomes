using EstatisticasNomesIBGE.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Rotativa.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace EstatisticasNomesIBGE.Controllers
{
    public class NomeController : Controller
    {

        public string BuscaDadosIBGE(string nome)
        {
            if (string.IsNullOrEmpty(nome))
                View("Index");

            WebClient client = new WebClient();
            return client.DownloadString("https://servicodados.ibge.gov.br/api/v2/censos/nomes/" + nome);
          
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Pesquisar(string nome)
        {
           
            return View(BuscaDadosIBGE(nome));

        }

        public IActionResult PesquisarGrafico(string nome)
        {
            string json = BuscaDadosIBGE(nome);
            if (string.IsNullOrEmpty(json) || json.Equals("[]"))
            {
                ViewBag.Mensagem = "Não foi encontrando dados na base do IBGE";
                return View("Index");
            }

         
            return View(JsonConvert.DeserializeObject<List<Dados>>(json).FirstOrDefault());

        }

        public IActionResult DownloadGraficoPDF(string nome)
        {

            string json = BuscaDadosIBGE(nome);
            if (string.IsNullOrEmpty(json) || json.Equals("[]"))
            {
                ViewBag.Mensagem = "Não foi encontrando dados na base do IBGE";
                return View("Index");
            }


            var relatorio = new ViewAsPdf("PesquisarGrafico", JsonConvert.DeserializeObject<List<Dados>>(json).FirstOrDefault())
            {
                FileName="Teste",
                PageOrientation = Rotativa.AspNetCore.Options.Orientation.Landscape,
                PageSize = Rotativa.AspNetCore.Options.Size.A4,
                PageMargins = { Left = 05, Right = 05 },
                Model = JsonConvert.DeserializeObject<List<Dados>>(json).FirstOrDefault()
            };
            relatorio.WkhtmlPath = @"C:\Users\Elian\source\repos\NetCoreWebAppEstatisticasNomes\EstatisticasNomesIBGE\wwwroot\Rotativa\wkhtmltopdf.exe";

            return relatorio;
            //return relatorio;

        }
    }
}
