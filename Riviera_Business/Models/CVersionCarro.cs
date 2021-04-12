using System;
using System.Collections.Generic;

namespace Riviera_Business.Models
{
    public partial class CVersionCarro
    {
        public CVersionCarro()
        {
            CGuiaAutometricaEbc = new HashSet<CGuiaAutometricaEbc>();
            TbCarros = new HashSet<TbCarros>();
            TbSeguro = new HashSet<TbSeguro>();
        }

        public int IdVersionCarro { get; set; }
        public string VersionCarro { get; set; }
        public string Usuario { get; set; }
        public int IdModelo { get; set; }

        public virtual CModeloCarro IdModeloNavigation { get; set; }
        public virtual ICollection<CGuiaAutometricaEbc> CGuiaAutometricaEbc { get; set; }
        public virtual ICollection<TbCarros> TbCarros { get; set; }
        public virtual ICollection<TbSeguro> TbSeguro { get; set; }
    }
}
