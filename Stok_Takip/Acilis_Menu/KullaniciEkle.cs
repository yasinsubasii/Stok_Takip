using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip.Acilis_Menu
{
    public partial class KullaniciEkle : Form
    {
        Modul_Sttok.MayaStokEntities db = new Modul_Sttok.MayaStokEntities();
        Modul_Sttok.Personel prs = new Modul_Sttok.Personel();

        public KullaniciEkle()
        {
            InitializeComponent();
        }

        private void ButGonder_Click(object sender, EventArgs e)
        {
            prs.AdiSoyadi = TxtAd.ToString();
            prs.K_adi = TxtKu.ToString();
            prs.Sifre = TxtSif.ToString();
            prs.Yetki = TxtRutbe.SelectedText.ToString();
            this.Close();
        }
    }
}
