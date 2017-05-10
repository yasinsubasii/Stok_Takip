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
    public partial class UretılenUrunler : Form
    {
        int urid, musid, uid, sayi;

        private void UretılenUrunler_Load(object sender, EventArgs e)
        {
            var list = db.UretilenUrun.ToList();
            gridControl2.DataSource = list;
            //grid kontrole rezerve sütunu eklenecek
        }

        Modul_Sttok.MayaStokEntities db = new Modul_Sttok.MayaStokEntities();
        public UretılenUrunler()
        {
            InitializeComponent();
        }

        private void btn_rezerv_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            uid = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id"));
            musid = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MusteriID"));
            urid = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "UrunID"));
            labelControl2.Visible = true;
            textEdit1.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Adet").ToString();
            sayi = Convert.ToInt32(textEdit1.Text);
            textEdit1.Visible = true;

            btn_rezervv.Visible = true;
        }
    }
}
