using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Receita
    {
        Conexao bd = new Conexao();

        public void InserirNovaReceita(DTO_Receita receita)
        {
            try
            {
                string comando = "INSERT INTO receita VALUES (NULL, '" + receita.Tiporeceita + "','"
                                                                           + receita.Valorreceita + "','"
                                                                              + receita.Iduso + "');";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable somadasreceitas(int id)
        {
            try
            {
                string comando = "SELECT SUM(valorreceita) AS TOTAL FROM receita WHERE iduso= " + id + ";";

                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarReceita(int id_usuario)
        {
            try
            {
                string comando = "SELECT tiporeceita,valorreceita from receita where iduso = " + id_usuario + ";";
                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable contareceita(int id)
        {
            try
            {
                string comando = "SELECT COUNT(valorreceita) AS TOTAL FROM receita WHERE iduso= " + id + ";";

                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ExcluirReceita(int iduso)
        {
            try
            {
                string comando = "DELETE FROM receita WHERE iduso = '" + iduso + "';";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AtualizarReceita(DTO_Receita receita)
        {
            try
            {
                string comando = "UPDATE receita set tiporeceita = '" + receita.Tiporeceita +
                                                     "', valorreceita =  '" + receita.Valorreceita +
                                                     "', iduso =  '" + receita.Iduso +
                                                     "' WHERE idreceita = '" + receita.Idreceita + "';";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ExcluirReceitaExpecifica(DTO_Receita receita)
        {
            try
            {
                string comando = "DELETE FROM receita WHERE idreceita  = '" + receita.Idreceita + "';";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ListarTodasReceita()
        {
            try
            {
                string comando = "SELECT * FROM receita;";
                return bd.ExecutarConsulta(comando);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}