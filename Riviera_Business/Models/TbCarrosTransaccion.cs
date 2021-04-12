using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class TbCarrosTransaccion
    {
        public int IdCarrosTransaccion { get; set; }
        public int? TipoVenta { get; set; }
        public int? IdControl { get; set; }
        public int? IdCarro { get; set; }
        public int? IdEstado { get; set; }

        public virtual TbCarros IdCarroNavigation { get; set; }
        public virtual TbControl IdControlNavigation { get; set; }
        public virtual CEstados IdEstadoNavigation { get; set; }
    }
}
