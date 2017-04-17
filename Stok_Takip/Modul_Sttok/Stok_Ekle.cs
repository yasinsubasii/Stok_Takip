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
        baglanti bgl = new baglanti();

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

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
            SqlConnection con = bgl.baglantim();
            SqlCommand cmd = new SqlCommand("Stok_Ekle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Stok_Ekle"; //Stored Procedure' ümüzün ismi
            cmd.Parameters.Add("Stok_Kodu", SqlDbType.NVarChar, 50).Value = txtstok_kodu.Text; //Stored procedure deki parametrelere
            cmd.Parameters.Add("Stok_Adi", SqlDbType.NVarChar, 50).Value = combobox_uruncinsi.Text; // textboxlardan değerleri
            cmd.Parameters.Add("Urun_Turu", SqlDbType.NVarChar, 50).Value = txturun_adi.Text.ToUpper(); //alıyoruz.
            cmd.Parameters.Add("Adet", SqlDbType.NVarChar, 50).Value = txtadet.Text; //alıyoruz.
            cmd.Parameters.Add("Genislik", SqlDbType.NVarChar, 50).Value = txt_genislik.Text; //alıyoruz.
            cmd.Parameters.Add("Yukseklik", SqlDbType.NVarChar, 50).Value = txt_yukseklik.Text; //alıyoruz.

            
            cmd.ExecuteNonQuery();
            

        }
    }
}