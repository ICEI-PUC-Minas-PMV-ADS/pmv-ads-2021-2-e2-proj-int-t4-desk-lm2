using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO
{
    public class DTO_Receita
    {
        private int idreceita, valorreceita, iduso;
        private string tiporeceita;

        public int Idreceita { get => idreceita; set => idreceita = value; }
        public int Valorreceita { get => valorreceita; set => valorreceita = value; }
        public int Iduso { get => iduso; set => iduso = value; }
        public string Tiporeceita { get => tiporeceita; set => tiporeceita = value; }
    }
}