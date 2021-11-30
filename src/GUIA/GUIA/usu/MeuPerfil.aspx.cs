using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using DTO;
using BLL;

namespace GUIA.usu
{
    public partial class MeuPerfil : System.Web.UI.Page
    {

        BLL_Cliente clibll = new BLL_Cliente();
        DTO_Cliente clidto = new DTO_Cliente();
        DTO_Cliente clientelogado = new DTO_Cliente();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
                Response.Redirect("~/login.aspx");
        }

        public void CarregarSession()
        {
            if (Session["usuario"] == null)
                Response.Redirect("~/login.aspx");
        }

        protected void BtnCarregar_Click(object sender, EventArgs e)
        {
            clientelogado = (DTO_Cliente)Session["usuario"];
            txtnome.Text = clientelogado.Nome;
            txtemail.Text = clientelogado.Email;
            txtsenha.Text = clientelogado.Senha;
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                clientelogado = (DTO_Cliente)Session["usuario"];
                clidto.IdCliente = clientelogado.IdCliente;
                clidto.Nome = txtnome.Text;
                clidto.Email = txtemail.Text;
                clidto.Senha = txtsenha.Text;
                
                clibll.AtualizarConta(clidto);
                Response.Write("<script>alert('Dados Alterados');</script>");
                Response.Redirect("~/login.aspx",false);
                
                
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Erro');</script>");
                Response.Redirect("MeuPerfil.aspx",false);
            }
        }
    }
}