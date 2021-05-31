namespace YurtKayitSistemi
{
    partial class frmOgrenciYoneticiGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgrenciYoneticiGiris));
            this.btnSecimOgrenci = new System.Windows.Forms.Button();
            this.grpYonetici = new System.Windows.Forms.GroupBox();
            this.btnGirisYonetici = new System.Windows.Forms.Button();
            this.txtYoneticiParola = new System.Windows.Forms.TextBox();
            this.txtYoneticiKullaniciAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSecimYonetici = new System.Windows.Forms.Button();
            this.grpOgrenci = new System.Windows.Forms.GroupBox();
            this.btnGirisOgrenci = new System.Windows.Forms.Button();
            this.txtOgrenciKullaniciAd = new System.Windows.Forms.TextBox();
            this.txtOgrenciParola = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpYonetici.SuspendLayout();
            this.grpOgrenci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSecimOgrenci
            // 
            this.btnSecimOgrenci.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSecimOgrenci.Location = new System.Drawing.Point(521, 167);
            this.btnSecimOgrenci.Margin = new System.Windows.Forms.Padding(4);
            this.btnSecimOgrenci.Name = "btnSecimOgrenci";
            this.btnSecimOgrenci.Size = new System.Drawing.Size(462, 46);
            this.btnSecimOgrenci.TabIndex = 2;
            this.btnSecimOgrenci.Text = "ÖĞRENCİ GİRİŞİ";
            this.btnSecimOgrenci.UseVisualStyleBackColor = true;
            this.btnSecimOgrenci.Click += new System.EventHandler(this.btnSecimOgrenci_Click);
            // 
            // grpYonetici
            // 
            this.grpYonetici.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpYonetici.Controls.Add(this.btnGirisYonetici);
            this.grpYonetici.Controls.Add(this.txtYoneticiParola);
            this.grpYonetici.Controls.Add(this.txtYoneticiKullaniciAd);
            this.grpYonetici.Controls.Add(this.label4);
            this.grpYonetici.Controls.Add(this.label3);
            this.grpYonetici.Enabled = false;
            this.grpYonetici.Location = new System.Drawing.Point(29, 235);
            this.grpYonetici.Name = "grpYonetici";
            this.grpYonetici.Size = new System.Drawing.Size(462, 230);
            this.grpYonetici.TabIndex = 1;
            this.grpYonetici.TabStop = false;
            this.grpYonetici.Text = "Yönetici Girişi";
            // 
            // btnGirisYonetici
            // 
            this.btnGirisYonetici.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYonetici.Location = new System.Drawing.Point(202, 158);
            this.btnGirisYonetici.Name = "btnGirisYonetici";
            this.btnGirisYonetici.Size = new System.Drawing.Size(166, 52);
            this.btnGirisYonetici.TabIndex = 2;
            this.btnGirisYonetici.Text = "GİRİŞ";
            this.btnGirisYonetici.UseVisualStyleBackColor = true;
            this.btnGirisYonetici.Click += new System.EventHandler(this.btnGirisYonetici_Click);
            // 
            // txtYoneticiParola
            // 
            this.txtYoneticiParola.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYoneticiParola.Location = new System.Drawing.Point(162, 112);
            this.txtYoneticiParola.Name = "txtYoneticiParola";
            this.txtYoneticiParola.PasswordChar = '*';
            this.txtYoneticiParola.Size = new System.Drawing.Size(249, 30);
            this.txtYoneticiParola.TabIndex = 1;
            // 
            // txtYoneticiKullaniciAd
            // 
            this.txtYoneticiKullaniciAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYoneticiKullaniciAd.Location = new System.Drawing.Point(163, 64);
            this.txtYoneticiKullaniciAd.Name = "txtYoneticiKullaniciAd";
            this.txtYoneticiKullaniciAd.Size = new System.Drawing.Size(249, 30);
            this.txtYoneticiKullaniciAd.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Parola:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // btnSecimYonetici
            // 
            this.btnSecimYonetici.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSecimYonetici.Location = new System.Drawing.Point(29, 167);
            this.btnSecimYonetici.Margin = new System.Windows.Forms.Padding(4);
            this.btnSecimYonetici.Name = "btnSecimYonetici";
            this.btnSecimYonetici.Size = new System.Drawing.Size(462, 46);
            this.btnSecimYonetici.TabIndex = 1;
            this.btnSecimYonetici.Text = "YÖNETİCİ GİRİŞİ";
            this.btnSecimYonetici.UseVisualStyleBackColor = true;
            this.btnSecimYonetici.Click += new System.EventHandler(this.btnSecimYonetici_Click);
            // 
            // grpOgrenci
            // 
            this.grpOgrenci.Controls.Add(this.btnGirisOgrenci);
            this.grpOgrenci.Controls.Add(this.txtOgrenciKullaniciAd);
            this.grpOgrenci.Controls.Add(this.txtOgrenciParola);
            this.grpOgrenci.Controls.Add(this.label5);
            this.grpOgrenci.Controls.Add(this.label6);
            this.grpOgrenci.Enabled = false;
            this.grpOgrenci.Location = new System.Drawing.Point(521, 235);
            this.grpOgrenci.Name = "grpOgrenci";
            this.grpOgrenci.Size = new System.Drawing.Size(462, 230);
            this.grpOgrenci.TabIndex = 1;
            this.grpOgrenci.TabStop = false;
            this.grpOgrenci.Text = "Öğrenci Girişi";
            // 
            // btnGirisOgrenci
            // 
            this.btnGirisOgrenci.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisOgrenci.Location = new System.Drawing.Point(207, 158);
            this.btnGirisOgrenci.Name = "btnGirisOgrenci";
            this.btnGirisOgrenci.Size = new System.Drawing.Size(166, 52);
            this.btnGirisOgrenci.TabIndex = 2;
            this.btnGirisOgrenci.Text = "GİRİŞ";
            this.btnGirisOgrenci.UseVisualStyleBackColor = true;
            this.btnGirisOgrenci.Click += new System.EventHandler(this.btnGirisOgrenci_Click);
            // 
            // txtOgrenciKullaniciAd
            // 
            this.txtOgrenciKullaniciAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciKullaniciAd.Location = new System.Drawing.Point(168, 64);
            this.txtOgrenciKullaniciAd.Name = "txtOgrenciKullaniciAd";
            this.txtOgrenciKullaniciAd.Size = new System.Drawing.Size(249, 30);
            this.txtOgrenciKullaniciAd.TabIndex = 0;
            // 
            // txtOgrenciParola
            // 
            this.txtOgrenciParola.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciParola.Location = new System.Drawing.Point(167, 112);
            this.txtOgrenciParola.Name = "txtOgrenciParola";
            this.txtOgrenciParola.PasswordChar = '*';
            this.txtOgrenciParola.Size = new System.Drawing.Size(249, 30);
            this.txtOgrenciParola.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kullanıcı Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Parola:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Georgia", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(223, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOG IN SAYFASI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Georgia", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(96, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(663, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "YURT OTOMASYON SİSTEMİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(765, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 23);
            this.label7.TabIndex = 0;
            // 
            // frmOgrenciYoneticiGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1010, 488);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSecimYonetici);
            this.Controls.Add(this.grpOgrenci);
            this.Controls.Add(this.grpYonetici);
            this.Controls.Add(this.btnSecimOgrenci);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOgrenciYoneticiGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ";
            this.Load += new System.EventHandler(this.frmOgrenciYoneticiGiris_Load);
            this.grpYonetici.ResumeLayout(false);
            this.grpYonetici.PerformLayout();
            this.grpOgrenci.ResumeLayout(false);
            this.grpOgrenci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSecimOgrenci;
        private System.Windows.Forms.GroupBox grpYonetici;
        private System.Windows.Forms.Button btnSecimYonetici;
        private System.Windows.Forms.GroupBox grpOgrenci;
        private System.Windows.Forms.Button btnGirisYonetici;
        private System.Windows.Forms.TextBox txtYoneticiParola;
        private System.Windows.Forms.TextBox txtYoneticiKullaniciAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGirisOgrenci;
        private System.Windows.Forms.TextBox txtOgrenciKullaniciAd;
        private System.Windows.Forms.TextBox txtOgrenciParola;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}