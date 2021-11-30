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
    public partial class ControleDespesas : System.Web.UI.Page
    {
        DTO_Cliente clientelogado;
        BLL_Cliente clienteBLL = new BLL_Cliente();
        DTO_Cliente clienteDTO = new DTO_Cliente();
        BLL_Despesa despesabll = new BLL_Despesa();
        DTO_Despesa despdto = new DTO_Despesa();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
                Response.Redirect("~/login.aspx");

            clientelogado = (DTO_Cliente)Session["usuario"];

            if (!IsPostBack)
            {
                GridViewDespesas.DataSource = despesabll.ListarTodasDespesas();
                GridViewDespesas.DataBind();
            }
        }

        protected void GridViewDespesas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            try
            {
                GridViewDespesas.EditIndex = -1;
                GridViewDespesas.DataSource = despesabll.ListarTodasDespesas();
                GridViewDespesas.DataBind();
            }
            catch (Exception)
            {
                Response.Redirect("~/erro.html");
            }
        }

        protected void GridViewDespesas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                despdto.Iddespesa = int.Parse(GridViewDespesas.Rows[e.RowIndex].Cells[2].Text);
                despesabll.ExcluirDespesaExpecifica(despdto);
                GridViewDespesas.EditIndex = -1;
                GridViewDespesas.DataSource = despesabll.ListarTodasDespesas();
                GridViewDespesas.DataBind();
            }
            catch (Exception)
            {
                Response.Redirect("~/erro.html");
            }
        }

        protected void GridViewDespesas_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                GridViewDespesas.EditIndex = e.NewEditIndex;
                GridViewDespesas.DataSource = despesabll.ListarTodasDespesas();
                GridViewDespesas.DataBind();
            }
            catch (Exception)
            {
                Response.Redirect("~/erro.html");
            }
        }

        protected void GridViewDespesas_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                despdto.Iddespesa = int.Parse(e.NewValues[0].ToString());
                despdto.Descricao = e.NewValues[1].ToString();
                despdto.Valordespesa = int.Parse(e.NewValues[2].ToString());
                despdto.Tipodespesa = e.NewValues[3].ToString();
                despdto.Datadencimentodespesa = e.NewValues[4].ToString();
                despdto.Id_uso = int.Parse(e.NewValues[5].ToString());

                despesabll.AtualizarDespesa(despdto);
                GridViewDespesas.EditIndex = -1;
                GridViewDespesas.DataSource = despesabll.ListarTodasDespesas();
                GridViewDespesas.DataBind();

            }
            catch (Exception)
            {

                Response.Redirect("~/erro.html");
            }
        }
    }
}