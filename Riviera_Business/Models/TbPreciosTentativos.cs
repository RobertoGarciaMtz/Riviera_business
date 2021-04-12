using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class TbPreciosTentativos
    {
        public int IdPreciosTentativos { get; set; }
        public int? TipoVenta { get; set; }
        public float? Cantidad { get; set; }
        public float? Ub { get; set; }
        public float? Porcentaje { get; set; }
        public int? IdCarro { get; set; }
        public int? Estado { get; set; }

        public virtual CEstados EstadoNavigation { get; set; }
        public virtual TbCarros IdCarroNavigation { get; set; }
    }
}
