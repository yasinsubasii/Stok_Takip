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
using System.Data.SqlClient;
using System.Management;

namespace Stok_Takip
{
    public partial class Giris : DevExpress.XtraEditors.XtraForm
    {
        public Giris()
        {
            InitializeComponent();
        }
        Modul_Sttok.MayaStokEntities db;
        Modul_Sttok.Personel prs;

        

        private void dropDownButton1_Click(object sender, EventArgs e)
        {

        }

        

        private void btn_giris_Click(object sender, EventArgs e)
        {
            var stok = db.Personel.Where(w => w.AdiSoyadi == K_adi.Text.ToString() && w.Sifre == Sifre.Text.ToString()).ToList();
            prs = stok.FirstOrDefault();
            if(prs != null)
            {
                if(prs.Yetki == "Depo")
                {
                    Fonksiyonlar.Rutbe.rutbe = "Depo";
                    Acilis_Menu.baslangic my = new Acilis_Menu.baslangic();
                    my.Show();
                }
                else if (prs.Yetki == "Yönetici")
                {
                    Fonksiyonlar.Rutbe.rutbe = "Yönetici";
                    Acilis_Menu.baslangic my = new Acilis_Menu.baslangic();
                    my.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!!");
                }
            }

        }

        private void Giris_Load(object sender, EventArgs e)
        {
            db = new Modul_Sttok.MayaStokEntities();
            prs = new Modul_Sttok.Personel();

        }
    }
}