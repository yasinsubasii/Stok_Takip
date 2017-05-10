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

        int urid,musid,uid,sayi;
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
                                
            urid = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "UrunID")); 
                      
            Uretim_Makine_Detay umd = new Uretim_Makine_Detay(urid,1);

            umd.ShowDialog(this);
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var urtt = db.Siparis.Where(w => w.DolumYeri == comboBoxEdit1.SelectedText).ToList();
            gridControl1.DataSource = urtt;
        }

        private void UretimMakina_Load(object sender, EventArgs e)
        {
            int x = 0;
            var list = db.UretimBilgi.Select(w=> w.DolumYeri).Distinct().ToList();
            while(x < list.Count)
            {
                comboBoxEdit1.Properties.Items.Add(list[x].ToString());
                x++;
            }
        }
        
        private void btn_stok_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
            uid = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id"));
            musid = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MusteriID"));
            urid = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "UrunID"));
            labelControl2.Visible = true;
            textEdit1.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Adet").ToString();
            sayi = Convert.ToInt32(textEdit1.Text);
            textEdit1.Visible = true;
            
            simpleButton2.Visible = true;
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            if(Convert.ToInt32(textEdit1.Text) < sayi) { 
            var urt = db.Siparis.Where(w => w.id == uid).FirstOrDefault();
            var urt2 = db.UretilenUrun.Where(w => w.UrunID == urid && w.MusteriID == musid).FirstOrDefault();                    
            urt.Adet -= Convert.ToInt32(textEdit1.Text);
            urt2.Adet += Convert.ToInt32(textEdit1.Text);
            db.SaveChanges();
            labelControl2.Visible = false;
            textEdit1.Visible = false;
            simpleButton2.Visible = false;
            simpleButton1.PerformClick();
            }
            else
            {
                MessageBox.Show("Max Adet : " + sayi + " olmalıdır.");
            }
        }
    }

    
}
