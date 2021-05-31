namespace YurtKayitSistemi
{
    partial class frmBolumAyrıntı
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBlmID = new System.Windows.Forms.TextBox();
            this.txtBlmAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yurtOtomasyonuDataSet10 = new YurtKayitSistemi.YurtOtomasyonuDataSet10();
            this.yurtOtomasyonuDataSet10BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet10BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(107, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÖLÜM ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(107, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "BÖLÜM İSMİ: ";
            // 
            // txtBlmID
            // 
            this.txtBlmID.Enabled = false;
            this.txtBlmID.Location = new System.Drawing.Point(236, 94);
            this.txtBlmID.Name = "txtBlmID";
            this.txtBlmID.Size = new System.Drawing.Size(223, 28);
            this.txtBlmID.TabIndex = 0;
            // 
            // txtBlmAd
            // 
            this.txtBlmAd.Enabled = false;
            this.txtBlmAd.Location = new System.Drawing.Point(236, 133);
            this.txtBlmAd.Name = "txtBlmAd";
            this.txtBlmAd.Size = new System.Drawing.Size(223, 28);
            this.txtBlmAd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bu Bölümde Olan Öğrencilerin Bilgileri";
            // 
            // yurtOtomasyonuDataSet10
            // 
            this.yurtOtomasyonuDataSet10.DataSetName = "YurtOtomasyonuDataSet10";
            this.yurtOtomasyonuDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yurtOtomasyonuDataSet10BindingSource
            // 
            this.yurtOtomasyonuDataSet10BindingSource.DataSource = this.yurtOtomasyonuDataSet10;
            this.yurtOtomasyonuDataSet10BindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 242);
            this.dataGridView1.TabIndex = 4;
            // 
            // txtBaslik
            // 
            this.txtBaslik.BackColor = System.Drawing.SystemColors.Info;
            this.txtBaslik.Enabled = false;
            this.txtBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBaslik.Location = new System.Drawing.Point(12, 27);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(570, 45);
            this.txtBaslik.TabIndex = 5;
            this.txtBaslik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmBolumAyrıntı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 486);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBlmAd);
            this.Controls.Add(this.txtBlmID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBolumAyrıntı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bölüm Ayrıntıları";
            this.Load += new System.EventHandler(this.frmBolumAyrıntı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet10BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBlmID;
        private System.Windows.Forms.TextBox txtBlmAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource yurtOtomasyonuDataSet10BindingSource;
        private YurtOtomasyonuDataSet10 yurtOtomasyonuDataSet10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBaslik;
    }
}