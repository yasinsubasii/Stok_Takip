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
        baglanti bgl = new baglanti();    
        

        private void dropDownButton1_Click(object sender, EventArgs e)
        {

        }

        

        private void btn_giris_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = bgl.baglantim();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Personel where K_adi='" + K_adi.Text + "' and Sifre='" + Sifre.Text + "' and Yetki='" + combo_Yetki.Text + "'", con);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                SqlDataAdapter sda1 = new SqlDataAdapter("Select Yetki from Personel where K_adi='" + K_adi.Text + "' and Sifre='" + Sifre.Text + "'", con);
                DataTable dt1 = new DataTable();

                sda1.Fill(dt1);
                if (dt1.Rows[0][0].ToString() == "Depo")
                {
                    this.Hide();
                    MessageBox.Show("yapim asamasinda");
                }
                if (dt1.Rows[0][0].ToString() == "Yönetici")
                {
                    this.Hide();
                    MAYA my = new MAYA();
                    my.Show();

                }
            }
            else
            {
                MessageBox.Show("yanlıs giris");
            }
        }
    }
}