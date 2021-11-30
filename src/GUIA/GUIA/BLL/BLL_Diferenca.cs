using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Diferenca
    {
        Conexao bd = new Conexao();

        public void InserirNovaDiferenca(DTO_Diferenca diferenca)
        {
            try
            {
                string comando = "INSERT INTO diferenca VALUES (NULL, '" + diferenca.Valordiferenca + "','"
                                                                           + diferenca.Tipodiferenca + "','"
                                                                            + diferenca.Datavencimentodiferenca + "','"
                                                                              + diferenca.Iduso + "');";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable somadasdiferencas(int id)
        {
            try
            {
                string comando = "SELECT SUM(valordiferenca) AS TOTAL FROM diferenca WHERE iduso= " + id + ";";

                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarDiferencas(int id_usuario)
        {
            try
            {
                string comando = "SELECT valordiferenca,tipodiferenca,datavencimentodiferenca from diferenca where iduso = " + id_usuario + ";";
                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirDiferencas(int iduso)
        {
            try
            {
                string comando = "DELETE FROM diferenca WHERE iduso = '" + iduso + "';";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AtualizarDiferenca(DTO_Diferenca diferenca)
        {
            try
            {
                string comando = "UPDATE diferenca set valordiferenca = '" + diferenca.Valordiferenca +
                                                     "', tipodiferenca =  '" + diferenca.Tipodiferenca +
                                                     "', datavencimentodiferenca =  '" + diferenca.Datavencimentodiferenca +
                                                     "', iduso =  '" + diferenca.Iduso +
                                                     "' WHERE iddiferenca = '" + diferenca.Iddiferenca + "';";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ExcluirDiferencaExpecifica(DTO_Diferenca diferenca)
        {
            try
            {
                string comando = "DELETE FROM diferenca WHERE iddiferenca  = '" + diferenca.Iddiferenca + "';";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable contadiferenca(int id)
        {
            try
            {
                string comando = "SELECT COUNT(valordiferenca) AS TOTAL FROM diferenca WHERE iduso= " + id + ";";

                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarTodasDiferencas()
        {
            try
            {
                string comando = "SELECT * FROM diferenca;";
                return bd.ExecutarConsulta(comando);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}