namespace YurtKayitSistemi
{
    partial class frmDuyuruAyrinti
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rchDuyuruIcerik = new System.Windows.Forms.RichTextBox();
            this.txtDuyuruBaslik = new System.Windows.Forms.TextBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Duyuru İçeriği:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Duyuru Başlığı:";
            // 
            // rchDuyuruIcerik
            // 
            this.rchDuyuruIcerik.Enabled = false;
            this.rchDuyuruIcerik.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchDuyuruIcerik.Location = new System.Drawing.Point(151, 79);
            this.rchDuyuruIcerik.Margin = new System.Windows.Forms.Padding(4);
            this.rchDuyuruIcerik.Name = "rchDuyuruIcerik";
            this.rchDuyuruIcerik.Size = new System.Drawing.Size(326, 229);
            this.rchDuyuruIcerik.TabIndex = 6;
            this.rchDuyuruIcerik.Text = "";
            // 
            // txtDuyuruBaslik
            // 
            this.txtDuyuruBaslik.Enabled = false;
            this.txtDuyuruBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDuyuruBaslik.Location = new System.Drawing.Point(151, 41);
            this.txtDuyuruBaslik.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuyuruBaslik.Name = "txtDuyuruBaslik";
            this.txtDuyuruBaslik.Size = new System.Drawing.Size(326, 32);
            this.txtDuyuruBaslik.TabIndex = 5;
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(213, 325);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(207, 50);
            this.btnKapat.TabIndex = 9;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // frmDuyuruAyrinti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(510, 415);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rchDuyuruIcerik);
            this.Controls.Add(this.txtDuyuruBaslik);
            this.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDuyuruAyrinti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duyuru Ayrıntıları";
            this.Load += new System.EventHandler(this.frmDuyuruAyrinti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rchDuyuruIcerik;
        private System.Windows.Forms.TextBox txtDuyuruBaslik;
        private System.Windows.Forms.Button btnKapat;
    }
}