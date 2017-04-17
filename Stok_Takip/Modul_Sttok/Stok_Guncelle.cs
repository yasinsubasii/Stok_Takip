using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Stok_Takip.Modul_Sttok
{
    public partial class Stok_Guncelle : DevExpress.XtraEditors.XtraForm
    {
        MayaStokEntities db;
        Urunler urun;
        Stok_Ara stk;
        public Stok_Guncelle(Stok_Ara stkara)
        {
            stk = stkara;
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            urun = db.Urunler.Where(w => w.id == Stok_Ara.stokurun.id).FirstOrDefault();
            urun.Stok_Adi = txturun_adi.Text;
            urun.Stok_Kodu = txtstok_kodu.Text;
            urun.Urun_Turu = txturun_turu.Text;
            urun.Adet = txtadet.Text;
            urun.Genislik = txt_genislik.Text;
            urun.Yukseklik = txt_yukseklik.Text;
            db.SaveChanges();
            stk.gridyenile(urun);
            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            txtstok_kodu.Text = "";
            
            
        }

        private void Stok_Guncelle_Load(object sender, EventArgs e)
        {
            db = new MayaStokEntities();
            urun = new Urunler();
            txtstok_kodu.Text = Stok_Ara.stokurun.Stok_Kodu;
            txturun_adi.Text = Stok_Ara.stokurun.Stok_Adi;
            txturun_turu.Text = Stok_Ara.stokurun.Urun_Turu;
            txtadet.Text = Stok_Ara.stokurun.Adet;
            txt_genislik.Text = Stok_Ara.stokurun.Genislik;
            txt_yukseklik.Text = Stok_Ara.stokurun.Yukseklik;
            
        }
    }
}