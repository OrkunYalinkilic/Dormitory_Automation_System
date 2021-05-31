namespace YurtKayitSistemi
{
    partial class frmOdaArama
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtArananOda = new System.Windows.Forms.TextBox();
            this.btnOdaAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aramak İstediğiniz Oda Numarasini Giriniz.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oda Numarası:";
            // 
            // txtArananOda
            // 
            this.txtArananOda.Location = new System.Drawing.Point(169, 56);
            this.txtArananOda.Name = "txtArananOda";
            this.txtArananOda.Size = new System.Drawing.Size(174, 28);
            this.txtArananOda.TabIndex = 2;
            // 
            // btnOdaAra
            // 
            this.btnOdaAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdaAra.Location = new System.Drawing.Point(207, 95);
            this.btnOdaAra.Name = "btnOdaAra";
            this.btnOdaAra.Size = new System.Drawing.Size(96, 33);
            this.btnOdaAra.TabIndex = 3;
            this.btnOdaAra.Text = "ARA";
            this.btnOdaAra.UseVisualStyleBackColor = true;
            this.btnOdaAra.Click += new System.EventHandler(this.btnOdaAra_Click);
            // 
            // frmOdaArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 160);
            this.Controls.Add(this.btnOdaAra);
            this.Controls.Add(this.txtArananOda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.Name = "frmOdaArama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oda Arama";
            this.Load += new System.EventHandler(this.frmOdaArama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArananOda;
        private System.Windows.Forms.Button btnOdaAra;
    }
}