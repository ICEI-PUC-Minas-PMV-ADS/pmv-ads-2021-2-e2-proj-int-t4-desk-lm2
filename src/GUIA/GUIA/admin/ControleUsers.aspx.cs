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
    public partial class ControleUsers : System.Web.UI.Page
    {
        BLL_Despesa despBLL = new BLL_Despesa();
        DTO_Despesa despDTO = new DTO_Despesa();
        DTO_Cliente clientelogado;
        BLL_Cliente clienteBLL = new BLL_Cliente();
        DTO_Cliente clienteDTO = new DTO_Cliente();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
                Response.Redirect("~/login.aspx");

            clientelogado = (DTO_Cliente)Session["usuario"];

            if (!IsPostBack)
            {
                GridViewUsuarios.DataSource = clienteBLL.ListarUsu();
                GridViewUsuarios.DataBind();
            }
        }



        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                clienteDTO.IdCliente = int.Parse(GridViewUsuarios.Rows[e.RowIndex].Cells[2].Text);
                clienteBLL.ExcluirUsuario(clienteDTO);
                GridViewUsuarios.EditIndex = -1;
                GridViewUsuarios.DataSource = clienteBLL.ListarUsu();
                GridViewUsuarios.DataBind();
            }
            catch (Exception)
            {
            //    throw ex;
               Response.Redirect("~/erro.html");
            }
        }

        protected void GridViewUsuarios_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                clienteDTO.IdCliente = int.Parse(e.NewValues[0].ToString());
                clienteDTO.Nome = e.NewValues[1].ToString();
                clienteDTO.Email = e.NewValues[2].ToString();
                clienteDTO.Senha = e.NewValues[3].ToString();
                clienteDTO.Tipo = int.Parse(e.NewValues[4].ToString());

                clienteBLL.AtualizarCliente(clienteDTO);
                GridViewUsuarios.EditIndex = -1;
                GridViewUsuarios.DataSource = clienteBLL.ListarUsu();
                GridViewUsuarios.DataBind();

            }
            catch (Exception)
            {

                Response.Redirect("~/erro.html");
            }
        }

        protected void GridViewUsuarios_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                GridViewUsuarios.EditIndex = e.NewEditIndex;
                GridViewUsuarios.DataSource = clienteBLL.ListarUsu();
                GridViewUsuarios.DataBind();
            }
            catch (Exception)
            {
                Response.Redirect("~/erro.html");
            }
        }

        protected void GridViewUsuarios_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            try
            {
                GridViewUsuarios.EditIndex = -1;
                GridViewUsuarios.DataSource = clienteBLL.ListarUsu();
                GridViewUsuarios.DataBind();
            }
            catch (Exception)
            {
                Response.Redirect("~/erro.html");
            }
        }
    }
}