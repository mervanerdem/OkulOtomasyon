//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OkulOtomasyon
{
    using System;
    using System.Collections.Generic;
    
    public partial class Veliler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Veliler()
        {
            this.Students = new HashSet<Students>();
        }
    
        public int VeliID { get; set; }
        public string VeliAnne { get; set; }
        public string VeliBaba { get; set; }
        public string VeliTel1 { get; set; }
        public string VeliTel2 { get; set; }
        public string VeliMail { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Students> Students { get; set; }
    }
}
