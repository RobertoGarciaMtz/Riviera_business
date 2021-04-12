using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class CPreAcondicionamiento
    {
        public int IdPreAcondicionamiento { get; set; }
        public float? Mec { get; set; }
        public float? Refac { get; set; }
        public float? Esteticos { get; set; }
        public float? Hyp { get; set; }
        public float? Trasl { get; set; }
        public int TbCarrosIdCarros { get; set; }

        public virtual TbCarros TbCarrosIdCarrosNavigation { get; set; }
    }
}
