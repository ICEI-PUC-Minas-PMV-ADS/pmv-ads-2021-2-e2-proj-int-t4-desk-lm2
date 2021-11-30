using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO
{
    public class DTO_Adiciona
    {
        private int idAdInvest,idAdDesp, idAdRece, idAdSistema;

        public int IdAdInvest { get => idAdInvest; set => idAdInvest = value; }
        public int IdAdDesp { get => idAdDesp; set => idAdDesp = value; }
        public int IdAdRece { get => idAdRece; set => idAdRece = value; }
        public int IdAdSistema { get => idAdSistema; set => idAdSistema = value; }
    }
}