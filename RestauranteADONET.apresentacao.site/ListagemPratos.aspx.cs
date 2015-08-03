using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestauranteADONET.Dominio.Model;
using RestauranteADONET.Dominio.Business;
namespace RestauranteADONET.apresentacao.site
{
    public partial class ListagemPratos : System.Web.UI.Page
    {
        private readonly PratoBusiness _pratoBusiness = new PratoBusiness();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblmsg.Text = string.Empty;
                lblmsg.Visible = false;

                ListarPratos();
            }
        }

        private void ListarPratos()
        {
            var livros = _pratoBusiness.Listar();

            gridPratos.DataSource = livros;
            gridPratos.DataBind();

        }

        protected void gridPratos_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }
    }
}