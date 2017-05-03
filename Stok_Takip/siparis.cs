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
        public siparis()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = bgl.baglantim();
            SqlCommand cmd = new SqlCommand("Siparis_Ekle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Siparis_Ekle"; //Stored Procedure' ümüzün ismi
            cmd.Parameters.Add("SiparisID", SqlDbType.NVarChar, 50).Value = txt_siparis_id.Text;
            cmd.Parameters.Add("MüsteriAdi", SqlDbType.NVarChar, 50).Value = txt_Müsteri_Adi.Text; //Stored procedure deki parametrelere
            cmd.Parameters.Add("UrunAdi", SqlDbType.NVarChar, 50).Value = txt_Urun_Adi.Text;// textboxlardan değerleri           
            cmd.Parameters.Add("Genislik", SqlDbType.NVarChar, 50).Value = txt_Miktar.Text; //alıyoruz.
            cmd.Parameters.Add("Yukseklik", SqlDbType.NVarChar, 50).Value = txt_Genislik.Text; //alıyoruz.
            cmd.Parameters.Add("Adet", SqlDbType.NVarChar, 50).Value = txt_Yukseklik.Text; //alıyoruz.
            cmd.Parameters.Add("TeslimatTarihi", SqlDbType.DateTime).Value = dateTimeTeslimat.Value;


            cmd.ExecuteNonQuery();
            this.Hide();
            MessageBox.Show("Kayıt yapılmıştır");
        }
    }
}