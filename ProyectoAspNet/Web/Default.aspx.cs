using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
namespace Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected AutoNegocio negocio;
        protected void Page_Load(object sender, EventArgs e)
        {
             this.negocio = new AutoNegocio();
             this.ActualizarLista();
        }

        private void ActualizarLista()
        {
            this.dgvAutos.DataSource = null;
            this.dgvAutos.DataSource = negocio.ListarAutos();
            this.dgvAutos.DataBind();

        }
    }
}