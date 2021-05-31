namespace YurtKayitSistemi
{
    partial class FrmOgrDuzenle
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
            this.label1 = new System.Windows.Forms.Label();
            this.RchVeliAdres = new System.Windows.Forms.RichTextBox();
            this.CmbOgrOdaNo = new System.Windows.Forms.ComboBox();
            this.CmbOgrBolum = new System.Windows.Forms.ComboBox();
            this.MskOgrDogumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.MskVeliTelefon = new System.Windows.Forms.MaskedTextBox();
            this.MskOgrTelefon = new System.Windows.Forms.MaskedTextBox();
            this.MskOgrTc = new System.Windows.Forms.MaskedTextBox();
            this.TxtOgrMail = new System.Windows.Forms.TextBox();
            this.TxtVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.TxtOgrSoyad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOgrAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOgrID = new System.Windows.Forms.TextBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci ID:";
            // 
            // RchVeliAdres
            // 
            this.RchVeliAdres.BackColor = System.Drawing.SystemColors.Info;
            this.RchVeliAdres.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RchVeliAdres.Location = new System.Drawing.Point(188, 452);
            this.RchVeliAdres.Name = "RchVeliAdres";
            this.RchVeliAdres.Size = new System.Drawing.Size(275, 149);
            this.RchVeliAdres.TabIndex = 11;
            this.RchVeliAdres.Text = "";
            // 
            // CmbOgrOdaNo
            // 
            this.CmbOgrOdaNo.BackColor = System.Drawing.SystemColors.Info;
            this.CmbOgrOdaNo.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbOgrOdaNo.FormattingEnabled = true;
            this.CmbOgrOdaNo.Location = new System.Drawing.Point(186, 334);
            this.CmbOgrOdaNo.Name = "CmbOgrOdaNo";
            this.CmbOgrOdaNo.Size = new System.Drawing.Size(276, 29);
            this.CmbOgrOdaNo.TabIndex = 8;
            // 
            // CmbOgrBolum
            // 
            this.CmbOgrBolum.BackColor = System.Drawing.SystemColors.Info;
            this.CmbOgrBolum.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbOgrBolum.FormattingEnabled = true;
            this.CmbOgrBolum.Location = new System.Drawing.Point(186, 260);
            this.CmbOgrBolum.Name = "CmbOgrBolum";
            this.CmbOgrBolum.Size = new System.Drawing.Size(276, 29);
            this.CmbOgrBolum.TabIndex = 6;
            // 
            // MskOgrDogumTarihi
            // 
            this.MskOgrDogumTarihi.BackColor = System.Drawing.SystemColors.Info;
            this.MskOgrDogumTarihi.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskOgrDogumTarihi.Location = new System.Drawing.Point(186, 222);
            this.MskOgrDogumTarihi.Mask = "00/00/0000";
            this.MskOgrDogumTarihi.Name = "MskOgrDogumTarihi";
            this.MskOgrDogumTarihi.Size = new System.Drawing.Size(277, 28);
            this.MskOgrDogumTarihi.TabIndex = 5;
            this.MskOgrDogumTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // MskVeliTelefon
            // 
            this.MskVeliTelefon.BackColor = System.Drawing.SystemColors.Info;
            this.MskVeliTelefon.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskVeliTelefon.Location = new System.Drawing.Point(186, 406);
            this.MskVeliTelefon.Mask = "(999) 000-0000";
            this.MskVeliTelefon.Name = "MskVeliTelefon";
            this.MskVeliTelefon.Size = new System.Drawing.Size(277, 28);
            this.MskVeliTelefon.TabIndex = 10;
            // 
            // MskOgrTelefon
            // 
            this.MskOgrTelefon.BackColor = System.Drawing.SystemColors.Info;
            this.MskOgrTelefon.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskOgrTelefon.Location = new System.Drawing.Point(186, 182);
            this.MskOgrTelefon.Mask = "(999) 000-0000";
            this.MskOgrTelefon.Name = "MskOgrTelefon";
            this.MskOgrTelefon.Size = new System.Drawing.Size(277, 28);
            this.MskOgrTelefon.TabIndex = 4;
            // 
            // MskOgrTc
            // 
            this.MskOgrTc.BackColor = System.Drawing.SystemColors.Info;
            this.MskOgrTc.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskOgrTc.Location = new System.Drawing.Point(187, 148);
            this.MskOgrTc.Mask = "00000000000";
            this.MskOgrTc.Name = "MskOgrTc";
            this.MskOgrTc.Size = new System.Drawing.Size(276, 28);
            this.MskOgrTc.TabIndex = 3;
            this.MskOgrTc.ValidatingType = typeof(int);
            // 
            // TxtOgrMail
            // 
            this.TxtOgrMail.BackColor = System.Drawing.SystemColors.Info;
            this.TxtOgrMail.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrMail.Location = new System.Drawing.Point(185, 295);
            this.TxtOgrMail.Name = "TxtOgrMail";
            this.TxtOgrMail.Size = new System.Drawing.Size(277, 28);
            this.TxtOgrMail.TabIndex = 7;
            // 
            // TxtVeliAdSoyad
            // 
            this.TxtVeliAdSoyad.BackColor = System.Drawing.SystemColors.Info;
            this.TxtVeliAdSoyad.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtVeliAdSoyad.Location = new System.Drawing.Point(185, 373);
            this.TxtVeliAdSoyad.Name = "TxtVeliAdSoyad";
            this.TxtVeliAdSoyad.Size = new System.Drawing.Size(277, 28);
            this.TxtVeliAdSoyad.TabIndex = 9;
            // 
            // TxtOgrSoyad
            // 
            this.TxtOgrSoyad.BackColor = System.Drawing.SystemColors.Info;
            this.TxtOgrSoyad.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrSoyad.Location = new System.Drawing.Point(186, 109);
            this.TxtOgrSoyad.Name = "TxtOgrSoyad";
            this.TxtOgrSoyad.Size = new System.Drawing.Size(277, 28);
            this.TxtOgrSoyad.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(116, 452);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 23);
            this.label11.TabIndex = 11;
            this.label11.Text = "Adres:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(65, 411);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Veli Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(103, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Telefon:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(123, 298);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Mail:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(38, 334);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 23);
            this.label10.TabIndex = 17;
            this.label10.Text = "Oda Numarası:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(47, 376);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Veli Ad Soyad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(38, 260);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Öğrenci Bölüm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(42, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Öğrenci Soyad:";
            // 
            // TxtOgrAd
            // 
            this.TxtOgrAd.BackColor = System.Drawing.SystemColors.Info;
            this.TxtOgrAd.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrAd.Location = new System.Drawing.Point(186, 75);
            this.TxtOgrAd.Name = "TxtOgrAd";
            this.TxtOgrAd.Size = new System.Drawing.Size(277, 28);
            this.TxtOgrAd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(141, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "TC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(42, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(69, 80);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 23);
            this.label12.TabIndex = 21;
            this.label12.Text = "Öğrenci Ad:";
            // 
            // txtOgrID
            // 
            this.txtOgrID.BackColor = System.Drawing.SystemColors.Info;
            this.txtOgrID.Enabled = false;
            this.txtOgrID.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrID.Location = new System.Drawing.Point(185, 41);
            this.txtOgrID.Name = "txtOgrID";
            this.txtOgrID.Size = new System.Drawing.Size(277, 28);
            this.txtOgrID.TabIndex = 13;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Location = new System.Drawing.Point(41, 624);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(421, 48);
            this.BtnGuncelle.TabIndex = 12;
            this.BtnGuncelle.Text = "GÜNCELLEMEYİ KAYDET";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // FrmOgrDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 698);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.RchVeliAdres);
            this.Controls.Add(this.CmbOgrOdaNo);
            this.Controls.Add(this.CmbOgrBolum);
            this.Controls.Add(this.MskOgrDogumTarihi);
            this.Controls.Add(this.MskVeliTelefon);
            this.Controls.Add(this.MskOgrTelefon);
            this.Controls.Add(this.MskOgrTc);
            this.Controls.Add(this.TxtOgrMail);
            this.Controls.Add(this.TxtVeliAdSoyad);
            this.Controls.Add(this.TxtOgrSoyad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOgrID);
            this.Controls.Add(this.TxtOgrAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgrDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Düzenle";
            this.Load += new System.EventHandler(this.FrmOgrDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RchVeliAdres;
        private System.Windows.Forms.ComboBox CmbOgrOdaNo;
        private System.Windows.Forms.ComboBox CmbOgrBolum;
        private System.Windows.Forms.MaskedTextBox MskOgrDogumTarihi;
        private System.Windows.Forms.MaskedTextBox MskVeliTelefon;
        private System.Windows.Forms.MaskedTextBox MskOgrTelefon;
        private System.Windows.Forms.MaskedTextBox MskOgrTc;
        private System.Windows.Forms.TextBox TxtOgrMail;
        private System.Windows.Forms.TextBox TxtVeliAdSoyad;
        private System.Windows.Forms.TextBox TxtOgrSoyad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOgrAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOgrID;
        private System.Windows.Forms.Button BtnGuncelle;
    }
}