using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Riviera_Business.Models
{
    
        public partial class ZCopiaCarrosPF
        {

            public int IdCarros { get; set; }
            public int? IdProveedor { get; set; }
            public int? TipoCompraCanal { get; set; }
            public int? Kms { get; set; }
            public string FolioFiscal { get; set; }
            public DateTime? FechaFactToma { get; set; }
            public int? Antiguedad { get; set; }
            public int? Modelo { get; set; }
            public string ColorExt { get; set; }
            public string ColorInt { get; set; }
            public string NoSerie { get; set; }
            public string NoMotor { get; set; }
            public string NumEconomicoOpc { get; set; }
            public string MvaOpc { get; set; }
            public int? Transmicion { get; set; }
            public string ClaveVehicular { get; set; }
            public int? IdEstado { get; set; }
            public string Usuario { get; set; }
            public int IdVersion { get; set; }
            public int? DuenoAnterior { get; set; }
            public string Origen { get; set; }
            public string Ubicacion { get; set; }
            public float? PropuestaCliente { get; set; }
            public DateTime? FechaOferta { get; set; }

            //No es este pero es un ejemplo
            //public virtual ZCopiaControlPersonas persona { get; set; }

           
            public int IdDatosPersona { get; set; }
            public string Nombre { get; set; }
            public string ApellidoPaterno { get; set; }
            public string ApellidoMaterno { get; set; }
            public DateTime? FechaNacimiento { get; set; }
            public string Nacionalidad { get; set; }
            public string ActividadUOcupacion { get; set; }
            public string NombreCalle { get; set; }
            public string NoInterior { get; set; }
            public string NoExterior { get; set; }
            public string Colonia { get; set; }
            public string Cd { get; set; }
            public string Estado { get; set; }
            public string Cp { get; set; }
            public string Curp { get; set; }
            public string Rfc { get; set; }
            public string NumeroTelefono { get; set; }
            public int? FisicaOMoral { get; set; }

            public DateTime? FechaPoderNotorial { get; set; }
            public string NoPoderNotorial { get; set; }
            public string AutoridadEmite { get; set; }
            public int? IdPmDp { get; set; }
            public string Puesto { get; set; }

           
        }
}

