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
       
        
        Modul_Sttok.MayaStokEntities db = new Modul_Sttok.MayaStokEntities();
        public UretimMakina()
        {
            InitializeComponent();
        }
     
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var Makina = db.Siparis.ToList();
            gridControl1.DataSource = Makina;


        }

        private void btn_islem_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
                                
            int urid = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "UrunID")); 
                      
            Uretim_Makine_Detay umd = new Uretim_Makine_Detay(urid);

            umd.ShowDialog(this);
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var urtt = db.Siparis.Where(w => w.Urunadi == comboBoxEdit1.SelectedText).ToList();
            gridControl1.DataSource = urtt;
        }

        private void UretimMakina_Load(object sender, EventArgs e)
        {
            int x = 0;
            var list = db.UretimBilgi.ToList();
            while(x < list.Count)
            {
                comboBoxEdit1.Properties.Items.Add(list[x].Urun_Kalite_Kodu);
                x++;
            }
        }
    }

    
}
