using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO
{
    public class DTO_Sistema
    {
        private int idClisis;
        private string nomeCliente;

        public int IdClisis { get => idClisis; set => idClisis = value; }
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
    }
}