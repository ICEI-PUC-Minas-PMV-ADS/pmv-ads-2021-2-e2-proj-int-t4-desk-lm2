using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class BLL_Grafico
    {
        Conexao bd = new Conexao();


        public DataTable somadasdespesas(int id)
        {
            try
            {
                string comando = "SELECT SUM(valordespesa) AS TOTAL FROM despesa WHERE iduso= " + id + ";";

                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}