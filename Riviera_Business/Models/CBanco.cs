using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class CBanco
    {
        public CBanco()
        {
            TbConta = new HashSet<TbConta>();
            TbControl = new HashSet<TbControl>();
            TbMovimientosBancarios = new HashSet<TbMovimientosBancarios>();
            TbSeguimiento = new HashSet<TbSeguimiento>();
        }

        public int IdBanco { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<TbConta> TbConta { get; set; }
        public virtual ICollection<TbControl> TbControl { get; set; }
        public virtual ICollection<TbMovimientosBancarios> TbMovimientosBancarios { get; set; }
        public virtual ICollection<TbSeguimiento> TbSeguimiento { get; set; }
    }
}
