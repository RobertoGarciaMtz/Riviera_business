using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Riviera_Business.Models
{
    public partial class ZCopiaControlPersonas
    {

        [Key]
        public int IdMovimiento { get; set; }
        public float? Medias { get; set; }
        public string ClienteVenta { get; set; }
        public string VoBoFacturarSat { get; set; }
        public string Usuarios { get; set; }
        public DateTime? FechaActual { get; set; }
        public int? IdCarros { get; set; }
        public int? IdCliente { get; set; }
        public int? TipoVenta { get; set; }
        public float? SubTotal { get; set; }
        public float? Iva { get; set; }
        public float? Total { get; set; }
        public int? Pagada { get; set; }
        public int? CompraVenta { get; set; }
        public int? IdFormaPago { get; set; }
        public string LineaCaptura { get; set; }
        public string MetodoPago { get; set; }
        public string Banco { get; set; }
        public DateTime? FechaES { get; set; }
        public string Factura { get; set; }
        public string Repuve { get; set; }
        public string Isan { get; set; }
        public float? PNeto { get; set; }
        public DateTime? FechaFactura { get; set; }
        public int? IdEstado { get; set; }
        public float? PrecioPactado { get; set; }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///
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
        public string Usuario { get; set; }
        public DateTime? FechaPoderNotorial { get; set; }
        public string NoPoderNotorial { get; set; }
        public string AutoridadEmite { get; set; }

        /*---------------------------------------------------------------------*/
        public int IdDatosPm { get; set; }
        public string DenominacionRazonSocial { get; set; }
        public DateTime? FechaConstitucion { get; set; }
        public string NoActa { get; set; }
        public string FechaRegistroPublicoComercio { get; set; }
        public string NoRegistroPublicoComercio { get; set; }
        
        public string ActividadGiroMercantilObjeto { get; set; }
        
        public string NumInterior { get; set; }
        public string NumExterior { get; set; }
        public string NumTelefono { get; set; }
        public string CorreoElectronico { get; set; }
    }
}
