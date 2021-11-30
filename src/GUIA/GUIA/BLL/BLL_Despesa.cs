using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class BLL_Despesa
    {
        Conexao bd = new Conexao();

        public void InserirNovaDespesa(DTO_Despesa despesa)
        {
            try
            {
                string comando = "INSERT INTO despesa VALUES (NULL, '" + despesa.Descricao + "','"
                                                                           + despesa.Valordespesa + "','"
                                                                            + despesa.Tipodespesa + "','"
                                                                             + despesa.Datadencimentodespesa + "','"
                                                                              + despesa.Id_uso + "');";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

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

        public DataTable contadespesa(int id)
        {
            try
            {
                string comando = "SELECT COUNT(valordespesa) AS TOTAL FROM despesa WHERE iduso= " + id + ";";

                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarDespesa(int id_usuario)
        {
            try
            {
                string comando = "SELECT descricao,valordespesa,tipodespesa,datavencimentodespesa from despesa where iduso = " + id_usuario + ";";
                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarTodasDespesas()
        {
            try
            {
                string comando = "SELECT * FROM despesa;";
                return bd.ExecutarConsulta(comando);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void ExcluirDespesa(int iduso)
        {
            try
            {
                string comando = "DELETE FROM despesa WHERE iduso = '" + iduso + "';";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ExcluirDespesaExpecifica(DTO_Despesa despesa)
        {
            try
            {
                string comando = "DELETE FROM despesa WHERE iddespesa  = '" + despesa.Iddespesa + "';";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AtualizarDespesa(DTO_Despesa despesa)
        {
            try
            {
                string comando = "UPDATE despesa set descricao = '" + despesa.Descricao +
                                                     "', valordespesa =  '" + despesa.Valordespesa +
                                                     "', tipodespesa =  '" + despesa.Tipodespesa +
                                                     "', datavencimentodespesa =  '" + despesa.Datadencimentodespesa +
                                                     "', iduso =  '" + despesa.Id_uso +
                                                     "' WHERE iddespesa = '" + despesa.Iddespesa + "';";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
      
    }
}