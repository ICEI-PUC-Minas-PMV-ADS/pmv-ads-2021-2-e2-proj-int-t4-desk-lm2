using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BLL;

namespace GUIA.usu
{
    public partial class AddJaDiferenca : System.Web.UI.Page
    {
        BLL_Diferenca diferencabll = new BLL_Diferenca();
        DTO_Diferenca diferencadto = new DTO_Diferenca();
        DTO_Cliente clientelogado;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
                Response.Redirect("~/login.aspx");

            clientelogado = (DTO_Cliente)Session["usuario"];
            if (!IsPostBack)
            {
                Grid.DataSource = diferencabll.ListarDiferencas(clientelogado.IdCliente);
                Grid.DataBind();
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            try
            {
                diferencabll.ExcluirDiferencas(clientelogado.IdCliente);
                Response.Redirect("VisaoGeral.aspx");
            }
            catch (Exception)
            {
                Response.Write("<script> alert('Erro no sistema');</script>");

            }
        }
    }
}