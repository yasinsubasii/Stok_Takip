﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MayaStokEntities : DbContext
    {
        public MayaStokEntities()
            : base("name=MayaStokEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<HazirUrunler> HazirUrunler { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<Musteri> Musteri { get; set; }
        public virtual DbSet<Personel> Personel { get; set; }
        public virtual DbSet<Siparis> Siparis { get; set; }
        public virtual DbSet<Tur> Tur { get; set; }
        public virtual DbSet<UretimBilgi> UretimBilgi { get; set; }
        public virtual DbSet<Urunler> Urunler { get; set; }
        public virtual DbSet<Üretim_Dikim> Üretim_Dikim { get; set; }
    }
}
