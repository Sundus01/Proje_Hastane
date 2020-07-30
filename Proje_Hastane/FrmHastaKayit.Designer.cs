namespace Proje_Hastane
{
    partial class FrmHastaKayit
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
            this.TextSifre = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtSifre = new System.Windows.Forms.Label();
            this.Msk_TC = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.Label();
            this.MskTelefon = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.CmbCinsiyet = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextSifre
            // 
            this.TextSifre.Location = new System.Drawing.Point(136, 181);
            this.TextSifre.Name = "TextSifre";
            this.TextSifre.Size = new System.Drawing.Size(194, 31);
            this.TextSifre.TabIndex = 11;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(136, 86);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(194, 31);
            this.MskTC.TabIndex = 10;
            // 
            // TxtSifre
            // 
            this.TxtSifre.AutoSize = true;
            this.TxtSifre.Location = new System.Drawing.Point(67, 184);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(50, 23);
            this.TxtSifre.TabIndex = 9;
            this.TxtSifre.Text = "Şifre:";
            // 
            // Msk_TC
            // 
            this.Msk_TC.AutoSize = true;
            this.Msk_TC.Location = new System.Drawing.Point(0, 94);
            this.Msk_TC.Name = "Msk_TC";
            this.Msk_TC.Size = new System.Drawing.Size(117, 23);
            this.Msk_TC.TabIndex = 8;
            this.Msk_TC.Text = "TC Kimlik No:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(136, 12);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(194, 31);
            this.TxtAd.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ad:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 31);
            this.textBox2.TabIndex = 15;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.AutoSize = true;
            this.TxtSoyad.Location = new System.Drawing.Point(51, 52);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(66, 23);
            this.TxtSoyad.TabIndex = 14;
            this.TxtSoyad.Text = "SoyAd:";
            // 
            // MskTelefon
            // 
            this.MskTelefon.AutoSize = true;
            this.MskTelefon.Location = new System.Drawing.Point(44, 131);
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(73, 23);
            this.MskTelefon.TabIndex = 16;
            this.MskTelefon.Text = "Telefon:";
            this.MskTelefon.Click += new System.EventHandler(this.label5_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(136, 131);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(194, 31);
            this.maskedTextBox1.TabIndex = 18;
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.AutoSize = true;
            this.CmbCinsiyet.Location = new System.Drawing.Point(40, 227);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(77, 23);
            this.CmbCinsiyet.TabIndex = 19;
            this.CmbCinsiyet.Text = "Cinsiyet:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.comboBox1.Location = new System.Drawing.Point(136, 224);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 31);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnKayit
            // 
            this.BtnKayit.BackColor = System.Drawing.Color.Lime;
            this.BtnKayit.Location = new System.Drawing.Point(136, 286);
            this.BtnKayit.Name = "BtnKayit";
            this.BtnKayit.Size = new System.Drawing.Size(194, 32);
            this.BtnKayit.TabIndex = 21;
            this.BtnKayit.Text = "Kayıt Yap";
            this.BtnKayit.UseVisualStyleBackColor = false;
            this.BtnKayit.Click += new System.EventHandler(this.HastaKayit_Click);
            // 
            // FrmHastaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(535, 358);
            this.Controls.Add(this.BtnKayit);
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
            this.Name = "FrmHastaKayit";
            this.Text = "FrmHastaKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextSifre;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label TxtSifre;
        private System.Windows.Forms.Label Msk_TC;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label TxtSoyad;
        private System.Windows.Forms.Label MskTelefon;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label CmbCinsiyet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnKayit;
    }
}