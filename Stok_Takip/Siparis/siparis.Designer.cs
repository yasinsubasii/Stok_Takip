namespace Stok_Takip
{
    partial class siparis
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Miktar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Genislik = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Yukseklik = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dateTimeTeslimat = new System.Windows.Forms.DateTimePicker();
            this.txt_Urun_Adi = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_Müsteri_Adi = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Miktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Genislik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Yukseklik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Urun_Adi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Müsteri_Adi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(675, 212);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "KAYDET";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(55, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "MÜSTERİ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(55, 103);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "ÜRÜN ADI";
            // 
            // txt_Miktar
            // 
            this.txt_Miktar.Location = new System.Drawing.Point(160, 139);
            this.txt_Miktar.Name = "txt_Miktar";
            this.txt_Miktar.Size = new System.Drawing.Size(167, 20);
            this.txt_Miktar.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(55, 142);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "MİKTARI";
            // 
            // txt_Genislik
            // 
            this.txt_Genislik.Enabled = false;
            this.txt_Genislik.Location = new System.Drawing.Point(505, 60);
            this.txt_Genislik.Name = "txt_Genislik";
            this.txt_Genislik.Size = new System.Drawing.Size(167, 20);
            this.txt_Genislik.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(400, 63);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "GENİSLİK";
            // 
            // txt_Yukseklik
            // 
            this.txt_Yukseklik.Enabled = false;
            this.txt_Yukseklik.Location = new System.Drawing.Point(505, 96);
            this.txt_Yukseklik.Name = "txt_Yukseklik";
            this.txt_Yukseklik.Size = new System.Drawing.Size(167, 20);
            this.txt_Yukseklik.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(400, 99);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 13);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "YÜKSEKLİK";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(418, 166);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(90, 13);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "TESLİMAT ZAMANI";
            // 
            // dateTimeTeslimat
            // 
            this.dateTimeTeslimat.Location = new System.Drawing.Point(550, 162);
            this.dateTimeTeslimat.Name = "dateTimeTeslimat";
            this.dateTimeTeslimat.Size = new System.Drawing.Size(200, 21);
            this.dateTimeTeslimat.TabIndex = 4;
            // 
            // txt_Urun_Adi
            // 
            this.txt_Urun_Adi.Location = new System.Drawing.Point(160, 100);
            this.txt_Urun_Adi.Name = "txt_Urun_Adi";
            this.txt_Urun_Adi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_Urun_Adi.Size = new System.Drawing.Size(167, 20);
            this.txt_Urun_Adi.TabIndex = 1;
            this.txt_Urun_Adi.SelectedIndexChanged += new System.EventHandler(this.txt_Urun_Adi_SelectedIndexChanged);
            // 
            // txt_Müsteri_Adi
            // 
            this.txt_Müsteri_Adi.Location = new System.Drawing.Point(160, 60);
            this.txt_Müsteri_Adi.Name = "txt_Müsteri_Adi";
            this.txt_Müsteri_Adi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_Müsteri_Adi.Size = new System.Drawing.Size(167, 20);
            this.txt_Müsteri_Adi.TabIndex = 1;
            // 
            // siparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 269);
            this.Controls.Add(this.dateTimeTeslimat);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_Yukseklik);
            this.Controls.Add(this.txt_Genislik);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_Miktar);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txt_Urun_Adi);
            this.Controls.Add(this.txt_Müsteri_Adi);
            this.Name = "siparis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "siparis";
            this.Load += new System.EventHandler(this.siparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Miktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Genislik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Yukseklik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Urun_Adi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Müsteri_Adi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_Miktar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_Genislik;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_Yukseklik;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.DateTimePicker dateTimeTeslimat;
        private DevExpress.XtraEditors.ComboBoxEdit txt_Urun_Adi;
        private DevExpress.XtraEditors.ComboBoxEdit txt_Müsteri_Adi;
    }
}