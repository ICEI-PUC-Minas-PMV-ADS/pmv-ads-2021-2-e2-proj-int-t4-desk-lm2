using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO
{
    public class DTO_Relatorio
    {
        private string tipoRelatorio,dadosRelatorioQuant,dadosRelatorioQuali;

        public string TipoRelatorio { get => tipoRelatorio; set => tipoRelatorio = value; }
        public string DadosRelatorioQuant { get => dadosRelatorioQuant; set => dadosRelatorioQuant = value; }
        public string DadosRelatorioQuali { get => dadosRelatorioQuali; set => dadosRelatorioQuali = value; }
    }
}