using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class TbSeguimiento
    {
        public int IdSeguimiento { get; set; }
        public DateTime? FechaHoraLlegada { get; set; }
        public int IdMedioPublicitario { get; set; }
        public DateTime? FechaHoraAsignacion { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public int? IdAsesor { get; set; }
        public int? TipoVenta { get; set; }
        public int? IdCarro { get; set; }
        public int? AnioAuto { get; set; }
        public int? Contactado { get; set; }
        public int? EnvioInformacion { get; set; }
        public int? AgendoCita { get; set; }
        public int? AsistioCita { get; set; }
        public int? UnidadToma { get; set; }
        public string DejoAutoCuenta { get; set; }
        public int? RealizoPruebaManejo { get; set; }
        public int? IngresoSolicitudSn { get; set; }
        public int? IdIngresoSolicitudBanco { get; set; }
        public int? DejoApartadoEnganche { get; set; }
        public DateTime? FechaVenta { get; set; }
        public DateTime? FechaFacturado { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public string Comentarios { get; set; }
        public string SeguimientoDesc { get; set; }
        public DateTime? FechaSigMovimiento { get; set; }
        public int? IdEstado { get; set; }

        public virtual CAsesores IdAsesorNavigation { get; set; }
        public virtual TbCarros IdCarroNavigation { get; set; }
        public virtual CEstados IdEstadoNavigation { get; set; }
        public virtual CBanco IdIngresoSolicitudBancoNavigation { get; set; }
        public virtual CMedioPublicitario IdMedioPublicitarioNavigation { get; set; }
    }
}
