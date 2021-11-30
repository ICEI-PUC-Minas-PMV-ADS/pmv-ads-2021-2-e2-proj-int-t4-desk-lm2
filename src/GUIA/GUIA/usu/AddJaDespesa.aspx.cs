using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DTO;

namespace GUIA.usu
{
    public partial class AddJaDespesa : System.Web.UI.Page
    {
        BLL_Despesa despBLL = new BLL_Despesa();
        DTO_Despesa despDTO = new DTO_Despesa();
        DTO_Cliente clientelogado;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
                Response.Redirect("~/login.aspx");

            clientelogado = (DTO_Cliente)Session["usuario"];
            if (!IsPostBack)
            {
                Grid.DataSource = despBLL.ListarDespesa(clientelogado.IdCliente);
                Grid.DataBind();
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            try
            {
                despBLL.ExcluirDespesa(clientelogado.IdCliente);
                Response.Redirect("VisaoGeral.aspx");
            }
            catch (Exception)
            {
                Response.Write("<script> alert('Erro no sistema');</script>");

            }
        }
    }
}