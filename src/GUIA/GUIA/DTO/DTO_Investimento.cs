using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO
{
    public class DTO_Investimento
    {
        private string tipoInvestimento, descricaoInvestimento,valorInvestimento;

        public string TipoInvestimento { get => tipoInvestimento; set => tipoInvestimento = value; }
        public string DescricaoInvestimento { get => descricaoInvestimento; set => descricaoInvestimento = value; }
        public string ValorInvestimento { get => valorInvestimento; set => valorInvestimento = value; }
    }
}