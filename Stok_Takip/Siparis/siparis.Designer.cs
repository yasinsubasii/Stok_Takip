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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dateTimeTeslimat = new System.Windows.Forms.DateTimePicker();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Yukseklik = new DevExpress.XtraEditors.TextEdit();
            this.txt_Genislik = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Miktar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Urun_Adi = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_Müsteri_Adi = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Yukseklik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Genislik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Miktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Urun_Adi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Müsteri_Adi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 283);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.dateTimeTeslimat);
            this.tabPage1.Controls.Add(this.labelControl6);
            this.tabPage1.Controls.Add(this.labelControl5);
            this.tabPage1.Controls.Add(this.labelControl4);
            this.tabPage1.Controls.Add(this.txt_Yukseklik);
            this.tabPage1.Controls.Add(this.txt_Genislik);
            this.tabPage1.Controls.Add(this.labelControl3);
            this.tabPage1.Controls.Add(this.txt_Miktar);
            this.tabPage1.Controls.Add(this.labelControl2);
            this.tabPage1.Controls.Add(this.labelControl1);
            this.tabPage1.Controls.Add(this.simpleButton1);
            this.tabPage1.Controls.Add(this.txt_Urun_Adi);
            this.tabPage1.Controls.Add(this.txt_Müsteri_Adi);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 257);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HazırSiparis";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 257);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // dateTimeTeslimat
            // 
            this.dateTimeTeslimat.Location = new System.Drawing.Point(541, 143);
            this.dateTimeTeslimat.Name = "dateTimeTeslimat";
            this.dateTimeTeslimat.Size = new System.Drawing.Size(200, 21);
            this.dateTimeTeslimat.TabIndex = 17;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(409, 147);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(90, 13);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "TESLİMAT ZAMANI";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(391, 80);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 13);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "YÜKSEKLİK";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(391, 44);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "GENİSLİK";
            // 
            // txt_Yukseklik
            // 
            this.txt_Yukseklik.Enabled = false;
            this.txt_Yukseklik.Location = new System.Drawing.Point(496, 77);
            this.txt_Yukseklik.Name = "txt_Yukseklik";
            this.txt_Yukseklik.Size = new System.Drawing.Size(167, 20);
            this.txt_Yukseklik.TabIndex = 6;
            // 
            // txt_Genislik
            // 
            this.txt_Genislik.Enabled = false;
            this.txt_Genislik.Location = new System.Drawing.Point(496, 41);
            this.txt_Genislik.Name = "txt_Genislik";
            this.txt_Genislik.Size = new System.Drawing.Size(167, 20);
            this.txt_Genislik.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(46, 123);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "MİKTARI";
            // 
            // txt_Miktar
            // 
            this.txt_Miktar.Location = new System.Drawing.Point(151, 120);
            this.txt_Miktar.Name = "txt_Miktar";
            this.txt_Miktar.Size = new System.Drawing.Size(167, 20);
            this.txt_Miktar.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(46, 84);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "ÜRÜN ADI";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(46, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "MÜSTERİ";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(666, 193);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "KAYDET";
            // 
            // txt_Urun_Adi
            // 
            this.txt_Urun_Adi.Location = new System.Drawing.Point(151, 81);
            this.txt_Urun_Adi.Name = "txt_Urun_Adi";
            this.txt_Urun_Adi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_Urun_Adi.Size = new System.Drawing.Size(167, 20);
            this.txt_Urun_Adi.TabIndex = 9;
            // 
            // txt_Müsteri_Adi
            // 
            this.txt_Müsteri_Adi.Location = new System.Drawing.Point(151, 41);
            this.txt_Müsteri_Adi.Name = "txt_Müsteri_Adi";
            this.txt_Müsteri_Adi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_Müsteri_Adi.Size = new System.Drawing.Size(167, 20);
            this.txt_Müsteri_Adi.TabIndex = 10;
            // 
            // siparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 283);
            this.Controls.Add(this.tabControl1);
            this.Name = "siparis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "siparis";
            this.Load += new System.EventHandler(this.siparis_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Yukseklik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Genislik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Miktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Urun_Adi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Müsteri_Adi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dateTimeTeslimat;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_Yukseklik;
        private DevExpress.XtraEditors.TextEdit txt_Genislik;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_Miktar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ComboBoxEdit txt_Urun_Adi;
        private DevExpress.XtraEditors.ComboBoxEdit txt_Müsteri_Adi;
        private System.Windows.Forms.TabPage tabPage2;
    }
}