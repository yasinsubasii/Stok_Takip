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
using DevExpress.XtraEditors.Repository;

namespace Stok_Takip.Modul_Sttok
{
    public partial class Stok_Ara : DevExpress.XtraEditors.XtraForm
    {
        MayaStokEntities db;
        RepositoryItemButtonEdit riButtonEdit = new RepositoryItemButtonEdit();
        public Stok_Ara()
        {
            InitializeComponent();
        }
        public static Urunler stokurun;
        private void Stok_Ara_Load(object sender, EventArgs e)
        {
            stokurun = new Urunler();
            // TODO: This line of code loads data into the 'mayaStokDataSet.Urunler' table. You can move, or remove it, as needed.
            //this.urunlerTableAdapter.Fill(this.mayaStokDataSet.Urunler);
            db = new MayaStokEntities();

        }
        void ara()
        {
            
            if (txt_stok_ara.Text.Length > 0)
            {
                var stok = db.Urunler.Where(w => w.Stok_Kodu==txt_stok_ara.Text.ToUpper()).ToList();
                stokurun = stok.FirstOrDefault();
                gridControl1.DataSource = stok;
            }
            else if(txt_stok_adi.Text.Length > 0)
            {

                var stok1 = db.Urunler.Where(w => w.Stok_Adi == txt_stok_adi.Text.ToUpper()).ToList();
                stokurun = stok1.FirstOrDefault();
                gridControl1.DataSource = stok1;
                
            }
           
        }
        public void gridyenile(Urunler urunx)
        {

            gridView1.SetFocusedRowCellValue("Stok_Adi", urunx.Stok_Adi);
            gridView1.SetFocusedRowCellValue("Stok_Kodu", urunx.Stok_Kodu);
            gridView1.SetFocusedRowCellValue("Urun_Turu", urunx.Urun_Turu);
            gridView1.SetFocusedRowCellValue("Adet", urunx.Adet);
            gridView1.SetFocusedRowCellValue("Genislik", urunx.Genislik);
            gridView1.SetFocusedRowCellValue("Yukseklik", urunx.Yukseklik);

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            ara();
            
        }

        private void txt_stok_ara_EditValueChanged(object sender, EventArgs e)
        {
            
            txt_stok_adi.Text = "";
            
        }

        private void txt_stok_adi_EditValueChanged(object sender, EventArgs e)
        {

           
            txt_stok_ara.Text="";
            
        }

        

        private void btn_islem_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //txt_stok_ara.Text = gridView1.GetFocusedRowCellValue("id").ToString();
            Modul_Sttok.Stok_Guncelle sg = new Modul_Sttok.Stok_Guncelle(this);
            sg.ShowDialog(this);


        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = null;
            txt_stok_adi.Text = "";
            txt_stok_ara.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var stok3 = db.Urunler.ToList();
            stokurun = stok3.FirstOrDefault();
            gridControl1.DataSource = stok3;
        }
    }
}