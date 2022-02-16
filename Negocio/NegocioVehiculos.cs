using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.Data;

namespace Negocio
{
    public class NegocioVehiculos
    {
        public DataTable getTabla()
        {
            DatosVehiculo dato = new DatosVehiculo();
            return dato.getTablaVehiculos();
        }

        public Vehiculos get(string cod)
        {
            DatosVehiculo dato = new DatosVehiculo();
            Vehiculos veh = new Vehiculos();
            veh.SetPatenteVE(cod);
            return dato.getVehiculos(veh);
        }

       /* public bool eliminarVehiculos(string cod)
        {
            //Validar si existente 
            DatosVehiculo dato = new DatosVehiculo();
            Vehiculos veh = new Vehiculos();
            veh.SetPatenteVE(cod);
            int op = dato.eliminarVehiculos(veh);
            if (op == 1)
                return true;
            else
                return false;
        }*/
        /////////////////////////SE CAMBIA ELIMINAR POR DAR DE BAJA EL AUTO AL MOMENTO DE ACEPTAR LOS DATOS DE FORMULARIO
          public bool CambiarEstado(Vehiculos veh)
        {
            if (veh.GetPatenteVE() == null)
            {
                return false;
            }


        public bool agregarVehiculos(Vehiculos veh)
        {
            int cantFilas = 0;

            DatosVehiculo dato = new DatosVehiculo();
            if (dato.existeVehiculo(veh) == false)
            {
                cantFilas = dato.agregarVehiculos(veh);
            }

            if (cantFilas == 1)
                return true;
            else
                return false;

        }
    }
}
