using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace DTO
{
    public class DTO_Diferenca
    {
        private int iddiferenca, valordiferenca, iduso;
        private string tipodiferenca, datavencimentodiferenca;

        public int Iddiferenca { get => iddiferenca; set => iddiferenca = value; }
        public int Valordiferenca { get => valordiferenca; set => valordiferenca = value; }
        public int Iduso { get => iduso; set => iduso = value; }
        public string Tipodiferenca { get => tipodiferenca; set => tipodiferenca = value; }
        public string Datavencimentodiferenca { get => datavencimentodiferenca; set => datavencimentodiferenca = value; }
    }
}