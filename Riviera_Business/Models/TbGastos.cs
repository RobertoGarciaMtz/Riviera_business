using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class TbGastos
    {
        public int IdGastos { get; set; }
        public int IdTipoGasto { get; set; }
        public int? IdCarro { get; set; }
        public float? Monto { get; set; }
        public string Descripcion { get; set; }
        public DateTime? Fecha { get; set; }
        public int? IdEstado { get; set; }
        public string Usuario { get; set; }

        public virtual TbCarros IdCarroNavigation { get; set; }
        public virtual CEstados IdEstadoNavigation { get; set; }
        public virtual CTipoGasto IdTipoGastoNavigation { get; set; }
    }
}
