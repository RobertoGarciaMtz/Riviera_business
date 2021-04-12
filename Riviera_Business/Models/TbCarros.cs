using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class TbCarros
    {
        public TbCarros()
        {
            CCarroExtra = new HashSet<CCarroExtra>();
            CPreAcondicionamiento = new HashSet<CPreAcondicionamiento>();
            CuentasPendientesCP = new HashSet<CuentasPendientesCP>();
            TbAdecuaciones = new HashSet<TbAdecuaciones>();
            TbCarrosTransaccion = new HashSet<TbCarrosTransaccion>();
            TbCondiciones = new HashSet<TbCondiciones>();
            TbGastos = new HashSet<TbGastos>();
            TbLineaTiempo = new HashSet<TbLineaTiempo>();
            TbPapelesCarro = new HashSet<TbPapelesCarro>();
            TbPreciosTentativos = new HashSet<TbPreciosTentativos>();
            TbSeguimiento = new HashSet<TbSeguimiento>();
        }

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
        public int? Transmision { get; set; }
        public string ClaveVehicular { get; set; }
        public int? IdEstado { get; set; }
        public string Usuario { get; set; }
        public int IdVersion { get; set; }
        public int? DuenoAnterior { get; set; }
        public string Origen { get; set; }
        public string Ubicacion { get; set; }
        public float? PropuestaCliente { get; set; }
        public DateTime? FechaOferta { get; set; }

        public virtual CEstados IdEstadoNavigation { get; set; }
        public virtual CVersionCarro IdVersionNavigation { get; set; }
        public virtual ICollection<CCarroExtra> CCarroExtra { get; set; }
        public virtual ICollection<CPreAcondicionamiento> CPreAcondicionamiento { get; set; }
        public virtual ICollection<CuentasPendientesCP> CuentasPendientesCP { get; set; }
        public virtual ICollection<TbAdecuaciones> TbAdecuaciones { get; set; }
        public virtual ICollection<TbCarrosTransaccion> TbCarrosTransaccion { get; set; }
        public virtual ICollection<TbCondiciones> TbCondiciones { get; set; }
        public virtual ICollection<TbGastos> TbGastos { get; set; }
        public virtual ICollection<TbLineaTiempo> TbLineaTiempo { get; set; }
        public virtual ICollection<TbPapelesCarro> TbPapelesCarro { get; set; }
        public virtual ICollection<TbPreciosTentativos> TbPreciosTentativos { get; set; }
        public virtual ICollection<TbSeguimiento> TbSeguimiento { get; set; }
    }
}
