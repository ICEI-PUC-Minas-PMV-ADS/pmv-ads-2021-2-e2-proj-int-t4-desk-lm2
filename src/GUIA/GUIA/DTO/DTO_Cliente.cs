using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO
{
    public class DTO_Cliente
    {
        private int idCliente,tipo;
        private string nome,email,senha;

        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int Tipo { get => tipo; set => tipo = value; }
    }
}