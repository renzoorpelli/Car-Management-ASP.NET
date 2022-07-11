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

            if (Session["listaAutos"] == null)
            {
                this.negocio = new AutoNegocio();
                Session.Add("listaAutos", negocio.ListarAutos());
            }

            this.dgvAutos.DataSource = Session["listaAutos"];
            this.dgvAutos.DataBind();


        }


        protected void btnAgregarPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("AutoForm.aspx", false);
        }

        protected void dgvAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = dgvAutos.SelectedDataKey.Value.ToString();
            if (id != null)
            {
                Response.Redirect($"AutoForm.aspx?id={id}");
            }
        }
    }
}