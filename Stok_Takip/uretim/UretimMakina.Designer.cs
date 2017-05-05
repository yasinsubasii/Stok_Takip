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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStok_Kodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStok_Adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrun_Turu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenislik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYukseklik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridButon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_islem = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxEdit1);
            this.splitContainer1.Panel1.Controls.Add(this.simpleButton1);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
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
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "YASTIK MAKİNASI",
            "YORGAN MAKİNASI",
            "JARUSSİ/VAKUM1",
            "VAKUM 2",
            "İTHAL",
            "HAUSER / MAMUT"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(206, 20);
            this.comboBoxEdit1.TabIndex = 14;
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
            this.btn_islem});
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
            this.colAdet,
            this.colGenislik,
            this.colYukseklik,
            this.gridButon});
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
            this.colUrun_Turu.FieldName = "adet";
            this.colUrun_Turu.Name = "colUrun_Turu";
            this.colUrun_Turu.Visible = true;
            this.colUrun_Turu.VisibleIndex = 2;
            // 
            // colAdet
            // 
            this.colAdet.Caption = "GENİŞLİK";
            this.colAdet.FieldName = "genislik";
            this.colAdet.Name = "colAdet";
            this.colAdet.Visible = true;
            this.colAdet.VisibleIndex = 3;
            // 
            // colGenislik
            // 
            this.colGenislik.Caption = "YUKSEKLİK";
            this.colGenislik.FieldName = "yukseklik";
            this.colGenislik.Name = "colGenislik";
            this.colGenislik.Visible = true;
            this.colGenislik.VisibleIndex = 4;
            // 
            // colYukseklik
            // 
            this.colYukseklik.Caption = "TESLİM TARİHİ";
            this.colYukseklik.FieldName = "teslimtarihi";
            this.colYukseklik.Name = "colYukseklik";
            this.colYukseklik.Visible = true;
            this.colYukseklik.VisibleIndex = 5;
            // 
            // gridButon
            // 
            this.gridButon.Caption = "Button";
            this.gridButon.ColumnEdit = this.btn_islem;
            this.gridButon.Name = "gridButon";
            this.gridButon.Visible = true;
            this.gridButon.VisibleIndex = 6;
            // 
            // btn_islem
            // 
            this.btn_islem.AutoHeight = false;
            this.btn_islem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::Stok_Takip.Properties.Resources.GÜNCELLE, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "güncelle", "güncelle", null, true)});
            this.btn_islem.Name = "btn_islem";
            this.btn_islem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // UretimMakina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 679);
            this.Controls.Add(this.splitContainer1);
            this.Name = "UretimMakina";
            this.Text = "UretimMakina";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_islem)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn colAdet;
        private DevExpress.XtraGrid.Columns.GridColumn colGenislik;
        private DevExpress.XtraGrid.Columns.GridColumn colYukseklik;
        private DevExpress.XtraGrid.Columns.GridColumn gridButon;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_islem;
    }
}