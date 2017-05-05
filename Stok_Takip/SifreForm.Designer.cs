namespace Stok_Takip
{
    partial class SifreForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sifre2txt = new System.Windows.Forms.TextBox();
            this.sifre1txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Değiştir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yeni Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yeni Şifre Tekrar";
            // 
            // sifre2txt
            // 
            this.sifre2txt.Location = new System.Drawing.Point(57, 96);
            this.sifre2txt.Name = "sifre2txt";
            this.sifre2txt.PasswordChar = '*';
            this.sifre2txt.Size = new System.Drawing.Size(100, 20);
            this.sifre2txt.TabIndex = 0;
            // 
            // sifre1txt
            // 
            this.sifre1txt.Location = new System.Drawing.Point(57, 55);
            this.sifre1txt.Name = "sifre1txt";
            this.sifre1txt.PasswordChar = '*';
            this.sifre1txt.Size = new System.Drawing.Size(100, 20);
            this.sifre1txt.TabIndex = 2;
            // 
            // SifreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 227);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sifre1txt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sifre2txt);
            this.Name = "SifreForm";
            this.Text = "SifreForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sifre2txt;
        private System.Windows.Forms.TextBox sifre1txt;
    }
}