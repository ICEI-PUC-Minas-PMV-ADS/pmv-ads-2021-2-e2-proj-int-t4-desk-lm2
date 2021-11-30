using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BLL;
using MySql.Data.MySqlClient;

namespace GUIA.usu
{
    public partial class Relatorio : System.Web.UI.Page
    {
        DTO_Cliente clientelogado;

        BLL_Despesa despbll = new BLL_Despesa();
        BLL_Receita receitabll = new BLL_Receita();
        BLL_Diferenca diferencabll = new BLL_Diferenca();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["usuario"] == null)
                Response.Redirect("~/login.aspx");

            CarregarGrid();

        }


        public void CarregarGrid()
        {
            if (!IsPostBack)
            {
                clientelogado = (DTO_Cliente)Session["usuario"];

                GridView1.DataSource = despbll.contadespesa(clientelogado.IdCliente);
                GridView1.DataBind();

                GridView2.DataSource = receitabll.contareceita(clientelogado.IdCliente);
                GridView2.DataBind();

                GridView3.DataSource = diferencabll.contadiferenca(clientelogado.IdCliente);
                GridView3.DataBind();

            }

        }
    }
}