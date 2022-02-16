using System;
using Datos;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Negocio
{
   public class NegocioMarcas
    {
        public DataTable getTabla()
        {
            DatosMarcas dao = new DatosMarcas();
            return dao.GetTablaMarcas();
        }

        public bool eliminarMarcas(string codigoMarca)
        {
            if (codigoMarca == null)
            {
                return false;
            }

            DatosMarcas dao = new DatosMarcas();
            Marcas marca = new Marcas();
            marca.SetCodMarcaMA(codigoMarca);
            int op = dao.eliminarMarcaDAO(marca);

            if (op == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AgregarMarcas(string Nombre, string codigo)
        {
            int cantFilas = 0;

            Marcas marca = new Marcas();
            marca.SetNombMarcaMA(Nombre);
            marca.SetCodMarcaMA(codigo);

            DatosMarcas dao = new DatosMarcas();
            if (dao.existeMarca(marca) == false)
            {
                cantFilas = dao.AgregarMarcaDAO(marca);
            }
            if (cantFilas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // nuevo---------------------------12/10/2021 actualizar marca el 2 agrega marcas el 1 actualiza la marca
        public bool AgregarMarcas2(string Nombre, string codigo)
        {
            int cantFilas = 0;

            Marcas marca = new Marcas();
            marca.SetNombMarcaMA(Nombre);
            marca.SetCodMarcaMA(codigo);

            DatosMarcas dao = new DatosMarcas();
            if (dao.existeMarca(marca) == false)
            {
                cantFilas = dao.AgregarMarcaDAO2(marca);
            }
            if (cantFilas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool ActualizarMarca(Marcas mar)
        {
            if (mar.GetCodMarcaMA() == null)
            {
                return false;
            }

            DatosMarcas dao = new DatosMarcas();

            int op = dao.ActualizarMarcaDAO(mar);

            if (op == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
