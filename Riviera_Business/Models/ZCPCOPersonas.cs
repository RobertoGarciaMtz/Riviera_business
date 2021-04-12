using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Riviera_Business.Models
{
    public  class ZCPCOPersonas
    {



            public ZCPCOPersonas()
            {


            }

        public int IdCuentaPendiente { get; set; }
        public int? CuentasCobrarPagarOtras { get; set; }
        public string Folio { get; set; }
        public DateTime? Fecha { get; set; }
        public string IdProveedor { get; set; }
        public int? IdCliente { get; set; }
        public int? IdConcepto { get; set; }
        public int? IdCarro { get; set; }
        public int? Anticipo { get; set; }
        public float? Importe { get; set; }
        public string Detalle { get; set; }
        public int? IdEstado { get; set; }

        /*____________________________-------------------------_____________________________________----------*/

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
        public int? IdPmDp { get; set; }
        public string Puesto { get; set; }

        /*--------------_____________________________--------------------_____________________________-----------*/
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
