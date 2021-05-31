namespace YurtKayitSistemi
{
    partial class frmOdaIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdaIslem));
            this.label1 = new System.Windows.Forms.Label();
            this.txtOdaID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOdaAktif = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOdaKapasite = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOdaDurum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oda ID:";
            // 
            // txtOdaID
            // 
            this.txtOdaID.Enabled = false;
            this.txtOdaID.Location = new System.Drawing.Point(405, 33);
            this.txtOdaID.Name = "txtOdaID";
            this.txtOdaID.Size = new System.Drawing.Size(250, 28);
            this.txtOdaID.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Oda No:";
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.Location = new System.Drawing.Point(405, 67);
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Size = new System.Drawing.Size(250, 28);
            this.txtOdaNo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kalan Kişi Sayısı:";
            // 
            // txtOdaAktif
            // 
            this.txtOdaAktif.Location = new System.Drawing.Point(405, 136);
            this.txtOdaAktif.Name = "txtOdaAktif";
            this.txtOdaAktif.Size = new System.Drawing.Size(250, 28);
            this.txtOdaAktif.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Oda Kapasitesi:";
            // 
            // txtOdaKapasite
            // 
            this.txtOdaKapasite.Location = new System.Drawing.Point(405, 102);
            this.txtOdaKapasite.Name = "txtOdaKapasite";
            this.txtOdaKapasite.Size = new System.Drawing.Size(250, 28);
            this.txtOdaKapasite.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Oda Durumu:";
            // 
            // txtOdaDurum
            // 
            this.txtOdaDurum.Enabled = false;
            this.txtOdaDurum.Location = new System.Drawing.Point(405, 170);
            this.txtOdaDurum.Name = "txtOdaDurum";
            this.txtOdaDurum.Size = new System.Drawing.Size(250, 28);
            this.txtOdaDurum.TabIndex = 6;
            this.txtOdaDurum.Text = "True";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(431, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "ODA EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmOdaIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 300);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOdaKapasite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOdaDurum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOdaAktif);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOdaNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOdaID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOdaIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oda İşlemleri";
            this.Load += new System.EventHandler(this.frmOdaIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOdaID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOdaAktif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOdaKapasite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOdaDurum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}