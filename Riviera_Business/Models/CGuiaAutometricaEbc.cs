using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class CGuiaAutometricaEbc
    {
        public int IdGuiaAutometrica { get; set; }
        public float? Toma { get; set; }
        public float? Venta { get; set; }
        public float? Media { get; set; }
        public int? GuiaAutometricaEbc { get; set; }
        public int? IdEstado { get; set; }
        public string Usuario { get; set; }
        public DateTime? Fecha { get; set; }
        public int? IdVersion { get; set; }

        public virtual CEstados IdEstadoNavigation { get; set; }
        public virtual CVersionCarro IdVersionNavigation { get; set; }
    }
}
