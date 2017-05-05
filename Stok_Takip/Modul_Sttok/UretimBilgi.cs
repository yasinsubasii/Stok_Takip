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
    
    public partial class UretimBilgi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UretimBilgi()
        {
            this.Siparis = new HashSet<Siparis>();
        }
    
        public int id { get; set; }
        public string Urun_Kalite_Kodu { get; set; }
        public string SERİSİ { get; set; }
        public string Uretimithal { get; set; }
        public string DolumYeri { get; set; }
        public string Urun_Ismi { get; set; }
        public Nullable<double> EN { get; set; }
        public Nullable<double> BOY { get; set; }
        public string KÖRÜK { get; set; }
        public string EBAT { get; set; }
        public string EnKare { get; set; }
        public string BoyKare { get; set; }
        public string KareSayisi { get; set; }
        public string ToplamKare { get; set; }
        public string DolumSekli { get; set; }
        public string Biye { get; set; }
        public string Kumas { get; set; }
        public string Dolgu { get; set; }
        public string DolguMetaryali { get; set; }
        public string DolguMetrekare { get; set; }
        public Nullable<double> İcDolgu { get; set; }
        public Nullable<double> DisDolgu { get; set; }
        public Nullable<double> DisDolgu2 { get; set; }
        public Nullable<double> AltDolgu { get; set; }
        public Nullable<double> UstDolgu { get; set; }
        public string DolguAgirligi { get; set; }
        public string KareBasiGramaj { get; set; }
        public string KareBasiGramajAciklama { get; set; }
        public string KesimOlcutu { get; set; }
        public string MarkaEtiketi { get; set; }
        public string NomiteEtiket { get; set; }
        public string UrunYikamaEtiketi { get; set; }
        public string KoseEtiketi { get; set; }
        public string Canta { get; set; }
        public string Urun { get; set; }
        public string Paketleme { get; set; }
        public string TozTorbasi { get; set; }
        public string Foy { get; set; }
        public string Kımble { get; set; }
        public Nullable<double> Agirlik { get; set; }
        public string ic_dis_koruk { get; set; }
        public Nullable<double> BirimUrunBiye { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siparis> Siparis { get; set; }
        public virtual UretimBilgi UretimBilgi1 { get; set; }
        public virtual UretimBilgi UretimBilgi2 { get; set; }
    }
}
