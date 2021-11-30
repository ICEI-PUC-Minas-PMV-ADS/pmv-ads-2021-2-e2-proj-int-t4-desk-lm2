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
    public partial class ControleReceitas : System.Web.UI.Page
    {

        DTO_Cliente clientelogado;
        BLL_Cliente clienteBLL = new BLL_Cliente();
        DTO_Cliente clienteDTO = new DTO_Cliente();
        BLL_Receita receitabll = new BLL_Receita();
        DTO_Receita receitadto = new DTO_Receita();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
                Response.Redirect("~/login.aspx");

            clientelogado = (DTO_Cliente)Session["usuario"];

            if (!IsPostBack)
            {
                GridViewReceitas.DataSource = receitabll.ListarTodasReceita();
                GridViewReceitas.DataBind();
            }
        }

        protected void GridViewReceitas_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                receitadto.Idreceita = int.Parse(e.NewValues[0].ToString());
                receitadto.Tiporeceita = e.NewValues[1].ToString();
                receitadto.Valorreceita = int.Parse(e.NewValues[2].ToString());
                receitadto.Iduso = int.Parse(e.NewValues[3].ToString());

                receitabll.AtualizarReceita(receitadto);
                GridViewReceitas.EditIndex = -1;
                GridViewReceitas.DataSource = receitabll.ListarTodasReceita();
                GridViewReceitas.DataBind();

            }
            catch (Exception)
            {

                Response.Redirect("~/erro.html");
            }
        }

        protected void GridViewReceitas_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                GridViewReceitas.EditIndex = e.NewEditIndex;
                GridViewReceitas.DataSource = receitabll.ListarTodasReceita();
                GridViewReceitas.DataBind();
            }
            catch (Exception)
            {
                Response.Redirect("~/erro.html");
            }
        }

        protected void GridViewReceitas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                receitadto.Idreceita = int.Parse(GridViewReceitas.Rows[e.RowIndex].Cells[2].Text);
                receitabll.ExcluirReceitaExpecifica(receitadto);
                GridViewReceitas.EditIndex = -1;
                GridViewReceitas.DataSource = receitabll.ListarTodasReceita();
                GridViewReceitas.DataBind();
            }
            catch (Exception)
            {
                Response.Redirect("~/erro.html");
            }
        }

        protected void GridViewReceitas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            try
            {
                GridViewReceitas.EditIndex = -1;
                GridViewReceitas.DataSource = receitabll.ListarTodasReceita();
                GridViewReceitas.DataBind();
            }
            catch (Exception)
            {
                Response.Redirect("~/erro.html");
            }
        }
    }
}