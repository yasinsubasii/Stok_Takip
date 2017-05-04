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
   
        public Stok_Guncelle(Urunler stokx)
        {   
            urun = stokx;
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
          urun.Adet = (Convert.ToInt32(txtadet.Text) + Convert.ToInt32(txtartir.Text)).ToString();
          db.SaveChanges();
        }


        private void Stok_Guncelle_Load(object sender, EventArgs e)
        {
            txtstok_kodu.Text = urun.Stok_Kodu;
            txturun_adi.Text = urun.Stok_Adi;
            txturun_turu.Text = urun.Urun_Turu;
            txt_genislik.Text = urun.Genislik;
            txt_yukseklik.Text = urun.Yukseklik; 
            txtadet.Text = urun.Adet;
            

            
        }
    }
}