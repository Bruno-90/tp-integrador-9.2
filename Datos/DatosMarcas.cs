using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
   public class DatosMarcas
    {
        AccesoDatos ds = new AccesoDatos();

        public int AgregarMarcaDAO(Marcas marca)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametroMarcaAgregar(ref comando, marca);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spEditarMarcas"); //spEditarMarcas  spAgregarMarca
        }
        public int AgregarMarcaDAO2(Marcas marca)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametroMarcaAgregar(ref comando, marca);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spAgregarMarca"); //spEditarMarcas  spAgregarMarca
        }

        private void ArmarParametroMarcaAgregar(ref SqlCommand comando, Marcas marca)
        {
            SqlParameter sqlParametro = new SqlParameter();
            sqlParametro = comando.Parameters.Add("@Cod_Ma", SqlDbType.VarChar);
            sqlParametro.Value = marca.GetCodMarcaMA();
            sqlParametro = comando.Parameters.Add("@Nombre_Ma", SqlDbType.VarChar);
            sqlParametro.Value = marca.GetNombMarcaMA();
        }

        public int eliminarMarcaDAO(Marcas marca)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametroMarcaEliminar(ref comando, marca);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spEliminarMarca");
        }

      

        private void ArmarParametroMarcaEliminar(ref SqlCommand comando, Marcas marca)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@Cod_Ma", SqlDbType.VarChar);
            SqlParametros.Value = marca.GetCodMarcaMA();
        }

        public int ActualizarMarcaDAO(Marcas marca)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosMarcaEditar(ref comando, marca);

            return ds.EjecutarProcedimientoAlmacenado(comando, "spEditarMarcas");

        }

        private void ArmarParametrosMarcaEditar(ref SqlCommand comando, Marcas mar)
        {
            SqlParameter parametro = new SqlParameter();

            parametro = comando.Parameters.Add("@Nombre_Ma", SqlDbType.VarChar);
            parametro.Value = mar.GetNombMarcaMA();

            SqlParameter parametro1 = new SqlParameter();
            parametro1 = comando.Parameters.Add("@Cod_Ma", SqlDbType.VarChar);
            parametro.Value = mar.GetCodMarcaMA();
        }

            public Boolean existeMarca(Marcas marca)
        {
            string consulta = "select* from marcas where Nombre_Ma= '" + marca.GetNombMarcaMA() + "'";
            return ds.existe(consulta);
        }

        public DataTable GetTablaMarcas()
        {
            DataTable tabla = ds.obtenerTabla("Marcas", "select * from Marcas");
            return tabla;
        }

        public Marcas GetMarcas(Marcas marca)
        {
            DataTable Tabla = ds.obtenerTabla("Marcas", "select * from Marcas where Cod_Ma= " + marca.GetCodMarcaMA());
            marca.SetCodMarcaMA(Tabla.Rows[0][0].ToString());
            marca.SetNombMarcaMA(Tabla.Rows[0][1].ToString());
            return marca;
        }
    }
}
