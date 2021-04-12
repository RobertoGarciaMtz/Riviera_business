using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class CModeloCarro
    {
        public CModeloCarro()
        {
            CVersionCarro = new HashSet<CVersionCarro>();
        }

        public int IdModeloCarro { get; set; }
        public string ModeloCarro { get; set; }
        public string Usuario { get; set; }
        public int IdMarca { get; set; }

        public virtual CMarcaCarro IdMarcaNavigation { get; set; }
        public virtual ICollection<CVersionCarro> CVersionCarro { get; set; }
    }
}
