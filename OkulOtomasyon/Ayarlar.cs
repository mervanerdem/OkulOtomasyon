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
    
    public partial class Ayarlar
    {
        public int AyarlarID { get; set; }
        public string OgretSifre { get; set; }
    
        public virtual Teachers Teachers { get; set; }
    }
}
