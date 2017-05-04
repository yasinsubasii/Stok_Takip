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
        }
    }
}
