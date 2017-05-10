using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip.uretim
{
    public partial class Uretim_Makine_Detay : Form
    {
        int id,form;
        Modul_Sttok.MayaStokEntities db = new Modul_Sttok.MayaStokEntities();
        Modul_Sttok.UretimBilgi urt = new Modul_Sttok.UretimBilgi();
        public Uretim_Makine_Detay(int urid,int x)
        {
            InitializeComponent();
            id = urid;
            form = x;
        }

        private void labelControl14_Click(object sender, EventArgs e)
        {

        }

        private void Uretim_Makine_Detay_Load(object sender, EventArgs e)
        {
            urt = db.UretimBilgi.Where(w => w.id == id).FirstOrDefault();
            if (form == 1)
            {
                  VeriDoldur();
            }
            else
            {
                VeriDoldur();
                foreach (Control item in Controls)
                {
                    if(item is DevExpress.XtraEditors.TextEdit)
                    {
                        item.Enabled = true;
                    }
                }

               // VeriKaydet();

            }
        }

        public void VeriDoldur()
        {
            agirlik_txt.Text = urt.Agirlik.ToString();
            birim_urun_biye_txt.Text = urt.BirimUrunBiye.ToString();
            Biye_txt.Text = urt.Biye.ToString();
            BoyKare_txt.Text = urt.BoyKare.ToString();
            Canta_txt.Text = urt.Canta.ToString();
            DisDolgu_txt.Text = urt.DisDolgu.ToString();
            DolguMetaryali_txt.Text = urt.DolguMetaryali.ToString();
            DolguMetrekare_txt.Text = urt.DolguMetrekare.ToString();
            Dolgu_txt.Text = urt.Dolgu.ToString();
            DolumSekli_txt.Text = urt.DolumSekli.ToString();
            DolumYeri_txt.Text = urt.DolumYeri.ToString();
            EnKare_txt.Text = urt.EnKare.ToString();
            Foy_txt.Text = urt.Foy.ToString();
            Genislik_txt.Text = urt.EN.ToString();
            ic_dis_agirlik_txt.Text = urt.ic_dis_koruk.ToString();
            KareSayisi_txt.Text = urt.KareSayisi.ToString();
            KesimOlcutu_txt.Text = urt.KesimOlcutu.ToString();
            kimble_txt.Text = urt.Kımble.ToString();
            koruk_txt.Text = urt.ic_dis_koruk.ToString();
            KoseEtiketi_txt.Text = urt.KoseEtiketi.ToString();
            Kumas_txt.Text = urt.Kumas.ToString();
            MarkaEtiketi_txt.Text = urt.MarkaEtiketi.ToString();
            NomiteEtiket_txt.Text = urt.NomiteEtiket.ToString();
            Paketleme_txt.Text = urt.Paketleme.ToString();
            SERİSİ_TXT.Text = urt.SERİSİ.ToString();
            TozTorbasi_txt.Text = urt.TozTorbasi.ToString();
            Uretimithal_txt.Text = urt.Uretimithal.ToString();
            UrunYikamaEtiketi_txt.Text = urt.UrunYikamaEtiketi.ToString();
            Urun_Ismi_txt.Text = urt.Urun_Ismi.ToString();
            Urun_Kalite_Kodu_txt.Text = urt.Urun_Kalite_Kodu.ToString();
            Urun_txt.Text = urt.Urun.ToString();
            YUKSEKLİK_txt.Text = urt.BOY.ToString();
            İcDolgu_txt.Text = urt.İcDolgu.ToString();
        }

        public void VeriKaydet()
        {
            /*
            urt.Agirlik = Convert.ToDouble(agirlik_txt.Text) ;
            birim_urun_biye_txt.Text = urt.BirimUrunBiye;
            Biye_txt.Text = urt.Biye;
            BoyKare_txt.Text = urt.BoyKare;
            Canta_txt.Text = urt.Canta;
            DisDolgu_txt.Text = urt.DisDolgu;
            DolguMetaryali_txt.Text = urt.DolguMetaryali;
            DolguMetrekare_txt.Text = urt.DolguMetrekare;
            Dolgu_txt.Text = urt.Dolgu;
            DolumSekli_txt.Text = urt.DolumSekli;
            DolumYeri_txt.Text = urt.DolumYeri;
            EnKare_txt.Text = urt.EnKare;
            Foy_txt.Text = urt.Foy;
            Genislik_txt.Text = urt.EN;
            ic_dis_agirlik_txt.Text = urt.ic_dis_koruk;
            KareSayisi_txt.Text = urt.KareSayisi;
            KesimOlcutu_txt.Text = urt.KesimOlcutu;
            kimble_txt.Text = urt.Kımble;
            koruk_txt.Text = urt.ic_dis_koruk;
            KoseEtiketi_txt.Text = urt.KoseEtiketi;
            Kumas_txt.Text = urt.Kumas;
            MarkaEtiketi_txt.Text = urt.MarkaEtiketi;
            NomiteEtiket_txt.Text = urt.NomiteEtiket;
            Paketleme_txt.Text = urt.Paketleme;
            SERİSİ_TXT.Text = urt.SERİSİ;
            TozTorbasi_txt.Text = urt.TozTorbasi;
            Uretimithal_txt.Text = urt.Uretimithal;
            UrunYikamaEtiketi_txt.Text = urt.UrunYikamaEtiketi;
            Urun_Ismi_txt.Text = urt.Urun_Ismi;
            Urun_Kalite_Kodu_txt.Text = urt.Urun_Kalite_Kodu;
            Urun_txt.Text = urt.Urun;
            YUKSEKLİK_txt.Text = urt.BOY;
            İcDolgu_txt.Text = urt.İcDolgu;


            db.UretimBilgi.add(urt);
            db.SaveChanges();
            */

        }
    }
}
