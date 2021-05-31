namespace YurtKayitSistemi
{
    partial class frmSatis
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatis));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.ogrenciTableAdapter1 = new YurtKayitSistemi.YurtOtomasyonuDataSet11TableAdapters.OgrenciTableAdapter();
            this.BtnSatisYap = new System.Windows.Forms.Button();
            this.CmbUrunler = new System.Windows.Forms.ComboBox();
            this.CmbKategoriler = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMusteriler = new System.Windows.Forms.ComboBox();
            this.cmbStok = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ogrenciTableAdapter1
            // 
            this.ogrenciTableAdapter1.ClearBeforeFill = true;
            // 
            // BtnSatisYap
            // 
            this.BtnSatisYap.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSatisYap.Location = new System.Drawing.Point(219, 256);
            this.BtnSatisYap.Name = "BtnSatisYap";
            this.BtnSatisYap.Size = new System.Drawing.Size(206, 48);
            this.BtnSatisYap.TabIndex = 5;
            this.BtnSatisYap.Text = "SATIŞ YAP";
            this.BtnSatisYap.UseVisualStyleBackColor = true;
            this.BtnSatisYap.Click += new System.EventHandler(this.BtnSatisYap_Click);
            // 
            // CmbUrunler
            // 
            this.CmbUrunler.BackColor = System.Drawing.SystemColors.Info;
            this.CmbUrunler.Enabled = false;
            this.CmbUrunler.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbUrunler.FormattingEnabled = true;
            this.CmbUrunler.Location = new System.Drawing.Point(186, 135);
            this.CmbUrunler.Name = "CmbUrunler";
            this.CmbUrunler.Size = new System.Drawing.Size(276, 29);
            this.CmbUrunler.TabIndex = 2;
            this.CmbUrunler.SelectedValueChanged += new System.EventHandler(this.CmbUrunler_SelectedValueChanged);
            // 
            // CmbKategoriler
            // 
            this.CmbKategoriler.BackColor = System.Drawing.SystemColors.Info;
            this.CmbKategoriler.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbKategoriler.FormattingEnabled = true;
            this.CmbKategoriler.Location = new System.Drawing.Point(186, 100);
            this.CmbKategoriler.Name = "CmbKategoriler";
            this.CmbKategoriler.Size = new System.Drawing.Size(276, 29);
            this.CmbKategoriler.TabIndex = 1;
            this.CmbKategoriler.SelectedValueChanged += new System.EventHandler(this.CmbKategoriler_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(107, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Müşteri:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(72, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ürün Seçim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(125, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Adet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Satış Kategori:";
            // 
            // cmbMusteriler
            // 
            this.cmbMusteriler.BackColor = System.Drawing.SystemColors.Info;
            this.cmbMusteriler.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMusteriler.FormattingEnabled = true;
            this.cmbMusteriler.Location = new System.Drawing.Point(187, 65);
            this.cmbMusteriler.Name = "cmbMusteriler";
            this.cmbMusteriler.Size = new System.Drawing.Size(276, 29);
            this.cmbMusteriler.TabIndex = 0;
            // 
            // cmbStok
            // 
            this.cmbStok.BackColor = System.Drawing.SystemColors.Info;
            this.cmbStok.Enabled = false;
            this.cmbStok.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbStok.FormattingEnabled = true;
            this.cmbStok.Location = new System.Drawing.Point(186, 170);
            this.cmbStok.Name = "cmbStok";
            this.cmbStok.Size = new System.Drawing.Size(276, 29);
            this.cmbStok.TabIndex = 3;
            this.cmbStok.SelectedValueChanged += new System.EventHandler(this.cmbStok_SelectedValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(491, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // TxtTutar
            // 
            this.TxtTutar.BackColor = System.Drawing.SystemColors.Info;
            this.TxtTutar.Enabled = false;
            this.TxtTutar.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTutar.Location = new System.Drawing.Point(186, 205);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(277, 42);
            this.TxtTutar.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(78, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 27);
            this.label5.TabIndex = 44;
            this.label5.Text = "TUTAR:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(107, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Personel:";
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.BackColor = System.Drawing.SystemColors.Info;
            this.cmbPersonel.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(187, 30);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(276, 29);
            this.cmbPersonel.TabIndex = 0;
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 335);
            this.Controls.Add(this.TxtTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbPersonel);
            this.Controls.Add(this.cmbMusteriler);
            this.Controls.Add(this.cmbStok);
            this.Controls.Add(this.BtnSatisYap);
            this.Controls.Add(this.CmbUrunler);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmbKategoriler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SATIŞ";
            this.Load += new System.EventHandler(this.frmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private YurtOtomasyonuDataSet11TableAdapters.OgrenciTableAdapter ogrenciTableAdapter1;
        private System.Windows.Forms.Button BtnSatisYap;
        private System.Windows.Forms.ComboBox CmbUrunler;
        private System.Windows.Forms.ComboBox CmbKategoriler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMusteriler;
        private System.Windows.Forms.ComboBox cmbStok;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPersonel;
    }
}