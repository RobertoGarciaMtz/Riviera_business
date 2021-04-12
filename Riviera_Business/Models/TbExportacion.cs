using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class TbExportacion
    {
        public int IdExportacion { get; set; }
        public string OrdenCompra { get; set; }
        public string NoFactura { get; set; }
        public float? ValorFactura { get; set; }
        public DateTime? FechaFactura { get; set; }
        public int? Cfdi { get; set; }
        public int? Xml { get; set; }
        public int? PedimientoImpOk { get; set; }
        public int? Pagada { get; set; }
        public DateTime? FechaPago { get; set; }
        public float? CfdiFpA { get; set; }
        public int? IdEstado { get; set; }
        public DateTime? FechaPromesaEntrega { get; set; }
        public int? CartaPoderId { get; set; }
        public int? Entregada { get; set; }
        public string ObservacionesReclamos { get; set; }
        public DateTime? SalidaAgencia { get; set; }
        public int? IdPersona { get; set; }

        public virtual CEstados IdEstadoNavigation { get; set; }
        public virtual TbDatosPersona IdPersonaNavigation { get; set; }
    }
}
