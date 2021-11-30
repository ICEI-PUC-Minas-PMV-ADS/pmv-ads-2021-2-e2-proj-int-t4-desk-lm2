using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO
{
    public class DTO_Geral
    {
        private int idGeraRelatorios, idGraficos;

        public int IdGeraRelatorios { get => idGeraRelatorios; set => idGeraRelatorios = value; }
        public int IdGraficos { get => idGraficos; set => idGraficos = value; }
    }
}