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
    public partial class Lancamentos : System.Web.UI.Page
    {
        BLL_Despesa despBLL = new BLL_Despesa();
        DTO_Despesa despDTO = new DTO_Despesa();
        BLL_Receita receitabll = new BLL_Receita();
        BLL_Diferenca diferencabll = new BLL_Diferenca();
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

                Grid2.DataSource = receitabll.ListarReceita(clientelogado.IdCliente);
                Grid2.DataBind();

                Grid3.DataSource = diferencabll.ListarDiferencas(clientelogado.IdCliente);
                Grid3.DataBind();

            }
        }
    }
}