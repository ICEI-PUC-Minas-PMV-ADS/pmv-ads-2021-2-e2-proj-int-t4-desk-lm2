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
    public partial class Login : System.Web.UI.Page
    {
        BLL_Cliente bLL_Cliente = new BLL_Cliente();
        DTO_Cliente cliente = new DTO_Cliente();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
               cliente  = bLL_Cliente.carregarUsuario(log_email.Text,log_senha.Text);
                if (cliente != null) { 
                if (cliente.Tipo == 1)
                {
                    Session["usuario"] = cliente;
                    Response.Redirect("~/admin/GerenciaUser.aspx", false);

                }
                else if (cliente.Tipo == 0)
                {
                    Session["usuario"] = cliente;
                    Response.Redirect("~/usu/VisaoGeral.aspx", false);
                }
                else
                {
                    Response.Write("<script> alert('usuario ou senha incorretos');</script>");
                }
                }
                else
                {
                    Response.Write("<script> alert('Usuario ou Senha incorretos');</script>");
                }

            }
            catch (Exception)
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}