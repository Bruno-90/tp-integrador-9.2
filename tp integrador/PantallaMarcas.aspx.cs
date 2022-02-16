using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;
using System.Data;

namespace pantalla_modelos
{
    public partial class menu_modelos : System.Web.UI.Page
    {
        NegocioMarcas neg = new NegocioMarcas();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable tablaMarcas = neg.getTabla();
                grdMarcas.DataSource = tablaMarcas;
                grdMarcas.DataBind();
            }

            if (Session["NombreUsuario"] != null)
            {
                lblUsuario.Text = Session["NombreUsuario"].ToString();
            }
        }
       

        protected void grdMarcas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            bool ejecuto= true;
            NegocioMarcas neg = new NegocioMarcas();

            String cod_ma= ((Label)grdMarcas.Rows[e.RowIndex].FindControl("lblCodMarca")).Text;

            Marcas mar = new Marcas();

            mar.SetCodMarcaMA(cod_ma);
            

            ejecuto= neg.eliminarMarcas(cod_ma);

            if (ejecuto == true)
            {
            DataTable tablaMarcas = neg.getTabla();
            grdMarcas.DataSource = tablaMarcas;
            grdMarcas.DataBind();
            }
            else
            {
                lblMsjError.Text = "NO SE PUEDE ELIMINAR LA MARCA SELECCIONADA YA QUE CONTIENE MODELOS RELACIONADOS. ELIMINE LOS VEHICULOS Y MODELOS PRIMERO.";
            }



           
        }

        protected void grdMarcas_RowEditing(object sender, GridViewEditEventArgs e)
        {
            lblMsjError.Text = "";
              grdMarcas.EditIndex = e.NewEditIndex;
            DataTable tablaMarcas = neg.getTabla();
            grdMarcas.DataSource = tablaMarcas;
            grdMarcas.DataBind();
            //NegocioMarcas neg = new NegocioMarcas();
           // grdMarcas.DataSource = neg.getTabla();
             
            
        }

        protected void grdMarcas_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            String s_codigo = ((Label)grdMarcas.Rows[e.RowIndex].FindControl("lbl_edit_Codma")).Text;
            String s_nombre = ((TextBox)grdMarcas.Rows[e.RowIndex].FindControl("txt_edit_Nombremarca")).Text;

            NegocioMarcas neg = new NegocioMarcas();
            Marcas mar = new Marcas();
            mar.SetCodMarcaMA(s_codigo);
            mar.SetNombMarcaMA(s_nombre);

            NegocioMarcas nego = new NegocioMarcas();
            nego.AgregarMarcas(s_nombre, s_codigo);

            grdMarcas.EditIndex = -1;

           
            DataTable tablaMarcas = neg.getTabla();
            grdMarcas.DataSource = tablaMarcas;
            grdMarcas.DataBind();

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

        protected void grdMarcas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdMarcas.EditIndex = -1;
            DataTable tablaMarcas = neg.getTabla();
            grdMarcas.DataSource = tablaMarcas;
            grdMarcas.DataBind();
        }
    }
}
