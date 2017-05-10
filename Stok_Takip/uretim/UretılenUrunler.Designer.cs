namespace Stok_Takip.uretim
{
    partial class UretılenUrunler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_rezervv = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStok_Kodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStok_Adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrun_Turu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridButton2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_rezerv = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Musid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Urid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_islem = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rezerv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_islem)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_rezervv);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl2);
            this.splitContainer1.Size = new System.Drawing.Size(662, 469);
            this.splitContainer1.SplitterDistance = 53;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_rezervv
            // 
            this.btn_rezervv.Image = global::Stok_Takip.Properties.Resources.k_giris2;
            this.btn_rezervv.Location = new System.Drawing.Point(350, 10);
            this.btn_rezervv.Name = "btn_rezervv";
            this.btn_rezervv.Size = new System.Drawing.Size(85, 35);
            this.btn_rezervv.TabIndex = 20;
            this.btn_rezervv.Text = "Kaydet";
            this.btn_rezervv.Visible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelControl2.Location = new System.Drawing.Point(228, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(106, 19);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Rezerve Sayı";
            this.labelControl2.Visible = false;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textEdit1.Location = new System.Drawing.Point(248, 29);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.textEdit1.Properties.Mask.EditMask = "n0";
            this.textEdit1.Properties.MaxValue = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.textEdit1.Size = new System.Drawing.Size(62, 20);
            this.textEdit1.TabIndex = 18;
            this.textEdit1.Visible = false;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btn_islem,
            this.btn_rezerv});
            this.gridControl2.Size = new System.Drawing.Size(662, 412);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStok_Kodu,
            this.colStok_Adi,
            this.colUrun_Turu,
            this.gridButton2,
            this.Musid,
            this.Urid});
            this.gridView1.GridControl = this.gridControl2;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colStok_Kodu
            // 
            this.colStok_Kodu.Caption = "MÜŞTERİ ADI";
            this.colStok_Kodu.FieldName = "Musteriadi";
            this.colStok_Kodu.Name = "colStok_Kodu";
            this.colStok_Kodu.Visible = true;
            this.colStok_Kodu.VisibleIndex = 0;
            // 
            // colStok_Adi
            // 
            this.colStok_Adi.Caption = "ÜRÜN ADI";
            this.colStok_Adi.FieldName = "Urunadi";
            this.colStok_Adi.Name = "colStok_Adi";
            this.colStok_Adi.Visible = true;
            this.colStok_Adi.VisibleIndex = 1;
            // 
            // colUrun_Turu
            // 
            this.colUrun_Turu.Caption = "ADET";
            this.colUrun_Turu.FieldName = "Adet";
            this.colUrun_Turu.Name = "colUrun_Turu";
            this.colUrun_Turu.Visible = true;
            this.colUrun_Turu.VisibleIndex = 2;
            // 
            // gridButton2
            // 
            this.gridButton2.Caption = "StokButton";
            this.gridButton2.ColumnEdit = this.btn_rezerv;
            this.gridButton2.FieldName = "stok";
            this.gridButton2.Name = "gridButton2";
            this.gridButton2.Visible = true;
            this.gridButton2.VisibleIndex = 3;
            // 
            // btn_rezerv
            // 
            this.btn_rezerv.AutoHeight = false;
            this.btn_rezerv.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::Stok_Takip.Properties.Resources.GİRİS, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "Stok", "Stok", null, true)});
            this.btn_rezerv.Name = "btn_rezerv";
            this.btn_rezerv.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btn_rezerv.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_rezerv_ButtonClick);
            // 
            // Musid
            // 
            this.Musid.Caption = "Musteriid";
            this.Musid.FieldName = "MusteriID";
            this.Musid.Name = "Musid";
            // 
            // Urid
            // 
            this.Urid.Caption = "Urunid";
            this.Urid.FieldName = "UrunID";
            this.Urid.Name = "Urid";
            // 
            // btn_islem
            // 
            this.btn_islem.AutoHeight = false;
            this.btn_islem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::Stok_Takip.Properties.Resources.GÜNCELLE, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "güncelle", "güncelle", null, true)});
            this.btn_islem.Name = "btn_islem";
            this.btn_islem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // UretılenUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 469);
            this.Controls.Add(this.splitContainer1);
            this.Name = "UretılenUrunler";
            this.Text = "UretılenUrunler";
            this.Load += new System.EventHandler(this.UretılenUrunler_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rezerv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_islem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SimpleButton btn_rezervv;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit textEdit1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colStok_Kodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStok_Adi;
        private DevExpress.XtraGrid.Columns.GridColumn colUrun_Turu;
        private DevExpress.XtraGrid.Columns.GridColumn gridButton2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_rezerv;
        private DevExpress.XtraGrid.Columns.GridColumn Musid;
        private DevExpress.XtraGrid.Columns.GridColumn Urid;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_islem;
    }
}