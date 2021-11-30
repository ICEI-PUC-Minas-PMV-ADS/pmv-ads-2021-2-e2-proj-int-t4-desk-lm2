using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO
{
    public class DTO_Grafico
    {
        private string tipoGrafico, graficoQuant;

        public string TipoGrafico { get => tipoGrafico; set => tipoGrafico = value; }
        public string GraficoQuant { get => graficoQuant; set => graficoQuant = value; }
    }
}