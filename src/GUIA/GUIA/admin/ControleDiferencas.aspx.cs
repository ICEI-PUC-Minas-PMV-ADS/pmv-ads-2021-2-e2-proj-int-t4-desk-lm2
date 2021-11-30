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
    public partial class ControleDiferencas : System.Web.UI.Page
    {

        DTO_Cliente clientelogado;
        BLL_Cliente clienteBLL = new BLL_Cliente();
        DTO_Cliente clienteDTO = new DTO_Cliente();
        BLL_Diferenca diferencabll = new BLL_Diferenca();
        DTO_Diferenca diferencadto = new DTO_Diferenca();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
                Response.Redirect("~/login.aspx");

            clientelogado = (DTO_Cliente)Session["usuario"];

            if (!IsPostBack)
            {
                GridViewDiferencas.DataSource = diferencabll.ListarTodasDiferencas();
                GridViewDiferencas.DataBind();
            }
        }

        protected void GridViewDiferencas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                diferencadto.Iddiferenca = int.Parse(GridViewDiferencas.Rows[e.RowIndex].Cells[2].Text);
                diferencabll.ExcluirDiferencaExpecifica(diferencadto);
                GridViewDiferencas.EditIndex = -1;
                GridViewDiferencas.DataSource = diferencabll.ListarTodasDiferencas();
                GridViewDiferencas.DataBind();
            }
            catch (Exception)
            {
                Response.Redirect("~/erro.html");
            }
        }

        protected void GridViewDiferencas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            try
            {
                GridViewDiferencas.EditIndex = -1;
                GridViewDiferencas.DataSource = diferencabll.ListarTodasDiferencas();
                GridViewDiferencas.DataBind();
            }
            catch (Exception)
            {
                Response.Redirect("~/erro.html");
            }
        }

        protected void GridViewDiferencas_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                GridViewDiferencas.EditIndex = e.NewEditIndex;
                GridViewDiferencas.DataSource = diferencabll.ListarTodasDiferencas();
                GridViewDiferencas.DataBind();
            }
            catch (Exception)
            {
                Response.Redirect("~/erro.html");
            }
        }

        protected void GridViewDiferencas_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                diferencadto.Iddiferenca = int.Parse(e.NewValues[0].ToString());
                diferencadto.Valordiferenca = int.Parse(e.NewValues[1].ToString());
                diferencadto.Tipodiferenca = e.NewValues[2].ToString();
                diferencadto.Datavencimentodiferenca = e.NewValues[3].ToString();
                diferencadto.Iduso = int.Parse(e.NewValues[4].ToString());

                diferencabll.AtualizarDiferenca(diferencadto);
                GridViewDiferencas.EditIndex = -1;
                GridViewDiferencas.DataSource = diferencabll.ListarTodasDiferencas();
                GridViewDiferencas.DataBind();

            }
            catch (Exception)
            {

                Response.Redirect("~/erro.html");
            }
        }
    }
}