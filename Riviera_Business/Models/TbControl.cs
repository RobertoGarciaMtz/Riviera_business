using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class TbControl
    {
        public TbControl()
        {
            TbCarrosTransaccion = new HashSet<TbCarrosTransaccion>();
        }

        public int IdMovimiento { get; set; }
        public int? CompraVenta { get; set; }
        public int? TipoVenta { get; set; }
        public int? NoFacturaArv { get; set; }
        public DateTime? FechaFacturaToma { get; set; }
        public string FolioFiscal { get; set; }
        public int? IdCarros { get; set; }
        public DateTime? FechaFactura { get; set; }
        public float? SubTotal { get; set; }
        public float? Iva { get; set; }
        public float? Total { get; set; }
        public int? PagadaCobrada { get; set; }
        public int? IdCliente { get; set; }
        public string VoBoFacturarSat { get; set; }
        public int? VoBoLeyAntiLavado { get; set; }
        public string ClienteVenta { get; set; }
        public string Usuarios { get; set; }
        public int? FormaPago { get; set; }
        public int? IdMetodoPago { get; set; }
        public DateTime? FechaES { get; set; }
        public int? IdEstado { get; set; }
        public float? PrecioPactado { get; set; }
        public int? Debiendo { get; set; }
        public float? CantidadDebida { get; set; }
        public int? Contrato { get; set; }
        public int? LeyAntilavado { get; set; }
        public int? BajaCambProp { get; set; }
        public int? ComprobarId { get; set; }
        public int? ConstanciaFiscal { get; set; }
        public int? CurpPf { get; set; }
        public int? ComprobantesPago { get; set; }
        public int? IdBanco { get; set; }
        public int? AnticipoSN { get; set; }
        public float? Anticipo { get; set; }
        public int? IdAsesorVenta { get; set; }

        public virtual CAsesores IdAsesorVentaNavigation { get; set; }
        public virtual CBanco IdBancoNavigation { get; set; }
        public virtual CEstados IdEstadoNavigation { get; set; }
        public virtual CMetodoPago IdMetodoPagoNavigation { get; set; }
        public virtual ICollection<TbCarrosTransaccion> TbCarrosTransaccion { get; set; }
    }
}
