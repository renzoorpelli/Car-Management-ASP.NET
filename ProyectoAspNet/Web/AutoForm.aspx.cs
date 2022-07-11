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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.ddlColor.Items.Add("Negro");
                this.ddlColor.Items.Add("Rojo");
                this.ddlColor.Items.Add("Blanco");
                this.ddlColor.Items.Add("Azul");
                this.ddlColor.Items.Add("Amarillo");
                if (Request.QueryString["id"] != null)
                {
                   
                    this.btnModificar.Visible = true;
                    this.btnEliminar.Visible = true;
                    int id = int.Parse(Request.QueryString["id"]);
                    this.txtId.Text = id.ToString();
                    List<Auto> lista = ((List<Auto>)Session["listaAutos"]);
                    Auto autoSeleccionado = lista.Find(x => x.Id == id);
                    txtId.ReadOnly = true;
                    txtModelo.Text = autoSeleccionado.Modelo;
                    txtDescripcion.Text = autoSeleccionado.Descripcion;
                    this.btnAceptar.Enabled = false;

                }
            }
            

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Auto auto = new Auto(
                AutoNegocio.ValidarNumero(this.txtId.Text),
                AutoNegocio.ValidarCampo(txtModelo.Text) ? txtModelo.Text : "Modelo Invalido",
                AutoNegocio.ValidarCampo(txtDescripcion.Text) ? txtDescripcion.Text : "Descripcion Invalida",
                this.ddlColor.SelectedValue,
                AutoNegocio.ValidarFecha(DateTime.Parse(this.txtFecha.Text)) ? DateTime.Parse(this.txtFecha.Text) : DateTime.Now,
                this.chbUsado.Checked ? true : false,
                this.rdbImportado.Checked ? true : false
                );
            ((List<Auto>)Session["listaAutos"]).Add(auto);
            Response.Redirect("Default.aspx", false);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx", false);
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            List<Auto> lista = ((List<Auto>)Session["listaAutos"]);
            Auto autoSeleccionado = lista.Find(x => x.Id == id);
            autoSeleccionado.Modelo = this.txtModelo.Text;
            autoSeleccionado.Descripcion = AutoNegocio.ValidarCampo(txtDescripcion.Text) ? txtDescripcion.Text : "Descripcion Invalida";
            autoSeleccionado.Color = this.ddlColor.SelectedValue;
            autoSeleccionado.Fecha = AutoNegocio.ValidarFecha(DateTime.Parse(this.txtFecha.Text)) ? DateTime.Parse(this.txtFecha.Text) : DateTime.Now;
            autoSeleccionado.EsUsado = this.chbUsado.Checked ? true : false;
            autoSeleccionado.Importado = this.rdbImportado.Checked ? true : false;
            Response.Redirect("Default.aspx", false);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            List<Auto> lista = ((List<Auto>)Session["listaAutos"]);
            Auto autoSeleccionado = lista.Find(x => x.Id == id);
            lista.Remove(autoSeleccionado);
            Response.Redirect("Default.aspx", false);
        }
    }
}