//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stok_Takip.Modul_Sttok
{
    using System;
    using System.Collections.Generic;
    
    public partial class Siparis
    {
        public int SiparisID { get; set; }
        public Nullable<int> MusteriID { get; set; }
        public Nullable<System.DateTime> SiparisTarihi { get; set; }
        public Nullable<System.DateTime> TeslimTarihi { get; set; }
    
        public virtual HazirUrunler HazirUrunler { get; set; }
        public virtual Musteri Musteri { get; set; }
        public virtual Urunler Urunler { get; set; }
        public virtual SiparisDetay SiparisDetay { get; set; }
    }
}