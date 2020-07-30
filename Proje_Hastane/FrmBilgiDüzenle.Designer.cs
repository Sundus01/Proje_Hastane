namespace Proje_Hastane
{
    partial class FrmBilgiDüzenle
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
            this.BtnBilgiDuzenle = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CmbCinsiyet = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.MskTelefon = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextSifre = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtSifre = new System.Windows.Forms.Label();
            this.Msk_TC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnBilgiDuzenle
            // 
            this.BtnBilgiDuzenle.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnBilgiDuzenle.Location = new System.Drawing.Point(142, 301);
            this.BtnBilgiDuzenle.Name = "BtnBilgiDuzenle";
            this.BtnBilgiDuzenle.Size = new System.Drawing.Size(194, 32);
            this.BtnBilgiDuzenle.TabIndex = 34;
            this.BtnBilgiDuzenle.Text = "Güncelle";
            this.BtnBilgiDuzenle.UseVisualStyleBackColor = false;
            this.BtnBilgiDuzenle.Click += new System.EventHandler(this.BtnKayit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.comboBox1.Location = new System.Drawing.Point(142, 239);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 31);
            this.comboBox1.TabIndex = 33;
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.AutoSize = true;
            this.CmbCinsiyet.Location = new System.Drawing.Point(46, 242);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(77, 23);
            this.CmbCinsiyet.TabIndex = 32;
            this.CmbCinsiyet.Text = "Cinsiyet:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(142, 146);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(194, 31);
            this.maskedTextBox1.TabIndex = 31;
            // 
            // MskTelefon
            // 
            this.MskTelefon.AutoSize = true;
            this.MskTelefon.Location = new System.Drawing.Point(50, 146);
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(73, 23);
            this.MskTelefon.TabIndex = 30;
            this.MskTelefon.Text = "Telefon:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 31);
            this.textBox2.TabIndex = 29;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.AutoSize = true;
            this.TxtSoyad.Location = new System.Drawing.Point(57, 67);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(66, 23);
            this.TxtSoyad.TabIndex = 28;
            this.TxtSoyad.Text = "SoyAd:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(142, 27);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(194, 31);
            this.TxtAd.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ad:";
            // 
            // TextSifre
            // 
            this.TextSifre.Location = new System.Drawing.Point(142, 196);
            this.TextSifre.Name = "TextSifre";
            this.TextSifre.Size = new System.Drawing.Size(194, 31);
            this.TextSifre.TabIndex = 25;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(142, 101);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(194, 31);
            this.MskTC.TabIndex = 24;
            // 
            // TxtSifre
            // 
            this.TxtSifre.AutoSize = true;
            this.TxtSifre.Location = new System.Drawing.Point(73, 199);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(50, 23);
            this.TxtSifre.TabIndex = 23;
            this.TxtSifre.Text = "Şifre:";
            // 
            // Msk_TC
            // 
            this.Msk_TC.AutoSize = true;
            this.Msk_TC.Location = new System.Drawing.Point(6, 109);
            this.Msk_TC.Name = "Msk_TC";
            this.Msk_TC.Size = new System.Drawing.Size(117, 23);
            this.Msk_TC.TabIndex = 22;
            this.Msk_TC.Text = "TC Kimlik No:";
            // 
            // FrmBilgiDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(440, 382);
            this.Controls.Add(this.BtnBilgiDuzenle);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CmbCinsiyet);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.MskTelefon);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextSifre);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.Msk_TC);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmBilgiDüzenle";
            this.Text = "FrmBilgiDüzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBilgiDuzenle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label CmbCinsiyet;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label MskTelefon;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextSifre;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label TxtSifre;
        private System.Windows.Forms.Label Msk_TC;
    }
}