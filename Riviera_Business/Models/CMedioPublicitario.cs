using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class CMedioPublicitario
    {
        public CMedioPublicitario()
        {
            TbSeguimiento = new HashSet<TbSeguimiento>();
        }

        public int IdMedioPublicitario { get; set; }
        public string Nombre { get; set; }
        public int? IdEstado { get; set; }

        public virtual CEstados IdEstadoNavigation { get; set; }
        public virtual ICollection<TbSeguimiento> TbSeguimiento { get; set; }
    }
}
