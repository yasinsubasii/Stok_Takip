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
        public siparis()
        {
            InitializeComponent();
           
        }
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            spr = new Modul_Sttok.Siparis();
            

       
            this.Hide();
            MessageBox.Show("Kayıt yapılmıştır");
        }

        private void siparis_Load(object sender, EventArgs e)
        {
            db = new Modul_Sttok.MayaStokEntities();
        }
    }
}