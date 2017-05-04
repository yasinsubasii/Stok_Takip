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
using DevExpress.XtraGrid;
using System.Data.SqlClient;

namespace Stok_Takip.Modul_Sttok
{
    public partial class Stok_Ekle : DevExpress.XtraEditors.XtraForm
    {
        public Stok_Ekle()
        {
            InitializeComponent();
        }
        MayaStokEntities db;
        Urunler stokurun;

        private void Stok_Ekle_Load(object sender, EventArgs e)
        {
            
            db = new MayaStokEntities();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            txtstok_kodu.Text= "";
            txturun_adi.Text = "";
            txt_genislik.Text = "";
            txt_yukseklik.Text = "";
            combobox_uruncinsi.SelectedItem = null;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            stokurun = new Urunler();
            stokurun.Stok_Kodu = txtstok_kodu.Text;
            stokurun.Stok_Adi = combobox_uruncinsi.Text;
            stokurun.Urun_Turu = txturun_adi.Text.ToUpper();
            stokurun.Adet = txtadet.Text;
            stokurun.Genislik = txt_genislik.Text;
            stokurun.Yukseklik = txt_yukseklik.Text;
            db.Urunler.Add(stokurun);
            db.SaveChanges();
            this.Hide();
            MessageBox.Show("Kayıt yapılmıştır");


        }

    }
}