using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Modelos
    {
        private string CodMarca;
        private string CodModelo;
        private string NombModelo;
        private string TipoModelo;
        private string CantPuertas;
        private string CodGamma;
        private decimal Precio;
        private Boolean Estado;

        public Modelos()
        {

        }

        public string GetCodMarcaMO()
        {
            return CodMarca;
        }
        public void SetCodMarcaMO(string NuevoCodMarcaMO)
        {
            CodMarca = NuevoCodMarcaMO;
        }

        public string GetCodModeloMO()
        {
            return CodModelo;
        }
        public void SetCodModeloMO(string NuevoCodMO)
        {
            CodModelo = NuevoCodMO;
        }

        public string GetNombModeloMO()
        {
            return NombModelo;
        }
        public void SetNombModeloMO(string NuevoNombreMO)
        {
            NombModelo = NuevoNombreMO;
        }

        public string GetTipoMO()
        {
            return TipoModelo;
        }
        public void SetTipoMO(string NuevoTipoMO)
        {
            TipoModelo = NuevoTipoMO;
        }

        public string GetCantPuertaMO()
        {
            return CantPuertas;
        }
        public void SetCantPuertaMO(string NuevoPuertasMO)
        {
            CantPuertas = NuevoPuertasMO;
        }

        public string GetCodGammaMO()
        {
            return CodGamma;
        }
        public void SetCodGammaMO(string NuevoCodGammaMO)
        {
            CodGamma = NuevoCodGammaMO;
        }

        public Boolean GetEstadoCL()
        {
            return Estado;
        }
        public void SetEstadoCL(Boolean NuevoEstado)
        {
            Estado = NuevoEstado;
        }
        public decimal GetPrecioMO()
        {
            return Precio;
        }
         public void SetPrecioMO(decimal NuevoPrecio)
        {
            Precio = NuevoPrecio;
        }
    }
}
