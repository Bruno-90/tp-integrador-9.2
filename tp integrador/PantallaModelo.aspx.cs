using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace tp_integrador
{
    public partial class Pantalla_Modelo : System.Web.UI.Page
    {
        NegocioModelos negModelos = new Negocio.NegocioModelos();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["NombreUsuario"] != null)
            {
                lblUsuario.Text = Session["NombreUsuario"].ToString();
            }
            if (!IsPostBack)
            {
                CargarGridview();
            }
        }

        public void CargarGridview()
        {
            DataTable dtModelos = new DataTable();
            dtModelos = negModelos.getTabla();
            grdModelos.DataSource = dtModelos;
            grdModelos.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["NivelUsuario"].ToString() != "1")
            {
                Response.Redirect("MenuGestoriaMaster.aspx");
            }
            else
            {
                Response.Redirect("MenuGestoria.aspx");
            }
        }

        protected void grdModelos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdModelos.EditIndex = e.NewEditIndex;
            CargarGridview();
        }

        protected void grdModelos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String s_marca = ((Label)grdModelos.Rows[e.RowIndex].FindControl("lbl_edit_codma")).Text;//cod_marca
            String s_modelo = ((Label)grdModelos.Rows[e.RowIndex].FindControl("lbl_edit_modelo")).Text;//cod_modelo
            String s_gamma = ((Label)grdModelos.Rows[e.RowIndex].FindControl("lbl_edit_gamma")).Text;//cod_gamma

            String s_nombre = ((TextBox)grdModelos.Rows[e.RowIndex].FindControl("txt_edit_nombreModelo")).Text;//nombre modelo
            String s_tipo = ((TextBox)grdModelos.Rows[e.RowIndex].FindControl("txt_edit_TipoAuto")).Text;//
            String s_CantPuertas = ((TextBox)grdModelos.Rows[e.RowIndex].FindControl("txt_edit_CantPuertas")).Text;
            String s_Precio = ((TextBox)grdModelos.Rows[e.RowIndex].FindControl("txt_edit_Precio")).Text;



            Modelos modelo = new Modelos();
            modelo.SetCodMarcaMO( s_marca);
            modelo.SetCodModeloMO(s_modelo);
            modelo.SetCodGammaMO(s_gamma);
            modelo.SetNombModeloMO(s_nombre);
            modelo.SetTipoMO(s_tipo);
            modelo.SetCantPuertaMO(s_CantPuertas);
            modelo.SetPrecioMO(Convert.ToDecimal(s_Precio));
            modelo.SetEstadoCL(true);

            bool Ejecuto = negModelos.ActualizarModelo(modelo);

            if(Ejecuto == false)
            {
                    lblMsjError.Text = "NO SE PUEDE MODIFICAR EL MODELO SELECCIONADO.";
            }
            else
            {
                lblMsjError.Text = "";
            }

            grdModelos.EditIndex = -1;
            CargarGridview();
        }

        protected void grdModelos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdModelos.EditIndex = -1;
            CargarGridview();
        }

        protected void grdModelos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            String s_marca = ((Label)grdModelos.Rows[e.RowIndex].FindControl("lblCodMarca")).Text;//cod_marca
            String s_modelo = ((Label)grdModelos.Rows[e.RowIndex].FindControl("lblModelo")).Text;//cod_modelo
            String s_gamma = ((Label)grdModelos.Rows[e.RowIndex].FindControl("lblGamma")).Text;//cod_gamma

            String s_nombre = ((Label)grdModelos.Rows[e.RowIndex].FindControl("lblModeloNombre")).Text;//nombre modelo
            String s_tipo = ((Label)grdModelos.Rows[e.RowIndex].FindControl("lblTipoAuto")).Text;//
            String s_CantPuertas = ((Label)grdModelos.Rows[e.RowIndex].FindControl("lblCantPuertas")).Text;
            String s_Precio = ((Label)grdModelos.Rows[e.RowIndex].FindControl("lblPrecio")).Text;

            Modelos modelo = new Modelos();
            modelo.SetCodMarcaMO(s_marca);
            modelo.SetCodModeloMO(s_modelo);
            modelo.SetCodGammaMO(s_gamma);
            modelo.SetNombModeloMO(s_nombre);
            modelo.SetTipoMO(s_tipo);
            modelo.SetCantPuertaMO(s_CantPuertas);
            modelo.SetPrecioMO(Convert.ToDecimal(s_Precio));
            modelo.SetEstadoCL(false);


            bool Ejecuto = negModelos.ActualizarModelo(modelo);

            if (Ejecuto == false)
            {
                lblMsjError.Text = "NO SE PUEDE ELIMINAR EL MODELO SELECCIONADO.";
            }
            else
            {
                lblMsjError.Text = "";
            }

            grdModelos.EditIndex = -1;
            CargarGridview();
         
        }
    }
}