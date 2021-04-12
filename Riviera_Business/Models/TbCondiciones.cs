using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class TbCondiciones
    {
        public int IdCondiciones { get; set; }
        public int? IdCarro { get; set; }
        public int? LlantaDi { get; set; }
        public int? LlantaDd { get; set; }
        public int? LlanraTi { get; set; }
        public int? LlantaTd { get; set; }
        public string Usuario { get; set; }
        public int? IdEstado { get; set; }
        public string Comentarios { get; set; }

        public virtual TbCarros IdCarroNavigation { get; set; }
        public virtual CEstados IdEstadoNavigation { get; set; }
    }
}
