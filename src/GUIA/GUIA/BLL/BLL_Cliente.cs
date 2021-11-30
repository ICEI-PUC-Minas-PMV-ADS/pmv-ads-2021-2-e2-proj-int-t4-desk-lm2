using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class BLL_Cliente
    {
        Conexao bd = new Conexao();


        public void RegistrarCliente(DTO_Cliente cliente)
        {
            try
            {
                string inserir = "INSERT INTO cliente VALUES (NULL, '" + cliente.Nome + "','"
                                                                           + cliente.Email + "','"
                                                                           + cliente.Senha + "','"
                                                                           + cliente.Tipo + "');";
                bd.ExecutarComandos(inserir);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool validarEmail(string email)
        {
            try
            {
                string comando = "SELECT email FROM cliente where email = '" + email + "';";
                if (bd.ExecutarConsulta(comando).Rows.Count == 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AtualizarConta(DTO_Cliente clidto)
        {
            try
            {
                string comando = "UPDATE cliente set nome = '" + clidto.Nome +
                                                     "', email =  '" + clidto.Email +
                                                     "', senha =  '" + clidto.Senha +
                                                     "' WHERE idCliente = '" + clidto.IdCliente + "';";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DTO_Cliente carregarUsuario(string email, string senha)
        {
            try
            {
                string comando = "SELECT * FROM cliente where email = '" + email + "' and senha = '" + senha + "';";
                DataTable dt = bd.ExecutarConsulta(comando);
                if (dt.Rows.Count == 1)
                {
                    DTO_Cliente clidto = new DTO_Cliente();

                    clidto.IdCliente = int.Parse(dt.Rows[0][0].ToString());
                    clidto.Nome = dt.Rows[0][1].ToString();
                    clidto.Email = dt.Rows[0][2].ToString();
                    clidto.Senha = dt.Rows[0][3].ToString();

                    if (clidto.Tipo == 1)
                        clidto.Tipo = int.Parse(dt.Rows[0][4].ToString());

                    else if (clidto.Tipo == 0)
                        clidto.Tipo = int.Parse(dt.Rows[0][4].ToString());

                    return clidto;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable ListarUsu()
        {
            try
            {
                string comando = "SELECT * FROM cliente;";
                return bd.ExecutarConsulta(comando);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ExcluirUsuario(DTO_Cliente cliente)
        {
            try
            {
                string comando = "DELETE FROM cliente WHERE idCliente  = '" + cliente.IdCliente + "';";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AtualizarCliente(DTO_Cliente cliente)
        {
            try
            {
                string comando = "UPDATE cliente set nome = '" + cliente.Nome +
                                                     "', email =  '" + cliente.Email +
                                                     "', senha =  '" + cliente.Senha +
                                                      "', Tipo =  '" + cliente.Tipo +
                                                     "' WHERE idCliente = '" + cliente.IdCliente + "';";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}