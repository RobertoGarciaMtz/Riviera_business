using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class TbMovimientosBancarios
    {
        public int IdTbMovimientosBancarios { get; set; }
        public int? DepositoRetiro { get; set; }
        public DateTime? Fecha { get; set; }
        public string Concepto { get; set; }
        public float? Saldo { get; set; }
        public int? IdBanco { get; set; }

        public virtual CBanco IdBancoNavigation { get; set; }
    }
}
