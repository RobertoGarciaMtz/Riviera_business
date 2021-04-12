using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class TbAdecuaciones
    {
        public int IdAdecuaciones { get; set; }
        public DateTime? Fecha { get; set; }
        public int? IdCarro { get; set; }
        public int? LavadoVestiduras { get; set; }
        public string PulidoEncerado { get; set; }
        public string Mecanica { get; set; }
        public int? Lavado { get; set; }
        public string Motor { get; set; }
        public string Traslado { get; set; }
        public string Preparacion { get; set; }
        public string Otros { get; set; }
        public string Usuario { get; set; }

        public virtual TbCarros IdCarroNavigation { get; set; }
    }
}
