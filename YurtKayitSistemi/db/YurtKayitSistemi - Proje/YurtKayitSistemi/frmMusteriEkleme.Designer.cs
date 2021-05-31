namespace YurtKayitSistemi
{
    partial class frmMusteriEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriEkleme));
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.TxtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMusteriSehir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMusteriAd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(197, 168);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(152, 43);
            this.BtnKaydet.TabIndex = 39;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // txtBakiye
            // 
            this.txtBakiye.BackColor = System.Drawing.SystemColors.Info;
            this.txtBakiye.Enabled = false;
            this.txtBakiye.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBakiye.Location = new System.Drawing.Point(141, 127);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(277, 26);
            this.txtBakiye.TabIndex = 29;
            this.txtBakiye.Text = "0";
            // 
            // TxtMusteriSoyad
            // 
            this.TxtMusteriSoyad.BackColor = System.Drawing.SystemColors.Info;
            this.TxtMusteriSoyad.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMusteriSoyad.Location = new System.Drawing.Point(141, 61);
            this.TxtMusteriSoyad.Name = "TxtMusteriSoyad";
            this.TxtMusteriSoyad.Size = new System.Drawing.Size(277, 24);
            this.TxtMusteriSoyad.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(78, 130);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 18);
            this.label14.TabIndex = 20;
            this.label14.Text = "Bakiye:";
            // 
            // txtMusteriSehir
            // 
            this.txtMusteriSehir.BackColor = System.Drawing.SystemColors.Info;
            this.txtMusteriSehir.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriSehir.Location = new System.Drawing.Point(141, 93);
            this.txtMusteriSehir.Name = "txtMusteriSehir";
            this.txtMusteriSehir.Size = new System.Drawing.Size(277, 24);
            this.txtMusteriSehir.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Müşteri Soyad:";
            // 
            // TxtMusteriAd
            // 
            this.TxtMusteriAd.BackColor = System.Drawing.SystemColors.Info;
            this.TxtMusteriAd.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMusteriAd.Location = new System.Drawing.Point(141, 27);
            this.TxtMusteriAd.Name = "TxtMusteriAd";
            this.TxtMusteriAd.Size = new System.Drawing.Size(277, 24);
            this.TxtMusteriAd.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(87, 96);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 18);
            this.label13.TabIndex = 14;
            this.label13.Text = "Şehir:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Müşteri Ad:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(440, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // frmMusteriEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 241);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.TxtMusteriSoyad);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtMusteriSehir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtMusteriAd);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMusteriEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musteri Ekleme";
            this.Load += new System.EventHandler(this.frmMusteriEkleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.TextBox TxtMusteriSoyad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMusteriSehir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMusteriAd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}