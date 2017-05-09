namespace Stok_Takip.uretim
{
    partial class UretimMakina
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStok_Kodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStok_Adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrun_Turu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYukseklik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridButon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_islem = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridButton2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_stok = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Musid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Urid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_islem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_stok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.simpleButton2);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxEdit1);
            this.splitContainer1.Panel1.Controls.Add(this.simpleButton1);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1139, 679);
            this.splitContainer1.SplitterDistance = 80;
            this.splitContainer1.TabIndex = 0;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(169, 30);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(206, 20);
            this.comboBoxEdit1.TabIndex = 14;
            this.comboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::Stok_Takip.Properties.Resources.k_giris2;
            this.simpleButton1.Location = new System.Drawing.Point(444, 20);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(128, 39);
            this.simpleButton1.TabIndex = 13;
            this.simpleButton1.Text = "GETİR";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelControl1.Location = new System.Drawing.Point(40, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(104, 19);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "MAKİNA ADI";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btn_islem,
            this.btn_stok});
            this.gridControl1.Size = new System.Drawing.Size(1139, 595);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.colYukseklik,
            this.gridButon,
            this.gridButton2,
            this.Musid,
            this.Urid});
            this.gridView1.GridControl = this.gridControl1;
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
            // colYukseklik
            // 
            this.colYukseklik.Caption = "TESLİM TARİHİ";
            this.colYukseklik.FieldName = "TeslimTarihi";
            this.colYukseklik.Name = "colYukseklik";
            this.colYukseklik.Visible = true;
            this.colYukseklik.VisibleIndex = 3;
            // 
            // gridButon
            // 
            this.gridButon.Caption = "Button";
            this.gridButon.ColumnEdit = this.btn_islem;
            this.gridButon.FieldName = "goster";
            this.gridButon.Name = "gridButon";
            this.gridButon.Visible = true;
            this.gridButon.VisibleIndex = 4;
            // 
            // btn_islem
            // 
            this.btn_islem.AutoHeight = false;
            this.btn_islem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::Stok_Takip.Properties.Resources.GÜNCELLE, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "güncelle", "güncelle", null, true)});
            this.btn_islem.Name = "btn_islem";
            this.btn_islem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btn_islem.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_islem_ButtonClick);
            // 
            // gridButton2
            // 
            this.gridButton2.Caption = "StokButton";
            this.gridButton2.ColumnEdit = this.btn_stok;
            this.gridButton2.FieldName = "stok";
            this.gridButton2.Name = "gridButton2";
            this.gridButton2.Visible = true;
            this.gridButton2.VisibleIndex = 5;
            // 
            // btn_stok
            // 
            this.btn_stok.AutoHeight = false;
            this.btn_stok.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::Stok_Takip.Properties.Resources.GİRİS, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "Stok", "Stok", null, true)});
            this.btn_stok.Name = "btn_stok";
            this.btn_stok.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btn_stok.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_stok_ButtonClick);
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
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelControl2.Location = new System.Drawing.Point(886, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(105, 19);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Üretilen Sayı";
            this.labelControl2.Visible = false;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textEdit1.Location = new System.Drawing.Point(906, 39);
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
            this.textEdit1.TabIndex = 15;
            this.textEdit1.Visible = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::Stok_Takip.Properties.Resources.k_giris2;
            this.simpleButton2.Location = new System.Drawing.Point(1008, 20);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(85, 35);
            this.simpleButton2.TabIndex = 17;
            this.simpleButton2.Text = "Kaydet";
            this.simpleButton2.Visible = false;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // UretimMakina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 679);
            this.Controls.Add(this.splitContainer1);
            this.Name = "UretimMakina";
            this.Text = "UretimMakina";
            this.Load += new System.EventHandler(this.UretimMakina_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_islem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_stok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colStok_Kodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStok_Adi;
        private DevExpress.XtraGrid.Columns.GridColumn colUrun_Turu;
        private DevExpress.XtraGrid.Columns.GridColumn colYukseklik;
        private DevExpress.XtraGrid.Columns.GridColumn gridButon;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_islem;
        private DevExpress.XtraGrid.Columns.GridColumn Musid;
        private DevExpress.XtraGrid.Columns.GridColumn Urid;
        private DevExpress.XtraGrid.Columns.GridColumn gridButton2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_stok;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit textEdit1;
    }
}