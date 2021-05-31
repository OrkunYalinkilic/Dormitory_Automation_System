namespace YurtKayitSistemi
{
    partial class frmŞoforEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmŞoforEkle));
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.MskSoforTelefon = new System.Windows.Forms.MaskedTextBox();
            this.MskSoforTc = new System.Windows.Forms.MaskedTextBox();
            this.TxtSoforYas = new System.Windows.Forms.TextBox();
            this.TxtSoforSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSoforAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(241, 214);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(152, 43);
            this.BtnKaydet.TabIndex = 5;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // MskSoforTelefon
            // 
            this.MskSoforTelefon.BackColor = System.Drawing.SystemColors.Info;
            this.MskSoforTelefon.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskSoforTelefon.Location = new System.Drawing.Point(191, 170);
            this.MskSoforTelefon.Mask = "(999) 000-0000";
            this.MskSoforTelefon.Name = "MskSoforTelefon";
            this.MskSoforTelefon.Size = new System.Drawing.Size(277, 28);
            this.MskSoforTelefon.TabIndex = 4;
            // 
            // MskSoforTc
            // 
            this.MskSoforTc.BackColor = System.Drawing.SystemColors.Info;
            this.MskSoforTc.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskSoforTc.Location = new System.Drawing.Point(192, 102);
            this.MskSoforTc.Mask = "00000000000";
            this.MskSoforTc.Name = "MskSoforTc";
            this.MskSoforTc.Size = new System.Drawing.Size(276, 28);
            this.MskSoforTc.TabIndex = 2;
            this.MskSoforTc.ValidatingType = typeof(int);
            // 
            // TxtSoforYas
            // 
            this.TxtSoforYas.BackColor = System.Drawing.SystemColors.Info;
            this.TxtSoforYas.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoforYas.Location = new System.Drawing.Point(191, 136);
            this.TxtSoforYas.Name = "TxtSoforYas";
            this.TxtSoforYas.Size = new System.Drawing.Size(277, 28);
            this.TxtSoforYas.TabIndex = 3;
            // 
            // TxtSoforSoyad
            // 
            this.TxtSoforSoyad.BackColor = System.Drawing.SystemColors.Info;
            this.TxtSoforSoyad.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoforSoyad.Location = new System.Drawing.Point(191, 63);
            this.TxtSoforSoyad.Name = "TxtSoforSoyad";
            this.TxtSoforSoyad.Size = new System.Drawing.Size(277, 28);
            this.TxtSoforSoyad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(108, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(130, 141);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Yaş:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Şoför Soyad:";
            // 
            // TxtSoforAd
            // 
            this.TxtSoforAd.BackColor = System.Drawing.SystemColors.Info;
            this.TxtSoforAd.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoforAd.Location = new System.Drawing.Point(191, 29);
            this.TxtSoforAd.Name = "TxtSoforAd";
            this.TxtSoforAd.Size = new System.Drawing.Size(277, 28);
            this.TxtSoforAd.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(146, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "TC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(74, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Şoför Ad:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(500, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // frmŞoforEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 283);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.MskSoforTelefon);
            this.Controls.Add(this.MskSoforTc);
            this.Controls.Add(this.TxtSoforYas);
            this.Controls.Add(this.TxtSoforSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSoforAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmŞoforEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şoför Ekleme";
            this.Load += new System.EventHandler(this.frmŞoforEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.MaskedTextBox MskSoforTelefon;
        private System.Windows.Forms.MaskedTextBox MskSoforTc;
        private System.Windows.Forms.TextBox TxtSoforYas;
        private System.Windows.Forms.TextBox TxtSoforSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSoforAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}