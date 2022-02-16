using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace VistaCliente
{
    public partial class cliente : System.Web.UI.Page
    {
        NegocioClientes neg = new NegocioClientes();

        private string nombre ="";
        private string tipo= "";
        private string marca="";
        private int cantPuertas ;
        private decimal Precio;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            nombre = Request.QueryString["nombre"];
            tipo = Request.QueryString["tipo"];
            marca = Request.QueryString["marca"];
            cantPuertas = Convert.ToInt32( Request.QueryString["cantPuertas"]);
            Precio = Convert.ToDecimal(Request.QueryString["Precio"]);

            if (Session["NombreUsuario"] != null)
            {
                lblUsuario.Text = Session["NombreUsuario"].ToString();
            }
            CargarDatosAuto();
        }

        private void CargarDatosAuto()
        {
            try
            {
                lblMarca.Text = marca;
                lblTipo.Text = tipo;
                lblModelo.Text = nombre;
                lblValorAdquisicion.Text = "$ "+ Precio.ToString();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        protected void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // deberia dar de baja al auto y dar de alta al cliente registrado.

            Clientes client = new Clientes();

            client.SetNombreCL(txtNombre.Text.Trim());
            client.SetApellidoCL(txtApellido.Text.Trim());
            client.SetMailCL(txtEmail.Text.Trim());
            client.SetTelefonoCL(txtTelefono.Text.Trim());
            client.SetDireccionCL(txtCalle.Text.Trim());
            client.SetAlturaDireccionCL(txtNumcalle.Text.Trim());
            
            if (txtPiso.Text == null)
            {
                client.SetPisoCL("");
            }else
            {
                client.SetPisoCL(txtPiso.Text.Trim());
            }

            if (txtDep.Text == null)
            {
                client.SetDepartamentoCL("");
            }
            else
            {
                client.SetDepartamentoCL(txtDep.Text.Trim());
            }

            client.SetCodPostalCL(txtCodPostal.Text.Trim());
            client.SetPartidoCL(txtPartido.Text.Trim());
            client.SetProvinciaCL(txtProvincia.Text.Trim());
            client.SetEstadoCL(true);
            client.SetDniCL(txtDni.Text.Trim());
            client.SetAnioGS(Convert.ToDateTime( txtFecha.Text.Trim()));

            bool estado = neg.AgregarClientes(client);
            if (estado!= false)
            {
                lblMensajeRegFor.Text = "se registro satisfactoriamente!";
            }
            else
            {
                lblMensajeRegFor.Text = "formulario NNNNNOOOOO registrado";
            }

            //  client.SetVehiculoElegidoCL(lblPatente.Text); <<<<<<<<< por ahi sirve   20/11 22.00

            

        }


    }
}
