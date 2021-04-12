using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class TbConta
    {
        public int IdConta { get; set; }
        public float? Cantidad { get; set; }
        public int? IdBanco { get; set; }
        public int? CargoAbono { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaTramite { get; set; }

        public virtual CBanco IdBancoNavigation { get; set; }
    }
}
