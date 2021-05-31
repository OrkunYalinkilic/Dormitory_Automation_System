namespace YurtKayitSistemi
{
    partial class frmDuyuruEkle
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
            this.txtDuyuruBaslik = new System.Windows.Forms.TextBox();
            this.rchDuyuruIcerik = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDuyuruEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDuyuruBaslik
            // 
            this.txtDuyuruBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDuyuruBaslik.Location = new System.Drawing.Point(151, 28);
            this.txtDuyuruBaslik.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuyuruBaslik.Name = "txtDuyuruBaslik";
            this.txtDuyuruBaslik.Size = new System.Drawing.Size(326, 24);
            this.txtDuyuruBaslik.TabIndex = 0;
            // 
            // rchDuyuruIcerik
            // 
            this.rchDuyuruIcerik.Location = new System.Drawing.Point(151, 72);
            this.rchDuyuruIcerik.Margin = new System.Windows.Forms.Padding(4);
            this.rchDuyuruIcerik.Name = "rchDuyuruIcerik";
            this.rchDuyuruIcerik.Size = new System.Drawing.Size(326, 229);
            this.rchDuyuruIcerik.TabIndex = 1;
            this.rchDuyuruIcerik.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Duyuru Başlığı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Duyuru İçeriği:";
            // 
            // btnDuyuruEkle
            // 
            this.btnDuyuruEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuyuruEkle.Location = new System.Drawing.Point(178, 317);
            this.btnDuyuruEkle.Name = "btnDuyuruEkle";
            this.btnDuyuruEkle.Size = new System.Drawing.Size(253, 38);
            this.btnDuyuruEkle.TabIndex = 4;
            this.btnDuyuruEkle.Text = "DUYURU EKLE";
            this.btnDuyuruEkle.UseVisualStyleBackColor = true;
            this.btnDuyuruEkle.Click += new System.EventHandler(this.btnDuyuruEkle_Click);
            // 
            // frmDuyuruEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 384);
            this.Controls.Add(this.btnDuyuruEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rchDuyuruIcerik);
            this.Controls.Add(this.txtDuyuruBaslik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDuyuruEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duyuru Ekleme";
            this.Load += new System.EventHandler(this.frmDuyuruEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDuyuruBaslik;
        private System.Windows.Forms.RichTextBox rchDuyuruIcerik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDuyuruEkle;
    }
}