namespace Stok_Takip.Acilis_Menu
{
    partial class KullaniciEkle
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtRutbe = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSif = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtKu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.ButGonder = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRutbe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Rütbe";
            // 
            // TxtRutbe
            // 
            this.TxtRutbe.Location = new System.Drawing.Point(24, 56);
            this.TxtRutbe.Name = "TxtRutbe";
            this.TxtRutbe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtRutbe.Properties.Items.AddRange(new object[] {
            "Depo",
            "Yönetici",
            "Satış"});
            this.TxtRutbe.Size = new System.Drawing.Size(100, 20);
            this.TxtRutbe.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Şifre";
            // 
            // TxtSif
            // 
            this.TxtSif.Location = new System.Drawing.Point(24, 233);
            this.TxtSif.Name = "TxtSif";
            this.TxtSif.PasswordChar = '*';
            this.TxtSif.Size = new System.Drawing.Size(100, 20);
            this.TxtSif.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // TxtKu
            // 
            this.TxtKu.Location = new System.Drawing.Point(24, 168);
            this.TxtKu.Name = "TxtKu";
            this.TxtKu.PasswordChar = '*';
            this.TxtKu.Size = new System.Drawing.Size(100, 20);
            this.TxtKu.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Adı";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(24, 113);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.PasswordChar = '*';
            this.TxtAd.Size = new System.Drawing.Size(100, 20);
            this.TxtAd.TabIndex = 17;
            // 
            // ButGonder
            // 
            this.ButGonder.Location = new System.Drawing.Point(24, 290);
            this.ButGonder.Name = "ButGonder";
            this.ButGonder.Size = new System.Drawing.Size(101, 23);
            this.ButGonder.TabIndex = 19;
            this.ButGonder.Text = "Kaydet";
            this.ButGonder.Click += new System.EventHandler(this.ButGonder_Click);
            // 
            // KullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 338);
            this.Controls.Add(this.ButGonder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtKu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSif);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TxtRutbe);
            this.Name = "KullaniciEkle";
            this.Text = "KullaniciEkle";
            ((System.ComponentModel.ISupportInitialize)(this.TxtRutbe.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit TxtRutbe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtKu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAd;
        private DevExpress.XtraEditors.SimpleButton ButGonder;
    }
}