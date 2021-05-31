namespace YurtKayitSistemi
{
    partial class frmSifreIslem
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtSifreYeni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifreEski = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(99, 114);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "ŞİFREYİ YENİLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSifreYeni
            // 
            this.txtSifreYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifreYeni.Location = new System.Drawing.Point(145, 64);
            this.txtSifreYeni.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifreYeni.Name = "txtSifreYeni";
            this.txtSifreYeni.Size = new System.Drawing.Size(240, 26);
            this.txtSifreYeni.TabIndex = 1;
            this.txtSifreYeni.TextChanged += new System.EventHandler(this.txtSifreYeni_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(43, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yeni Şifre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSifreEski
            // 
            this.txtSifreEski.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifreEski.Location = new System.Drawing.Point(145, 28);
            this.txtSifreEski.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifreEski.Name = "txtSifreEski";
            this.txtSifreEski.Size = new System.Drawing.Size(240, 26);
            this.txtSifreEski.TabIndex = 0;
            this.txtSifreEski.TextChanged += new System.EventHandler(this.txtSifreEski_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Eski Şifre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmSifreIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 181);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSifreYeni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSifreEski);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSifreIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sifre Islem";
            this.Load += new System.EventHandler(this.frmSifreIslem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSifreYeni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifreEski;
        private System.Windows.Forms.Label label1;
    }
}