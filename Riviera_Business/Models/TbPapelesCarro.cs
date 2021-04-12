using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class TbPapelesCarro
    {
        public int IdPapelesCarro { get; set; }
        public int? FactOrigen { get; set; }
        public string RefactCompleta { get; set; }
        public string Tenencias4Anos { get; set; }
        public int? Baja { get; set; }
        public int? Verificacion { get; set; }
        public DateTime? FechaUlltimaVerificacion { get; set; }
        public string Repuve { get; set; }
        public string IdEmisor { get; set; }
        public string Transunionfolio { get; set; }
        public string Mes { get; set; }
        public int? IdEstado { get; set; }
        public string Usuario { get; set; }
        public int IdCarro { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual TbCarros IdCarroNavigation { get; set; }
        public virtual CEstados IdEstadoNavigation { get; set; }
    }
}
