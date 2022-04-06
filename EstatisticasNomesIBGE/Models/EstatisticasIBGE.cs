using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstatisticasNomesIBGE.Models
{
    public class Dados
    {
        public string Nome { get; set; }
        public object Sexo { get; set; }
        public string Localidade { get; set; }
        public Res[] Res { get; set; }
    }

    public class Res
    {
        private string _periodo { get; set; }

        public string Periodo
        {
            get { return this._periodo; }
            set { this._periodo = value.Replace("[", ""); }
        }
        public int Frequencia { get; set; }
    }

    //public class EstatisticasIBGE
    //{
    //    public string Nome { get; set; }
    //    public object Sexo { get; set; }
    //    public string Localidade { get; set; }
    //    public List<Estatistica> Estatisticas { get; set; }
    //}

    //public class Estatistica
    //{
    //    public string Periodo { get; set; }
    //    public int Frequencia { get; set; }
    //}
}
