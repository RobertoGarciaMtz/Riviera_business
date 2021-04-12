using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Riviera_Business.Models
{
    public partial class ZCopiaControlExportacion 
    {


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
        /// <summary>
        /// //////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 
        public int IdExportacion { get; set; }
        public string OrdenCompra { get; set; }
        public string NoFactura { get; set; }
        public float? ValorFactura { get; set; }
        
        public int? Cfdi { get; set; }
        public int? Xml { get; set; }
        public int? PedimientoImpOk { get; set; }
        public DateTime? FechaPago { get; set; }
        public float? CfdiFpA { get; set; }
        public DateTime? FechaPromesaEntrega { get; set; }
        public int? CartaPoderId { get; set; }
        public int? Entregada { get; set; }
        public string ObservacionesReclamos { get; set; }
        public DateTime? SalidaAgencia { get; set; }
        public int? IdPersona { get; set; }



        ////////////////////////////////////////////////////////7
        ///

    }
    }

