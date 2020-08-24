//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EVENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EVENTO()
        {
            this.ENTRADA = new HashSet<ENTRADA>();
        }
    
        public int ID_EV { get; set; }
        public string EV_NOMBRE { get; set; }
        public string EV_DESC { get; set; }
        public string EV_INFO { get; set; }
        public Nullable<System.DateTime> EV_FECINICIO { get; set; }
        public Nullable<System.DateTime> EV_FECFIN { get; set; }
        public byte[] EV_IMG { get; set; }
        public byte[] EV_VIDEO { get; set; }
        public byte[] EV_IMGTICKET { get; set; }
        public string EV_DIREC { get; set; }
        public string EV_REF { get; set; }
        public string EV_ENCU { get; set; }
        public int ID_CATEG { get; set; }
        public int ID_USU { get; set; }
        public int ID_CIU { get; set; }
    
        public virtual CATEGORIA CATEGORIA { get; set; }
        public virtual CIUDAD CIUDAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENTRADA> ENTRADA { get; set; }
        public virtual TB_USUARIO TB_USUARIO { get; set; }
    }
}
