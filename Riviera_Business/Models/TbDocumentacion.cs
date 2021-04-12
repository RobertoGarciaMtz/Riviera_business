using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class TbDocumentacion
    {
        public int IdDocumentos { get; set; }
        public int? IdentificacionVig { get; set; }
        public int? Curp { get; set; }
        public int? CifSat { get; set; }
        public int? ComprobDomicilio { get; set; }
        public int? ConocimientoDuenoBeneficiario { get; set; }
        public int? ActaConstitutivaBoletaRpc { get; set; }
        public int? PoderLegarExp { get; set; }
        public int? ConstanciaConocimiento { get; set; }
        public int? IdEstado { get; set; }
        public string Usuario { get; set; }
        public int? IdDatosPersona { get; set; }
        public int? MesCorrespondiente { get; set; }
        public int? PersonaFM { get; set; }

        public virtual TbDatosPersona IdDatosPersonaNavigation { get; set; }
        public virtual CEstados IdEstadoNavigation { get; set; }
    }
}
