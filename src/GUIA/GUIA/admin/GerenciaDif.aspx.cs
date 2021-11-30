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
    public partial class GerenciaDif : System.Web.UI.Page
    {
        DTO_Cliente cliente;
        DTO_Diferenca diferencadto = new DTO_Diferenca();
        BLL_Diferenca diferencabll = new BLL_Diferenca();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
                Response.Redirect("~/login.aspx");
        }

        protected void btnAddDiferenca_Click(object sender, EventArgs e)
        {
            try
            {
                cliente = (DTO_Cliente)Session["usuario"];

                diferencadto.Valordiferenca = int.Parse(txtvalor.Text);

                diferencadto.Tipodiferenca = txttipodiferenca.Text;

                diferencadto.Datavencimentodiferenca = txtDataVencimento.Text;

                diferencadto.Iduso = cliente.IdCliente;

                diferencabll.InserirNovaDiferenca(diferencadto);
                Response.Redirect("ControleDiferencas.aspx");
            }
            catch (Exception)
            {
                Response.Write("<script> alert('Erro no sistema');</script>");

            }
        }
    }
}