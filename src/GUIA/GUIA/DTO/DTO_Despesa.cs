using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO
{
    public class DTO_Despesa
    {
        private int id_uso,iddespesa;
        private int valordespesa;
        private string tipodespesa,descricao;
        private string datadencimentodespesa;

        public int Id_uso { get => id_uso; set => id_uso = value; }
        public int Iddespesa { get => iddespesa; set => iddespesa = value; }
        public int Valordespesa { get => valordespesa; set => valordespesa = value; }
        public string Tipodespesa { get => tipodespesa; set => tipodespesa = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Datadencimentodespesa { get => datadencimentodespesa; set => datadencimentodespesa = value; }
    }
}