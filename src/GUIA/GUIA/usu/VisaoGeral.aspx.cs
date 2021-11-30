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
    public partial class VisaoGeral : System.Web.UI.Page
    {
        BLL_Despesa despbll = new BLL_Despesa();
        DTO_Cliente clientelogado = new DTO_Cliente();
        BLL_Receita receitabll = new BLL_Receita();
        BLL_Diferenca diferencabll = new BLL_Diferenca();
      
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
                Response.Redirect("~/login.aspx");

            carregargrid();
        }


        public void carregargrid()
        {
            if (!IsPostBack)
            {
                clientelogado = (DTO_Cliente)Session["usuario"];

                GridView1.DataSource = despbll.somadasdespesas(clientelogado.IdCliente);
                GridView1.DataBind();

                GridView2.DataSource = receitabll.somadasreceitas(clientelogado.IdCliente);
                GridView2.DataBind();

                GridView3.DataSource = diferencabll.somadasdiferencas(clientelogado.IdCliente);
                GridView3.DataBind();

            }

        }



    }
}