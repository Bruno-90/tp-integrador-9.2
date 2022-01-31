using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace menu_clientes
{
    public partial class menu_clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          if(  Session["NombreUsuario"] != null)
            {
                lblUsuario.Text = Session["NombreUsuario"].ToString();
            }
        }

        protected void LVListaAutos_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        protected void btnSeleccionar_Command(object sender, CommandEventArgs e)
        {

        }
    }
}
/////////////////////////////////////////////////////version que hice yo (Bruno)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace menu_clientes
{
    public partial class menu_clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          if(  Session["NombreUsuario"] != null)
            {
                lblUsuario.Text = Session["NombreUsuario"].ToString();
            }

            if (!IsPostBack)
            {
                //carga el ddlgamma
                ListItem Baja = new ListItem("Baja", "BAJ");
                ListItem Media = new ListItem("Media", "MED");
                ListItem Alta = new ListItem("Alta", "ALT");

                DDLGamma.Items.Add(Baja);
                DDLGamma.Items.Add(Media);
                DDLGamma.Items.Add(Alta);
            }
            }

            protected void LVListaAutos_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        protected void btnSeleccionar_Command(object sender, CommandEventArgs e)
        {

        }

        protected void BtnBuscarModelo_Click(object sender, EventArgs e)
        {
            if(TBoxModelo.Text=="")
            {
                SqlDataSource1.SelectCommand ="select imagen_url_autos, cod_marca_mo, nombre_mo, tipo_mo,cant_puer_mo, precio FROM Modelos";
            }
            else
            {
                SqlDataSource1.SelectCommand = "select   imagen_url_autos,nombre_mo,tipo_mo,nombre_ga,cant_puer_mo,precio , cod_marca_mo,cod_gamma_mo ,cod_marca_mo,nombre_ma,nombre_ga from Modelos inner join marcas on cod_ma =cod_marca_mo inner join gammas on cod_ga = cod_gamma_mo where nombre_mo= " + "'" + TBoxModelo.Text + "'";
            }

        }

      

     

        protected void btnSeleccionarMarca(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "SeleccionarXmarcas")
            {
                SqlDataSource1.SelectCommand = "select   imagen_url_autos,nombre_mo,tipo_mo,nombre_ga,cant_puer_mo,precio , cod_marca_mo,cod_gamma_mo ,cod_marca_mo,nombre_ma,nombre_ga from Modelos inner join marcas on cod_ma =cod_marca_mo inner join gammas on cod_ga = cod_gamma_mo where nombre_ma= " + "'" + e.CommandArgument.ToString() + "'";
            }
            }

        protected void DDLGamma_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataSource1.SelectCommand = "select   imagen_url_autos,nombre_mo,tipo_mo,nombre_ga,cant_puer_mo,precio , cod_marca_mo,cod_gamma_mo ,cod_marca_mo,nombre_ma,nombre_ga from Modelos inner join marcas on cod_ma =cod_marca_mo inner join gammas on cod_ga = cod_gamma_mo where cod_ga= " + "'" + DDLGamma.SelectedValue + "'";
        }
    }
}
