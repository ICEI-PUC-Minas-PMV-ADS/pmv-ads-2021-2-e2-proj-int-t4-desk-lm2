using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO
{
    public class DTO_Geral1
    {
        private int idGeral1Invest, idGeral1Desp, idGeral1Rece, idGeral1Sistema;

        public int IdGeral1Invest { get => idGeral1Invest; set => idGeral1Invest = value; }
        public int IdGeral1Desp { get => idGeral1Desp; set => idGeral1Desp = value; }
        public int IdGeral1Rece { get => idGeral1Rece; set => idGeral1Rece = value; }
        public int IdGeral1Sistema { get => idGeral1Sistema; set => idGeral1Sistema = value; }
    }
}