using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class TbLineaTiempo
    {
        public int IdLineaTiempo { get; set; }
        public int? IdCarro { get; set; }
        public int? IdEstado { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual TbCarros IdCarroNavigation { get; set; }
        public virtual CEstados IdEstadoNavigation { get; set; }
    }
}
