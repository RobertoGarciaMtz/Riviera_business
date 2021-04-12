using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class CEstados
    {
        public CEstados()
        {
            CAsesores = new HashSet<CAsesores>();
            CCarroExtra = new HashSet<CCarroExtra>();
            CGuiaAutometricaEbc = new HashSet<CGuiaAutometricaEbc>();
            CMedioPublicitario = new HashSet<CMedioPublicitario>();
            CMetodoPago = new HashSet<CMetodoPago>();
            CuentasPendientesCP = new HashSet<CuentasPendientesCP>();
            TbCarros = new HashSet<TbCarros>();
            TbCarrosTransaccion = new HashSet<TbCarrosTransaccion>();
            TbCondiciones = new HashSet<TbCondiciones>();
            TbControl = new HashSet<TbControl>();
            TbDatosPersona = new HashSet<TbDatosPersona>();
            TbDatosPersonaMoral = new HashSet<TbDatosPersonaMoral>();
            TbDocumentacion = new HashSet<TbDocumentacion>();
            TbExportacion = new HashSet<TbExportacion>();
            TbGastos = new HashSet<TbGastos>();
            TbLineaTiempo = new HashSet<TbLineaTiempo>();
            TbPapelesCarro = new HashSet<TbPapelesCarro>();
            TbPreciosTentativos = new HashSet<TbPreciosTentativos>();
            TbProveedor = new HashSet<TbProveedor>();
            TbSeguimiento = new HashSet<TbSeguimiento>();
            Usuarios = new HashSet<Usuarios>();
        }

        public int IdEstados { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<CAsesores> CAsesores { get; set; }
        public virtual ICollection<CCarroExtra> CCarroExtra { get; set; }
        public virtual ICollection<CGuiaAutometricaEbc> CGuiaAutometricaEbc { get; set; }
        public virtual ICollection<CMedioPublicitario> CMedioPublicitario { get; set; }
        public virtual ICollection<CMetodoPago> CMetodoPago { get; set; }
        public virtual ICollection<CuentasPendientesCP> CuentasPendientesCP { get; set; }
        public virtual ICollection<TbCarros> TbCarros { get; set; }
        public virtual ICollection<TbCarrosTransaccion> TbCarrosTransaccion { get; set; }
        public virtual ICollection<TbCondiciones> TbCondiciones { get; set; }
        public virtual ICollection<TbControl> TbControl { get; set; }
        public virtual ICollection<TbDatosPersona> TbDatosPersona { get; set; }
        public virtual ICollection<TbDatosPersonaMoral> TbDatosPersonaMoral { get; set; }
        public virtual ICollection<TbDocumentacion> TbDocumentacion { get; set; }
        public virtual ICollection<TbExportacion> TbExportacion { get; set; }
        public virtual ICollection<TbGastos> TbGastos { get; set; }
        public virtual ICollection<TbLineaTiempo> TbLineaTiempo { get; set; }
        public virtual ICollection<TbPapelesCarro> TbPapelesCarro { get; set; }
        public virtual ICollection<TbPreciosTentativos> TbPreciosTentativos { get; set; }
        public virtual ICollection<TbProveedor> TbProveedor { get; set; }
        public virtual ICollection<TbSeguimiento> TbSeguimiento { get; set; }
        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
