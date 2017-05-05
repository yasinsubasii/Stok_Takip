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

namespace Stok_Takip
{
    public partial class siparis : DevExpress.XtraEditors.XtraForm
    {
        Modul_Sttok.MayaStokEntities db;
        Modul_Sttok.Siparis spr;
        Modul_Sttok.Musteri mst;
        Modul_Sttok.UretimBilgi urt;
        public siparis()
        {
            InitializeComponent();
           
        }
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int idm = txt_Müsteri_Adi.SelectedIndex;
            int idu = txt_Urun_Adi.SelectedIndex;

            spr = new Modul_Sttok.Siparis();
            spr.MusteriID = musteriid[idm];
            spr.UrunID = Urunid[idu];
            spr.Siparis_Kodu = "KD_" + Urunid[idu].ToString();
            spr.TeslimTarihi = Convert.ToDateTime(dateTimeTeslimat.Text);
            spr.SiparisTarihi = DateTime.Today;
            db.Siparis.Add(spr);
            db.SaveChanges();
            this.Hide();
            MessageBox.Show("Kayıt yapılmıştır");
        }
        List<int> musteriid,Urunid;
        int i;

        private void txt_Urun_Adi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = txt_Urun_Adi.SelectedIndex;
            txt_Genislik.Text = uretim[id].EN.ToString();
            txt_Yukseklik.Text = uretim[id].BOY.ToString();

        }
        List<Modul_Sttok.Musteri> musteri;
        List<Modul_Sttok.UretimBilgi> uretim;

        private void siparis_Load(object sender, EventArgs e)
        {
            db = new Modul_Sttok.MayaStokEntities();
            mst = new Modul_Sttok.Musteri();
            urt = new Modul_Sttok.UretimBilgi();

            musteriid = new List<int>();
            Urunid = new List<int>();

            musteri = db.Musteri.ToList();
            uretim = db.UretimBilgi.ToList();
            mst = musteri.FirstOrDefault();
            urt = uretim.FirstOrDefault();

            i = 0;
            
            
            while(i != musteri.Count()){
                mst = musteri[i];
                txt_Müsteri_Adi.Properties.Items.Add(mst.Adi);
                musteriid.Add(mst.id);
                i++;
            }

            i = 0;
            while (i != uretim.Count())
            {
                urt = uretim[i];
                txt_Urun_Adi.Properties.Items.Add(urt.Urun_Kalite_Kodu);
                Urunid.Add(urt.id);
                i++;
            }



        }
    }
}