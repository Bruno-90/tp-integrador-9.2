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
    public partial class ListaFormulariosPorGestores : System.Web.UI.Page
    {
        public NegocioFormularios negForm= new NegocioFormularios();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarMarcas();
                cargarGammas();
                cargarModelos();
                cargarGestores();
                cargarClientes();
                DataTable dt = negForm.GetFiltrado("","","","","");
                grdvwFormularios.DataSource = dt;
                grdvwFormularios.DataBind();
            }
        }

        private void cargarClientes()
        {
            NegocioClientes negCliente = new NegocioClientes();
            DataTable Dt = negCliente.getTabla();
            DataRow dr = Dt.NewRow();
            dr["dni_cl"] = 0;
            dr["nombre_cl"] = "todos";
            dr["apellido_cl"] = "";
            //dr["NombreCompleto"] = "Todos";
            Dt.Rows.InsertAt(dr, 0);
            Dt.Columns.Add("NombreCompleto",typeof(string),"nombre_cl+ ' ' +apellido_cl");
            ddlCliente.DataSource = Dt;
            ddlCliente.DataValueField = "dni_cl";
            ddlCliente.DataTextField = "NombreCompleto";
            ddlCliente.DataBind();
            ddlCliente.SelectedValue = "0";
        }

        private void cargarGestores()
        {
            negociogestores negGestor = new negociogestores();
            DataTable dataTable = negGestor.getTabla();
            DataRow dr = dataTable.NewRow();
            dr["matricula_ge"] = 0;
            dr["nombre_ge"] = "todos";
            dr["apellido_ge"] = "";
            //dr["NombreCompleto"] = "Todos";
            dataTable.Rows.InsertAt(dr, 0);
            dataTable.Columns.Add("NombreCompleto", typeof(string), "nombre_ge+ ' ' +apellido_ge");
            ddlGestor.DataSource = dataTable;
            ddlGestor.DataValueField = "matricula_ge";
            ddlGestor.DataTextField = "NombreCompleto";
            
            ddlGestor.DataBind();
            ddlGestor.SelectedValue = "0";
        }

        private void cargarModelos()
        {
            NegocioModelos negModelo = new NegocioModelos();
            DataTable dataTable = negModelo.getTabla();
            DataRow dr = dataTable.NewRow();
            dr["nombre_mo"] = "Todos";
            dr["cod_mo"] = 0;
            dataTable.Rows.InsertAt(dr, 0);
            ddlModelo.DataSource = dataTable;
            ddlModelo.DataValueField = "cod_mo";
            ddlModelo.DataTextField = "nombre_mo";
            ddlModelo.DataBind();
            ddlModelo.SelectedValue = "0";
        }

        private void cargarGammas()
        {
            NegocioGamma negMarca= new NegocioGamma();
            DataTable dataTable = negMarca.getTabla();
            DataRow dr = dataTable.NewRow();
            dr["nombre_ga"] = "Todos";
            dr["cod_ga"] = 0;
            dataTable.Rows.InsertAt(dr, 0);
            ddlGamma.DataSource = dataTable;
            ddlGamma.DataValueField = "cod_ga";
            ddlGamma.DataTextField = "nombre_ga";
            ddlGamma.DataBind();
            ddlGamma.SelectedValue = "0";
        }

        private void cargarMarcas()
        {
            NegocioMarcas negMarca = new NegocioMarcas();
            DataTable dataTable = negMarca.getTabla();
            DataRow dr = dataTable.NewRow();
            dr["nombre_ma"] = "Todos";
            dr["cod_ma"] = 0;
            dataTable.Rows.InsertAt(dr, 0);
            ddlMarca.DataSource = dataTable;
            ddlMarca.DataValueField = "cod_ma";
            ddlMarca.DataTextField = "nombre_ma";
            ddlMarca.DataBind();
            ddlMarca.SelectedValue = "0";
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            string codMarca = ddlMarca.SelectedValue;
            string codGamma = ddlGamma.SelectedValue;
            string codModelo = ddlModelo.SelectedValue;
            string codCliente = ddlCliente.SelectedValue;
            string codGestor = ddlGestor.SelectedValue;

            if (codMarca == "0")
                codMarca = "";
            if (codGamma == "0")
                codGamma = "";
            if (codModelo == "0")
                codModelo = "";
            if (codCliente == "0")
                codCliente = "";
            if (codGestor == "0")
                codGestor = "";

           DataTable dt = negForm.GetFiltrado(codMarca,codGamma,codModelo,codCliente,codGestor);
            grdvwFormularios.DataSource = dt;
            grdvwFormularios.DataBind();

        }
    }
}