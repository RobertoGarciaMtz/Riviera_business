using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class TbProveedor
    {
        public int IdProveedor { get; set; }
        public string NombreComercial { get; set; }
        public string Contacto { get; set; }
        public string EncargadoCompras { get; set; }
        public string Ubicacion { get; set; }
        public string Correo { get; set; }
        public string GerenteCompras { get; set; }
        public string Coreo { get; set; }
        public string Telefono { get; set; }
        public int? IdEstado { get; set; }

        public virtual CEstados IdEstadoNavigation { get; set; }
    }
}
