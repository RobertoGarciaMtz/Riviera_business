using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class CTipoGasto
    {
        public CTipoGasto()
        {
            TbGastos = new HashSet<TbGastos>();
        }

        public int IdTipoGasto { get; set; }
        public string Descripcion { get; set; }
        public string Usuario { get; set; }

        public virtual ICollection<TbGastos> TbGastos { get; set; }
    }
}
