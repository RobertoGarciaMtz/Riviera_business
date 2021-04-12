using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class TbDatosPersona
    {
        public TbDatosPersona()
        {
            TbDocumentacion = new HashSet<TbDocumentacion>();
            TbExportacion = new HashSet<TbExportacion>();
        }

        public int IdDatosPersona { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string ActividadUOcupacion { get; set; }
        public string NombreCalle { get; set; }
        public string NoInterior { get; set; }
        public string NoExterior { get; set; }
        public string Colonia { get; set; }
        public string Cd { get; set; }
        public string Estado { get; set; }
        public string Cp { get; set; }
        public string Curp { get; set; }
        public string Rfc { get; set; }
        public string NumeroTelefono { get; set; }
        public int? FisicaOMoral { get; set; }
        public int? IdEstado { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaPoderNotorial { get; set; }
        public string NoPoderNotorial { get; set; }
        public string AutoridadEmite { get; set; }
        public int? IdPmDp { get; set; }
        public string Puesto { get; set; }

        public virtual CEstados IdEstadoNavigation { get; set; }
        public virtual TbDatosPersonaMoral IdPmDpNavigation { get; set; }
        public virtual ICollection<TbDocumentacion> TbDocumentacion { get; set; }
        public virtual ICollection<TbExportacion> TbExportacion { get; set; }
    }
}
