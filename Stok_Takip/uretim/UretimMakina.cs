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
    
    public partial class UretimMakina : Form
    {
        List<Makina> makinalist = new List<Makina>();
        Makina makina;
        Modul_Sttok.MayaStokEntities db = new Modul_Sttok.MayaStokEntities();
        public UretimMakina()
        {
            InitializeComponent();
        }
        int i;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            i = 0;
            var uretim = db.Siparis.ToList();
            
            while(i< uretim.Count)
            {
                makina = new Makina();
                makina.urunid = Convert.ToInt32(uretim[i].UrunID);
                makina.musteriid = Convert.ToInt32(uretim[i].MusteriID);
                makina.Musteriadi = uretim[i].Musteri.Adi;
                makina.Urunadi = uretim[i].UretimBilgi.Urun_Kalite_Kodu;
                makina.adet = Convert.ToInt32(uretim[i].Adet);
                makina.genislik = Convert.ToDouble(uretim[i].UretimBilgi.EN);
                makina.yukseklik = Convert.ToDouble(uretim[i].UretimBilgi.BOY);
                makina.teslimtarihi = Convert.ToDateTime(uretim[i].SiparisTarihi);
                makinalist.Add(makina);
        
                i++;
            }
            gridControl1.DataSource = makinalist;

            
        }
        public class Makina
        {
           public string Musteriadi, Urunadi;
           public int musteriid, urunid, adet;
           public double genislik, yukseklik;
           public DateTime teslimtarihi;
        }
    }

    
}
