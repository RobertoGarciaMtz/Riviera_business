using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Riviera_Business.Models
{

        public partial class ZCopiaCarrosProveedor
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
            ///public virtual ZCopiaControlPersonas persona { get; set; }

           

        public int IdDatosPm { get; set; }
        public string DenominacionRazonSocial { get; set; }
        public DateTime? FechaConstitucion { get; set; }
        public string NoActa { get; set; }
        public string FechaRegistroPublicoComercio { get; set; }
        public string NoRegistroPublicoComercio { get; set; }
        public string Nacionalidad { get; set; }
        public string ActividadGiroMercantilObjeto { get; set; }
        public string NombreCalle { get; set; }
        public string NumInterior { get; set; }
        public string NumExterior { get; set; }
        public string Colonia { get; set; }
        public string Cd { get; set; }
        public string Estado { get; set; }
        public string Cp { get; set; }
        public string NumTelefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string Rfc { get; set; }

        
        }
    }

