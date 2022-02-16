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