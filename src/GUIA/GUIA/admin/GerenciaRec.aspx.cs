using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BLL;

namespace GUIA.admin
{
    public partial class GerenciaRec : System.Web.UI.Page
    {
        DTO_Cliente cliente;
        DTO_Receita receitadto = new DTO_Receita();
        BLL_Receita receitabll = new BLL_Receita();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
                Response.Redirect("~/login.aspx");
        }

        protected void btnAddReceita_Click(object sender, EventArgs e)
        {
            try
            {
                cliente = (DTO_Cliente)Session["usuario"];

                receitadto.Tiporeceita = txttiporeceita.Text;

                receitadto.Valorreceita = int.Parse(txtvalorreceita.Text);

                receitadto.Iduso = cliente.IdCliente;

                receitabll.InserirNovaReceita(receitadto);
                Response.Redirect("ControleReceitas.aspx");
            }
            catch (Exception)
            {
                Response.Write("<script> alert('Erro no sistema');</script>");
            }
        }
    }
}