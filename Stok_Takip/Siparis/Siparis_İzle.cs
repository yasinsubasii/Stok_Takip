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
using Stok_Takip.Modul_Sttok;

namespace Stok_Takip.Siparis
{
    public partial class Siparis_İzle : DevExpress.XtraEditors.XtraForm
    {
        public Siparis_İzle()
        {
            InitializeComponent();
        }
        MayaStokEntities db;
        public static SiparisDetay stokurun;
        private void Siparis_İzle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mayaStokDataSet1.SiparisDetay' table. You can move, or remove it, as needed.
            this.siparisDetayTableAdapter.Fill(this.mayaStokDataSet1.SiparisDetay);
            db = new MayaStokEntities();
            var stok = db.SiparisDetay.ToList();           
            grid_siparis_izle.DataSource = stok;
        }
    }
}