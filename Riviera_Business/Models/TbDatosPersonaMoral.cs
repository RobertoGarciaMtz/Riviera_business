using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class TbDatosPersonaMoral
    {
        public TbDatosPersonaMoral()
        {
            TbDatosPersona = new HashSet<TbDatosPersona>();
        }

        public int IdDatosPm { get; set; }
        public int? IdEstado { get; set; }
        public string Usuario { get; set; }
        public string DenominacionRazonSocial { get; set; }
        public DateTime? FechaConstitucion { get; set; }
        public string NoActa { get; set; }
        public string FechaRegistroPublicoComercio { get; set; }
        public string NoRegistroPublicoComercio { get; set; }
        public string Nacionalidad { get; set; }
        public string ActividadGiroMercantilObjeto { get; set; }
        public string NombreCalle { get; set; }
        public string NumInterior { get; set; }
        public string NumExterior { get; set; }
        public string Colonia { get; set; }
        public string Cd { get; set; }
        public string Estado { get; set; }
        public string Cp { get; set; }
        public string NumTelefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string Rfc { get; set; }

        public virtual CEstados IdEstadoNavigation { get; set; }
        public virtual ICollection<TbDatosPersona> TbDatosPersona { get; set; }
    }
}
