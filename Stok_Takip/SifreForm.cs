using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip
{
    public partial class SifreForm : Form
    {
        public SifreForm()
        {
            InitializeComponent();
        }
        Modul_Sttok.MayaStokEntities db;
        Modul_Sttok.Personel prs;
        private void button1_Click(object sender, EventArgs e)
        {
            db = new Modul_Sttok.MayaStokEntities();
            prs = new Modul_Sttok.Personel();
            prs  = db.Personel.Where(w => w.id == Fonksiyonlar.Rutbe.id).FirstOrDefault();
            if(sifre1txt.Text == sifre2txt.Text)
            {
                prs.Sifre = sifre1txt.Text.ToString();
                db.SaveChanges();
            }
        }
    }
}
