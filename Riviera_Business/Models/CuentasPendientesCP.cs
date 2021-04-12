using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class CuentasPendientesCP
    {
        public int IdCuentaPendiente { get; set; }
        public int? CuentasCobrarPagarOtras { get; set; }
        public string Folio { get; set; }
        public DateTime? Fecha { get; set; }
        public string IdProveedor { get; set; }
        public int? IdCliente { get; set; }
        public int? IdConcepto { get; set; }
        public int? IdCarro { get; set; }
        public int? Anticipo { get; set; }
        public float? Importe { get; set; }
        public string Detalle { get; set; }
        public int? IdEstado { get; set; }

        public virtual TbCarros IdCarroNavigation { get; set; }
        public virtual CConcepto IdConceptoNavigation { get; set; }
        public virtual CEstados IdEstadoNavigation { get; set; }
    }
}
