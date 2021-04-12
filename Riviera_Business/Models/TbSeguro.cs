using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class TbSeguro
    {
        public int IdSeguro { get; set; }
        public string NombreCliente { get; set; }
        public string Aseguradora { get; set; }
        public int? Version { get; set; }
        public string NumPoliza { get; set; }
        public int? TipoPoliza { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public int? IdAutoPertenece { get; set; }

        public virtual CVersionCarro IdAutoPerteneceNavigation { get; set; }
    }
}
