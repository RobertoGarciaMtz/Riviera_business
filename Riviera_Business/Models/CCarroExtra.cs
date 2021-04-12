using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class CCarroExtra
    {
        public int IdCarroExtra { get; set; }
        public int? Manuales { get; set; }
        public int? CarnetServicio { get; set; }
        public int? Duplicado { get; set; }
        public int? LlantaRefaccion { get; set; }
        public int? Herramientas { get; set; }
        public int? Gato { get; set; }
        public int? Antena { get; set; }
        public int? IdEstado { get; set; }
        public string Usuario { get; set; }
        public int? IdCarro { get; set; }

        public virtual TbCarros IdCarroNavigation { get; set; }
        public virtual CEstados IdEstadoNavigation { get; set; }
    }
}
