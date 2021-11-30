using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BLL;


namespace GUIA
{
    public partial class Cadastro : System.Web.UI.Page
    {
        BLL_Cliente clibll = new BLL_Cliente();
        DTO_Cliente clidto = new DTO_Cliente();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                clidto.Nome = cad_nome.Text;
                clidto.Email = cad_email.Text;
                clidto.Senha = cad_senha.Text;
                clidto.Tipo = 0;

                if (clibll.validarEmail(clidto.Email))
                {
                    clibll.RegistrarCliente(clidto);
                    Response.Redirect("login.aspx", false);
                }
                else
                {
                    Response.Write("<script> alert('E-mail já cadastrado, escolha outro');</script>");
                }
            }
            catch(Exception)
            {
                //Response.Redirect("erro.aspx", false);
            }
        }
    }
}