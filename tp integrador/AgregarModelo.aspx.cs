using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Entidades;
using Negocio;

namespace tp_integrador
{
    public partial class AgregarModelo : System.Web.UI.Page
    {
        NegocioModelos Nmodelo = new NegocioModelos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["NombreUsuario"] != null)
            {
                lblUsuario.Text = Session["NombreUsuario"].ToString();
            }
            if (!IsPostBack)
            {
                CargarMarcas();
                CargarGamma();
            }
        }

        private void CargarGamma()
        {
            try
            {
                NegocioGamma negGamma = new NegocioGamma();

                DataTable dt = negGamma.getTabla();
                ddlGamma.DataSource = dt;
                ddlGamma.DataTextField = "nombre_ga";
                ddlGamma.DataValueField = "cod_ga";
                ddlGamma.DataBind();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void CargarMarcas()
        {

            try
            {
                NegocioMarcas negMarcas = new NegocioMarcas();

                DataTable dt = negMarcas.getTabla();
                ddlMarca.DataSource = dt;
                ddlMarca.DataTextField = "nombre_ma";
                ddlMarca.DataValueField = "cod_ma";
                ddlMarca.DataBind();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            //recordar hacer null la url de la imagen.
           Boolean comando = false;

            Modelos model = new Modelos();

            model.SetCodMarcaMO(ddlMarca.SelectedValue);
            model.SetCodModeloMO(txtCodModelo.Text.Trim());
            model.SetCodGammaMO(ddlGamma.SelectedValue);
            model.SetNombModeloMO(txtNombre.Text);
            model.SetTipoMO(txtTipo.Text);
            model.SetCantPuertaMO(TxtPuertas.Text);
            model.SetPrecioMO(Convert.ToDecimal( TxtPrecio.Text));
            model.SetEstadoCL(true);

            comando = Nmodelo.agregarModelos(model);

            if (comando== true)
            {
                lblConfirmado.Text = "Registro exitoso!!";
                //ddlMarca.SelectedValue="";
                txtCodModelo.Text="";
                //ddlGamma.SelectedValue = "";
               txtNombre.Text="";
               txtTipo.Text="";
               TxtPuertas.Text="";
                TxtPrecio.Text = "";
            }
            else
            {
                lblConfirmado.Text = "ERROR al registrar intente nuevamente";
                //ddlMarca.SelectedValue = "";
                txtCodModelo.Text = "";
                //ddlGamma.SelectedValue = "";
                txtNombre.Text = "";
                txtTipo.Text = "";
                TxtPuertas.Text = "";
            }

        }
    }
}