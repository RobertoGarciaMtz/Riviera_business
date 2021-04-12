using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class Usuarios
    {
        public int IdUsuarios { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public int? IdEstado { get; set; }
        public int? TipoUsuario { get; set; }
        public int? Primeravez { get; set; }

        public virtual CEstados IdEstadoNavigation { get; set; }
    }
}
