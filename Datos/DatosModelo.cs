﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
    public class DatosModelo
    {

        AccesoDatos ds = new AccesoDatos();
        public Modelos getModelos(Modelos mod)
        {
            DataTable tabla = ds.obtenerTabla("Modelos", "Select * from Modelos where CodModelo=" + mod.GetCodModeloMO());
            mod.SetCodModeloMO(tabla.Rows[0][0].ToString());
            mod.SetCodMarcaMO(tabla.Rows[0][1].ToString());
            mod.SetNombModeloMO(tabla.Rows[0][2].ToString());
            mod.SetTipoMO(tabla.Rows[0][3].ToString());
            mod.SetCantPuertaMO(tabla.Rows[0][4].ToString());
            mod.SetCodGammaMO(tabla.Rows[0][5].ToString());
            mod.SetEstadoCL(Convert.ToBoolean(tabla.Rows[0][6].ToString()));
            return mod;
        }

        public Boolean existeModelo(Modelos mod)
        {
            String consulta = "Select * from Modelos where NombreModelo='" + mod.GetNombModeloMO() + "'";
            return ds.existe(consulta);
        }

        public DataTable getTablaModelos()
        {
           
            DataTable tabla = ds.obtenerTabla("Modelos", "Select * from Modelos");
            return tabla;
        }

        public int eliminarModelos(Modelos mod)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosModelosEliminar(ref comando, mod);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spEliminarModelos");
        }


        public int agregarModelos(Modelos mod)
        {

       
            SqlCommand comando = new SqlCommand();
            ArmarParametrosModelosAgregar(ref comando, mod);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spAgregarModelo");
        }

        private void ArmarParametrosModelosEliminar(ref SqlCommand Comando, Modelos mod)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@CODMODELO", SqlDbType.Int);
            SqlParametros.Value = mod.GetCodModeloMO();
        }

        private void ArmarParametrosModelosAgregar(ref SqlCommand Comando, Modelos mod)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@CODMODELO", SqlDbType.Int);
            SqlParametros.Value = mod.GetCodModeloMO();
            SqlParametros = Comando.Parameters.Add("@NOMBREMOD", SqlDbType.VarChar);
            SqlParametros.Value = mod.GetNombModeloMO();
            SqlParametros = Comando.Parameters.Add("@CODMARCA", SqlDbType.VarChar);
            SqlParametros.Value = mod.GetCodMarcaMO();
            SqlParametros = Comando.Parameters.Add("@TIPOMOD", SqlDbType.VarChar);
            SqlParametros.Value = mod.GetTipoMO();
            SqlParametros = Comando.Parameters.Add("@CANTPUERTAS", SqlDbType.VarChar);
            SqlParametros.Value = mod.GetCantPuertaMO();
            SqlParametros = Comando.Parameters.Add("@CODGAMMA", SqlDbType.VarChar);
            SqlParametros.Value = mod.GetCodGammaMO();
            SqlParametros = Comando.Parameters.Add("@ESTADOMOD", SqlDbType.Binary);
            SqlParametros.Value = mod.GetEstadoCL();
        }



    }
}
