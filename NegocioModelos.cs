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
    public class NegocioModelos
    {
        public DataTable getTabla()
        {
            DatosModelo dato = new DatosModelo();
            return dato.getTablaModelos();
        }

        public Modelos get(string cod)
        {
            DatosModelo dato = new DatosModelo();
            Modelos mod = new Modelos();
            mod.SetCodModeloMO(cod);
            return dato.getModelos(mod);
        }

        public bool eliminarModelo(string cod)
        {
            //Validar si existente 
            DatosModelo dato = new DatosModelo();
            Modelos mod = new Modelos();
            mod.SetCodModeloMO(cod);
            int op = dato.eliminarModelos(mod);
            if (op == 1)
                return true;
            else
                return false;
        }

        public bool agregarModelos(Modelos mod)
        {
            int cantFilas = 0;

            DatosModelo dato = new DatosModelo();
            if (dato.existeModelo(mod) == false)
            {
                cantFilas = dato.agregarModelos(mod);
            }

            if (cantFilas == 1)
                return true;
            else
                return false;
        }

        public bool ActualizarModelo(Modelos mod)
        {
            if (mod.GetCodModeloMO() == null)
            {
                return false;
            }

            DatosModelo dao = new DatosModelo();

            int op = dao.actualizarModelos(mod);

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
