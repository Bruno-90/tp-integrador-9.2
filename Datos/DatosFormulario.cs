using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosFormulario
    {
        AccesoDatos ds = new AccesoDatos();


        public Formularios getFormularios(Formularios formu)

        { //creo que la busqueda de la tabla debe ser por la patente, ya que el codigo de registro es autonumerico

            DataTable tabla = ds.obtenerTabla("Formularios", "Select * from Formularios where patente_fo = '" + formu.GetPatenteFO() + "'");

            formu.SetCodigoFO(Convert.ToInt32(tabla.Rows[0][0].ToString()));
            formu.SetPatenteFO(tabla.Rows[0][1].ToString());
            formu.SetMatGestorFO(tabla.Rows[0][2].ToString());
            formu.SetDniCliFO(tabla.Rows[0][3].ToString());           
            formu.SetNombConyuFO(tabla.Rows[0][4].ToString());
            formu.SetApeConyuFO(tabla.Rows[0][5].ToString());
            formu.SetPersoneriaFO(tabla.Rows[0][6].ToString());
            return formu;

        }

        public DataTable FiltrarFormulario(string marca, string gamma, string modelo, string gestor, string cliente)
        {
            string Condicion = "";
            string consulta = "select f.cod_registro_fo 'Cod. Formulario',f.patente_fo 'Patente Veh.',g.matricula_ge as 'Matricula gestor',";
            consulta += "g.apellido_ge + ', ' + g.nombre_ge as 'Nombre Completo Gestor',";
            consulta += "cl.nombre_cl + ' ' + cl.apellido_cl as 'Cliente' ,";
            consulta += "ma.nombre_ma 'Marca', ga.nombre_ga 'Gamma',";
            consulta += "M.nombre_mo Modelo, f.nombre_conyu_fo + ' ' + f.apellido_conyu_fo as 'Conyugue',";
            consulta += "f.personeria_fo personeria ";
            consulta += "from Formularios f ";
                consulta += "inner join Gestores g on g.matricula_ge = f.matricula_gestor_fo ";
                consulta += "inner join Clientes cl on cl.dni_cl = f.dni_cliente_fo ";
                consulta += "INNER JOIN Vehiculos vh on vh.patente_ve = f.patente_fo ";
                consulta += "inner join Modelos M on vh.cod_gamma_ve = M.cod_gamma_mo ";
                consulta += "and vh.cod_marca_ve = M.cod_marca_mo and ";
                consulta += "vh.cod_modelo_ve = M.cod_mo ";
                consulta += "inner join Marcas ma on ma.cod_ma = M.cod_marca_mo ";
                consulta += "inner join Gammas ga on ga.cod_ga = M.cod_gamma_mo ";
            if(marca!="" || gamma!="" || modelo!="" || gestor!="")
                consulta += " where ";

            if (!string.IsNullOrEmpty(marca))
            {
                Condicion += "ma.cod_ma like '" + marca+"'";
            }

            if (!string.IsNullOrEmpty(gamma))
            {
                if (!string.IsNullOrEmpty(Condicion))
                {
                    Condicion += " AND ga.cod_ga LIKE '"+gamma+"'";
                }
                else
                {
                    Condicion += " ga.cod_ga LIKE '" + gamma + "'";
                }
            }

            if (!string.IsNullOrEmpty(modelo))
            {
                if (!string.IsNullOrEmpty(Condicion))
                {
                    Condicion += " AND M.cod_mo LIKE '" + modelo + "'";
                }   
                else
                {
                    Condicion += " M.cod_mo LIKE '" + modelo + "'";
                }
            }

            if (!string.IsNullOrEmpty(gestor))
            {
                if (!string.IsNullOrEmpty(Condicion))
                {
                    Condicion += " AND g.matricula_ge LIKE '" + gestor + "'";
                }
                else
                {
                    Condicion += " g.matricula_ge LIKE '" + gestor + "'";
                }
            }

            if (!string.IsNullOrEmpty(cliente))
            {
                if (!string.IsNullOrEmpty(Condicion))
                {
                    Condicion += " AND cl.dni_cl LIKE '" + cliente + "'";
                }
                else
                {
                    Condicion += " cl.dni_cl LIKE '" + cliente + "'";
                }
            }

            consulta += Condicion;

            DataTable tabla = ds.obtenerTabla("FormulariosFiltrado", consulta);
            return tabla;
        }

        public Boolean existeformulario(Formularios formu)
        {
            string consulta = "select cod_registro_fo from formularios where cod_registro_fo='" + formu.GetCodigoFO() + "'";
            return ds.existe(consulta);
        }
        public DataTable GetTablaFormularios()
        {

            DataTable tabla = ds.obtenerTabla("Formularios", "Select * from Formularios");
            return tabla;
        }

        //---------------no creo que se use el eliminar formularios, pero aqui lo dejo por las dudas------------------

        /*public int EliminarFormularios(Formularios formu)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosFormulariosEliminar(ref comando, formu);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spEliminarFormularios");
        }*/
        private void ArmarParametrosFormulariosEliminar(ref SqlCommand Comando, Formularios formu)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@CODIGO", SqlDbType.Int);
            SqlParametros.Value = formu.GetCodigoFO();
        }
        public int AgregarFormularios(Formularios formu)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosFormulariosAgregar(ref comando, formu);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spAgregarFormularios");
        }

        //---------------no creo que se use el actualizar o editar de formularios, pero aqui lo dejo por las dudas------------------

        /*public int ActualizarFormulariosDAO(Formularios formu)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosFormulariosEditar(ref comando, Formularios);

            return ds.EjecutarProcedimientoAlmacenado(comando, "spEditarFormularios");

        }

        private void ArmarParametrosFormulariosEditar(ref SqlCommand comando, Formularios formu)
        {
            SqlParameter parametro = new SqlParameter();

            parametro = comando.Parameters.Add("@COD_REGISTRO_fo", SqlDbType.Int);
            parametro.Value = formu.GetCodigoFO();
            parametro = comando.Parameters.Add("@PATENTE_fo", SqlDbType.VarChar);
            parametro.Value = formu.GetPatenteFO();
            parametro = comando.Parameters.Add("@MATRICULA_GESTOR_fo", SqlDbType.VarChar);
            parametro.Value = formu.GetMatGestorFO();
            parametro = comando.Parameters.Add("@DNI_CLIENTE_fo", SqlDbType.VarChar);
            parametro.Value = formu.GetDniCliFO();
            parametro = comando.Parameters.Add("@NOMBRE_CONYU_fo", SqlDbType.VarChar);
            parametro.Value = formu.GetNombConyuFO();
            parametro = comando.Parameters.Add("@APELLIDO_CONYU_fo", SqlDbType.VarChar);
            parametro.Value = formu.GetApeConyuFO();
            parametro = comando.Parameters.Add("@PERSONERIA_fo", SqlDbType.VarChar);
            parametro.Value = formu.GetPersoneriaFO();

        }*/

        private void ArmarParametrosFormulariosAgregar(ref SqlCommand Comando, Formularios formu)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@COD_REGISTRO_fo", SqlDbType.Int);
            SqlParametros.Value = formu.GetCodigoFO();
            SqlParametros = Comando.Parameters.Add("@PATENTE_fo", SqlDbType.VarChar);
            SqlParametros.Value = formu.GetPatenteFO();
            SqlParametros = Comando.Parameters.Add("@MATRICULA_GESTOR_fo", SqlDbType.VarChar);
            SqlParametros.Value = formu.GetMatGestorFO();
            SqlParametros = Comando.Parameters.Add("@DNI_CLIENTE_fo", SqlDbType.VarChar);
            SqlParametros.Value = formu.GetDniCliFO();
            SqlParametros = Comando.Parameters.Add("@NOMBRE_CONYU_fo", SqlDbType.VarChar);
            SqlParametros.Value = formu.GetNombConyuFO();
            SqlParametros = Comando.Parameters.Add("@APELLIDO_CONYU_fo", SqlDbType.VarChar);
            SqlParametros.Value = formu.GetApeConyuFO();
            SqlParametros = Comando.Parameters.Add("@PERSONERIA_fo", SqlDbType.VarChar);
            SqlParametros.Value = formu.GetPersoneriaFO();

        }
    }
}
