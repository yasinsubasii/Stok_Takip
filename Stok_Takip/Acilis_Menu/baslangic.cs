 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using System.Data.SqlClient;
using System.IO;
using Stok_Takip.Modul_Sttok;

namespace Stok_Takip.Acilis_Menu
{
    
    

    public partial class baslangic : Form
    {

        Modul_Sttok.MayaStokEntities db = new Modul_Sttok.MayaStokEntities();
        public baslangic()
        {
            InitializeComponent();
        }
        string resimPath;
        baglanti bgl = new baglanti();
        
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Modul_Sttok.Stok_Ara sa = new Modul_Sttok.Stok_Ara();
            sa.ShowDialog(this);
        }

        private void btnStok_arama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modul_Sttok.Stok_Ara sa = new Modul_Sttok.Stok_Ara();
            sa.ShowDialog();
        }

        private void btnStok_ekle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modul_Sttok.Stok_Ekle se = new Modul_Sttok.Stok_Ekle();
            se.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            siparis sprs = new siparis();
            sprs.ShowDialog();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Aç";

            openFileDialog1.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Gif Dosyası (*.gif)|*.gif|Png Dosyası (*.png)|*.png|Tif Dosyası (*.tif)|*.tif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {//www.gorselprogramlama.com

                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

                resimPath = openFileDialog1.FileName.ToString();
                FileStream fs = new FileStream(resimPath, FileMode.Open, FileAccess.Read);

                //BinaryReader ile byte dizisi ile FileStream arasında veri akışı sağlanıyor.

                BinaryReader br = new BinaryReader(fs);

                /*ReadBytes ile FileStreamde belirtilen resim dosyasındaki byte lar

                byte dizisine aktarılıyor.

                */

                byte[] resim = br.ReadBytes((int)fs.Length);

                br.Close();

                fs.Close();

                //Sql Veritabanı ve Kayıt işlemleri

                SqlConnection bag = bgl.baglantim();

                SqlCommand kmt1 = new SqlCommand("UPDATE Personel SET resim=@image WHERE Yetki='Yönetici'", bag);

                kmt1.Parameters.Add("@image", SqlDbType.Image, resim.Length).Value = resim;


                kmt1.ExecuteNonQuery();

                MessageBox.Show(" Resim Güncellenmiştir");
                bag.Close();


            }






        }

        

        private void baslangic_Load(object sender, EventArgs e)
        {
           if(Fonksiyonlar.Rutbe.rutbe == "Depo")
            {
                btnStok_ekle.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                ribbonPage1.Visible = false;
                ribbonPage2.Visible = false;
                ribbonPage3.Visible = false;
                simpleButton2.Visible = false;
            }


            SqlConnection bag = bgl.baglantim();
            SqlCommand kmt1 = new SqlCommand("select resim from Personel where Yetki='Yönetici'", bag);
            SqlCommand kmt2 = new SqlCommand("select AdiSoyadi from Personel where Yetki='Yönetici'", bag);
            var da = new SqlDataAdapter(kmt1);
            var ds = new DataSet();
            da.Fill(ds, "Personel");
            int count = ds.Tables["Personel"].Rows.Count;

            if (count > 0)
            {
                var data = (Byte[])(ds.Tables["Personel"].Rows[count - 1]["resim"]);
                var stream = new MemoryStream(data);
                pictureBox1.Image = Image.FromStream(stream);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            SqlDataReader dr = kmt2.ExecuteReader();
            if (dr.Read())
            {
                k_adi.Text = dr["AdiSoyadi"].ToString();
            }
            bag.Close();


            var mesajlar = db.Mesaj.Where(w => w.Gonderenid == Fonksiyonlar.Rutbe.id).ToList();
            gridControl1.DataSource = mesajlar;
            var mesajlar2 = db.Mesaj.Where(w => w.Alanid == Fonksiyonlar.Rutbe.id).ToList();
            gridControl2.DataSource = mesajlar2;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SifreForm sf = new SifreForm();
            sf.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Siparis.Siparis_Durum spd = new Siparis.Siparis_Durum();
            spd.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            uretim.UretimMakina urt = new uretim.UretimMakina();
            urt.Show();
        }

        private void ButGonder_Click(object sender, EventArgs e)
        {
            var personel = db.Personel.Where(w => w.id == Fonksiyonlar.Rutbe.id).FirstOrDefault();
            Modul_Sttok.Mesaj msj = new Modul_Sttok.Mesaj();
            int sayac = TxtKul.SelectedIndex;
            msj.Gonderenid = Fonksiyonlar.Rutbe.id;           
            msj.Alanid = idlist[sayac];
            msj.Gonderenadi = personel.AdiSoyadi;
            msj.Alanadi = TxtKul.SelectedText;
            msj.Text = TxtMesaj.Text;
            db.Mesaj.Add(msj);
            db.SaveChanges();
            MessageBox.Show("Mesaj Gönderildi");
        }
        List<int> idlist;
        private void TxtRutbe_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kullanici = db.Personel.Where(w => w.Yetki == TxtRutbe.SelectedText).ToList();
            idlist = new List<int>();
            TxtKul.Properties.Items.Clear();
            idlist.Clear();           
            int x = 0;
            while(x < kullanici.Count())
            {
                TxtKul.Properties.Items.Add(kullanici[x].AdiSoyadi);
                idlist.Add(kullanici[x].id);
                x++;
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            KullaniciEkle kek = new KullaniciEkle();
            kek.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            uretim.UretılenUrunler urtu = new uretim.UretılenUrunler();
            urtu.Show();
        }
    }
}
