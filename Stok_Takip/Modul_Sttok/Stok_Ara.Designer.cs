namespace Stok_Takip.Modul_Sttok
{
    partial class Stok_Ara
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
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txt_stok_adi = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_stok_ara = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sag_tiklama = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mayaStokDataSet = new Stok_Takip.MayaStokDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStok_Kodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStok_Adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrun_Turu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenislik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYukseklik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridButon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_islem = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunlerTableAdapter = new Stok_Takip.MayaStokDataSetTableAdapters.UrunlerTableAdapter();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_stok_adi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_stok_ara.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.sag_tiklama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mayaStokDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_islem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.simpleButton1);
            this.splitContainer1.Panel1.Controls.Add(this.txt_stok_adi);
            this.splitContainer1.Panel1.Controls.Add(this.simpleButton3);
            this.splitContainer1.Panel1.Controls.Add(this.simpleButton2);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Controls.Add(this.txt_stok_ara);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1232, 677);
            this.splitContainer1.SplitterDistance = 52;
            this.splitContainer1.TabIndex = 0;
            // 
            // txt_stok_adi
            // 
            this.txt_stok_adi.Location = new System.Drawing.Point(399, 20);
            this.txt_stok_adi.Name = "txt_stok_adi";
            this.txt_stok_adi.Size = new System.Drawing.Size(133, 20);
            this.txt_stok_adi.TabIndex = 5;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = global::Stok_Takip.Properties.Resources.temizle;
            this.simpleButton3.Location = new System.Drawing.Point(771, 10);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(128, 39);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "TEMİZLE";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::Stok_Takip.Properties.Resources.ARAMA;
            this.simpleButton2.Location = new System.Drawing.Point(583, 11);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(128, 39);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "ARA";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelControl2.Location = new System.Drawing.Point(289, 22);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "STOK ADI";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelControl1.Location = new System.Drawing.Point(12, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "STOK KODU";
            // 
            // txt_stok_ara
            // 
            this.txt_stok_ara.EditValue = "";
            this.txt_stok_ara.Location = new System.Drawing.Point(114, 21);
            this.txt_stok_ara.Name = "txt_stok_ara";
            this.txt_stok_ara.Size = new System.Drawing.Size(126, 20);
            this.txt_stok_ara.TabIndex = 0;
            this.txt_stok_ara.EditValueChanged += new System.EventHandler(this.txt_stok_ara_EditValueChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.sag_tiklama;
            this.gridControl1.DataSource = this.mayaStokDataSet;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btn_islem});
            this.gridControl1.Size = new System.Drawing.Size(1232, 621);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sag_tiklama
            // 
            this.sag_tiklama.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.güncelleToolStripMenuItem});
            this.sag_tiklama.Name = "sag_tiklama";
            this.sag_tiklama.Size = new System.Drawing.Size(121, 26);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            // 
            // mayaStokDataSet
            // 
            this.mayaStokDataSet.DataSetName = "MayaStokDataSet";
            this.mayaStokDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colStok_Kodu.Caption = "StokKodusadfsaf";
            this.colStok_Kodu.FieldName = "Stok_Kodu";
            this.colStok_Kodu.Name = "colStok_Kodu";
            this.colStok_Kodu.Visible = true;
            this.colStok_Kodu.VisibleIndex = 0;
            // 
            // colStok_Adi
            // 
            this.colStok_Adi.FieldName = "Stok_Adi";
            this.colStok_Adi.Name = "colStok_Adi";
            this.colStok_Adi.Visible = true;
            this.colStok_Adi.VisibleIndex = 1;
            // 
            // colUrun_Turu
            // 
            this.colUrun_Turu.FieldName = "Urun_Turu";
            this.colUrun_Turu.Name = "colUrun_Turu";
            this.colUrun_Turu.Visible = true;
            this.colUrun_Turu.VisibleIndex = 2;
            // 
            // colAdet
            // 
            this.colAdet.FieldName = "Adet";
            this.colAdet.Name = "colAdet";
            this.colAdet.Visible = true;
            this.colAdet.VisibleIndex = 3;
            // 
            // colGenislik
            // 
            this.colGenislik.FieldName = "Genislik";
            this.colGenislik.Name = "colGenislik";
            this.colGenislik.Visible = true;
            this.colGenislik.VisibleIndex = 4;
            // 
            // colYukseklik
            // 
            this.colYukseklik.FieldName = "Yukseklik";
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::Stok_Takip.Properties.Resources.GÜNCELLE, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "güncelle", "güncelle", null, true)});
            this.btn_islem.Name = "btn_islem";
            this.btn_islem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btn_islem.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_islem_ButtonClick);
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "Urunler";
            this.urunlerBindingSource.DataSource = this.mayaStokDataSet;
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::Stok_Takip.Properties.Resources.k_giris2;
            this.simpleButton1.Location = new System.Drawing.Point(943, 10);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(128, 39);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "STOKGETİR";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Stok_Ara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 677);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Stok_Ara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok_Ara";
            this.Load += new System.EventHandler(this.Stok_Ara_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_stok_adi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_stok_ara.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.sag_tiklama.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mayaStokDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_islem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.TextEdit txt_stok_ara;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.TextEdit txt_stok_adi;
        private System.Windows.Forms.ContextMenuStrip sag_tiklama;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_islem;
        private MayaStokDataSet mayaStokDataSet;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private MayaStokDataSetTableAdapters.UrunlerTableAdapter urunlerTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colStok_Kodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStok_Adi;
        private DevExpress.XtraGrid.Columns.GridColumn colUrun_Turu;
        private DevExpress.XtraGrid.Columns.GridColumn colAdet;
        private DevExpress.XtraGrid.Columns.GridColumn colGenislik;
        private DevExpress.XtraGrid.Columns.GridColumn colYukseklik;
        private DevExpress.XtraGrid.Columns.GridColumn gridButon;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}