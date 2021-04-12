using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class CAsesores
    {
        public CAsesores()
        {
            TbControl = new HashSet<TbControl>();
            TbSeguimiento = new HashSet<TbSeguimiento>();
        }

        public int IdAsesores { get; set; }
        public string Nombre { get; set; }
        public int? IdEstado { get; set; }
        public int? TipoVenta { get; set; }

        public virtual CEstados IdEstadoNavigation { get; set; }
        public virtual ICollection<TbControl> TbControl { get; set; }
        public virtual ICollection<TbSeguimiento> TbSeguimiento { get; set; }
    }
}
