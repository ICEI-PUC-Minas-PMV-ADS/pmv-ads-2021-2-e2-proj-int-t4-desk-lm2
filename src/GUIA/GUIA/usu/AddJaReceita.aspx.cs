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
    public partial class AddJaReceita : System.Web.UI.Page
    {
        BLL_Receita receitabll = new BLL_Receita();
        DTO_Receita receitadto = new DTO_Receita();
        DTO_Cliente clientelogado;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
                Response.Redirect("~/login.aspx");

            clientelogado = (DTO_Cliente)Session["usuario"];
            if (!IsPostBack)
            {
                Grid.DataSource = receitabll.ListarReceita(clientelogado.IdCliente);
                Grid.DataBind();
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            try
            {
                receitabll.ExcluirReceita(clientelogado.IdCliente);
                Response.Redirect("VisaoGeral.aspx");
            }
            catch (Exception)
            {
                Response.Write("<script> alert('Erro no sistema');</script>");

            }
        }
    }
}