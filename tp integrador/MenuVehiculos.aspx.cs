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
            string s = "";
            s = e.CommandArgument.ToString();
            string[] vectorArgumento = s.Split('-');

            Response.Redirect("Formulario01.aspx?nombre=" + vectorArgumento[0] + "&tipo=" + vectorArgumento[1] + "&marca=" + vectorArgumento[2] + "&cantPuertas=" + vectorArgumento[3] +"&Precio=" + vectorArgumento[4]); 
        }
    }
}










////////////////////////////////////////////////////////////////////////NUEVOOOOOOOOOOOOOOOOOOOOOO


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
                SqlDataSource1.SelectCommand = "select  imagen_url_autos,nombre_mo,tipo_mo,nombre_ga,cant_puer_mo,precio ,patente_ve,color, cod_marca_mo,cod_gamma_mo ,cod_mo,cod_marca_mo,nombre_ma,nombre_ga from vehiculos inner join modelos on cod_modelo_ve = cod_mo inner join marcas on cod_ma = cod_marca_mo inner join gammas on cod_ga = cod_gamma_mo where estado = 1 ";
            }
            else
            {
                SqlDataSource1.SelectCommand = "select  imagen_url_autos,nombre_mo,tipo_mo,nombre_ga,cant_puer_mo,precio ,patente_ve,color, cod_marca_mo,cod_gamma_mo ,cod_mo,cod_marca_mo,nombre_ma,nombre_ga from vehiculos inner join modelos on cod_modelo_ve = cod_mo inner join marcas on cod_ma = cod_marca_mo inner join gammas on cod_ga = cod_gamma_mo where estado = 1  and nombre_mo = " + "'" + TBoxModelo.Text + "'";
            }

        }

      

     

        protected void btnSeleccionarMarca(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "SeleccionarXmarcas")
            {
                SqlDataSource1.SelectCommand = "select  imagen_url_autos,nombre_mo,tipo_mo,nombre_ga,cant_puer_mo,precio ,patente_ve,color, cod_marca_mo,cod_gamma_mo ,cod_mo,cod_marca_mo,nombre_ma,nombre_ga from vehiculos inner join modelos on cod_modelo_ve = cod_mo inner join marcas on cod_ma = cod_marca_mo inner join gammas on cod_ga = cod_gamma_mo where estado = 1  and nombre_ma = " + "'" + e.CommandArgument.ToString() + "'";
            }
            }

        protected void DDLGamma_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataSource1.SelectCommand = "select  imagen_url_autos,nombre_mo,tipo_mo,nombre_ga,cant_puer_mo,precio ,patente_ve,color, cod_marca_mo,cod_gamma_mo ,cod_mo,cod_marca_mo,nombre_ma,nombre_ga from vehiculos inner join modelos on cod_modelo_ve = cod_mo inner join marcas on cod_ma = cod_marca_mo inner join gammas on cod_ga = cod_gamma_mo where estado = 1  and nombre_ga = " + "'" + DDLGamma.SelectedValue + "'";
        }




        protected void BtnSeleccionar_Command(object sender, CommandEventArgs e)
        {
            string s = "";
            s = e.CommandArgument.ToString();
            string[] vectorArgumento = s.Split(';');

            Response.Redirect("Formulario01.aspx?nombre=" + vectorArgumento[0] + "&tipo=" + vectorArgumento[1] + "&cantPuertas="  + vectorArgumento[2] + "&marca=" + vectorArgumento[3]+ "&gamma=" + vectorArgumento[4] + "&Precio=" + vectorArgumento[5] + "&color=" + vectorArgumento[6]+ "&patente=" + vectorArgumento[7]); 
        }
    }
}
