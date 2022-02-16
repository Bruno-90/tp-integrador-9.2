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
    public class NegocioFormularios
    {
        //inicio del public class NegocioFormulario
        public DataTable getTabla()
        {
            DatosFormulario dato = new DatosFormulario();
            return dato.GetTablaFormularios();
        }

        public Formularios get(Formularios formu)
        {
            DatosFormulario dato = new DatosFormulario();
            return dato.getFormularios(formu);

        }

        public DataTable GetFiltrado(string marca, string gamma, string modelo, string Gestor, string cliente)
        {
            DatosFormulario dato = new DatosFormulario();
            DataTable dt = dato.FiltrarFormulario(marca, gamma, modelo, Gestor,cliente);
            if(dt.Rows.Count>0 || dt == null)
            {
                return dt;
            }
            else
            {
                return null;
            }
        }

        //---------no se si se va a usar, pero lo dejo agregado por las dudas un eliminar estan comentados-------------
       /* public bool EliminarFormularios(int cod) // cod seria el codigo de registro
        {
            //Validar si existente 
            DatosFormulario dato = new DatosFormulario();
            Formularios formu = new Formularios();
            formu. SetMatriculaGS(cod);
            int op = dato.EliminarFormularios(formu);
            if (op == 1)
                return true;
            else
                return false;
        }*/
        public bool AgregarFormularios(Formularios formu)
        {
            int cantFilas = 0;

            DatosFormulario dato = new DatosFormulario();
            if (dato.existeformulario(formu) == false)
            {
                cantFilas = dato.AgregarFormularios(formu);
            }

            if (cantFilas == 1)
                return true;
            else
                return false;

        }
        //----------------------no se si se va a usar, pero lo dejo agregado por las dudas un actualizar-------------
       /* public bool ActualizarFormularios(Formularios formu)
        {
            if (formu.GetMatriculaGS() == null)
            {
                return false;
            }

            DatosFormulario dao = new DatosFormulario();

            int op = dao.ActualizarFormulariosDAO(formu);

            if (op == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/


        //fin del public class NegocioFormulario

    }
}






////////////////////////////////////////VERSION FUNCIONANDO
