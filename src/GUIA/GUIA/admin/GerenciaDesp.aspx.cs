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
    public partial class GerenciaDesp : System.Web.UI.Page
    {

        DTO_Cliente cliente;
        DTO_Despesa despdto = new DTO_Despesa();
        BLL_Despesa despbll = new BLL_Despesa();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
                Response.Redirect("~/login.aspx");
        }

        protected void btnAddDespesa_Click(object sender, EventArgs e)
        {
            try
            {
                cliente = (DTO_Cliente)Session["usuario"];

                despdto.Descricao = txtdescricao.Text;

                despdto.Valordespesa = int.Parse(txtvalor.Text);

                despdto.Tipodespesa = txttipodespesa.Text;

                despdto.Datadencimentodespesa = txtDataVencimento.Text;

                despdto.Id_uso = cliente.IdCliente;

                despbll.InserirNovaDespesa(despdto);
                Response.Redirect("ControleDespesas.aspx");
            }
            catch (Exception)
            {
                //Response.Write("<script> alert('Erro no sistema');</script>");

            }
        }
    }
}