using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Stok_Takip
{
    public partial class MAYA : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MAYA()
        {
            InitializeComponent();
        }

        private void btnStok_arama_ItemClick(object sender, ItemClickEventArgs e)
        {
            Modul_Sttok.Stok_Ara sa = new Modul_Sttok.Stok_Ara();
            sa.ShowDialog();

        }

        private void btnStok_ekle_ItemClick(object sender, ItemClickEventArgs e)
        {
            Modul_Sttok.Stok_Ekle se = new Modul_Sttok.Stok_Ekle();
            se.ShowDialog();
        }
    }
}