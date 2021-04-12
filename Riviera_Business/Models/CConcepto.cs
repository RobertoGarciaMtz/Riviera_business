using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class CConcepto
    {
        public CConcepto()
        {
            CuentasPendientesCP = new HashSet<CuentasPendientesCP>();
        }

        public int IdCConcepto { get; set; }
        public string DescripcionConcepto { get; set; }

        public virtual ICollection<CuentasPendientesCP> CuentasPendientesCP { get; set; }
    }
}
