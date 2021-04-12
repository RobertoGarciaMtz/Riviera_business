using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Riviera_Business.Models
{
    public class ZMMVCarro
    {

        public ZMMVCarro()
        {

            
        }
        [Key]
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


        public int IdVersionCarro { get; set; }
        public string VersionCarro { get; set; }
        public int IdModelo { get; set; }

 

        public int IdModeloCarro { get; set; }
        public string ModeloCarro { get; set; }
        public int IdMarca { get; set; }


        public int IdMarcaCarro { get; set; }
        public string NombreMarca { get; set; }

    }
}
