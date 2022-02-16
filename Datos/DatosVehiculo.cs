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
    public class DatosVehiculo
    {


        AccesoDatos ds = new AccesoDatos();
        public Vehiculos getVehiculos(Vehiculos veh)
        {
            DataTable tabla = ds.obtenerTabla("Vehiculos", "Select * from Vehiculos where Petente=" + veh.GetPatenteVE());
            veh.SetPatenteVE(tabla.Rows[0][0].ToString());
            veh.SetCodMarcaVE(tabla.Rows[0][1].ToString());
            veh.SetModeloVE(tabla.Rows[0][2].ToString());
            veh.SetColorVE(tabla.Rows[0][3].ToString());
            veh.SetEstadoVE(Convert.ToBoolean(tabla.Rows[0][6].ToString()));
            return veh;
        }

        public Boolean existeVehiculo(Vehiculos veh)
        {
            String consulta = "Select * from Vehiculos where Patente='" + veh.GetPatenteVE() + "'";
            return ds.existe(consulta);
        }

        public DataTable getTablaVehiculos()
        {

            DataTable tabla = ds.obtenerTabla("Vehiculos", "Select * from Vehiculos");
            return tabla;
        }

        public int eliminarVehiculos(Vehiculos veh)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosVehiculosEliminar(ref comando, veh);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spEliminarVehiculos");
        }


        public int agregarVehiculos(Vehiculos veh)
        {


            SqlCommand comando = new SqlCommand();
            ArmarParametrosVehiculosAgregar(ref comando, veh);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spAgregarVehiculos");
        }

        private void ArmarParametrosVehiculosEliminar(ref SqlCommand Comando, Vehiculos veh)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@PATENTE", SqlDbType.VarChar);
            SqlParametros.Value = veh.GetPatenteVE();
        }
//////////////////////////////PARA CAMBIAR EL ESTADO
          public int CambiarEstado(Vehiculos veh)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosCambiarEstadoVehiculo(ref comando, veh);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spCambiarEstado"); 
        }
        
        
        
        private void ArmarParametrosVehiculosAgregar(ref SqlCommand Comando, Vehiculos veh)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@PATENTE", SqlDbType.VarChar);
            SqlParametros.Value = veh.GetPatenteVE();
            SqlParametros = Comando.Parameters.Add("@CODMARCA", SqlDbType.VarChar);
            SqlParametros.Value = veh.GetCodMarcaVE();
            SqlParametros = Comando.Parameters.Add("@CODMODELO", SqlDbType.VarChar);
            SqlParametros.Value = veh.GetModeloVE();
            SqlParametros = Comando.Parameters.Add("@COLOR", SqlDbType.VarChar);
            SqlParametros.Value = veh.GetColorVE();
            SqlParametros = Comando.Parameters.Add("@ESTADOVEH", SqlDbType.Binary);
            SqlParametros.Value = veh.GetEstadoVE();
        }



    
}
}
