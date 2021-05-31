namespace YurtKayitSistemi
{
    partial class frmAracServisGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAracServisGuncelle));
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Txtgun = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MskSaat = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yurtOtomasyonuDataSet30 = new YurtKayitSistemi.YurtOtomasyonuDataSet30();
            this.servisSaatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servisSaatTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSet30TableAdapters.ServisSaatTableAdapter();
            this.gunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisSaatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(237, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Gün:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(296, 145);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(177, 36);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Txtgun
            // 
            this.Txtgun.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txtgun.Enabled = false;
            this.Txtgun.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtgun.Location = new System.Drawing.Point(296, 53);
            this.Txtgun.Name = "Txtgun";
            this.Txtgun.Size = new System.Drawing.Size(206, 28);
            this.Txtgun.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(237, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Saat:";
            // 
            // MskSaat
            // 
            this.MskSaat.Location = new System.Drawing.Point(296, 96);
            this.MskSaat.Mask = "00:00";
            this.MskSaat.Name = "MskSaat";
            this.MskSaat.Size = new System.Drawing.Size(206, 28);
            this.MskSaat.TabIndex = 17;
            this.MskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gunAdiDataGridViewTextBoxColumn,
            this.saatiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.servisSaatBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(493, 279);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yurtOtomasyonuDataSet30
            // 
            this.yurtOtomasyonuDataSet30.DataSetName = "YurtOtomasyonuDataSet30";
            this.yurtOtomasyonuDataSet30.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servisSaatBindingSource
            // 
            this.servisSaatBindingSource.DataMember = "ServisSaat";
            this.servisSaatBindingSource.DataSource = this.yurtOtomasyonuDataSet30;
            // 
            // servisSaatTableAdapter
            // 
            this.servisSaatTableAdapter.ClearBeforeFill = true;
            // 
            // gunAdiDataGridViewTextBoxColumn
            // 
            this.gunAdiDataGridViewTextBoxColumn.DataPropertyName = "GunAdi";
            this.gunAdiDataGridViewTextBoxColumn.HeaderText = "Gun Adı";
            this.gunAdiDataGridViewTextBoxColumn.Name = "gunAdiDataGridViewTextBoxColumn";
            this.gunAdiDataGridViewTextBoxColumn.Width = 220;
            // 
            // saatiDataGridViewTextBoxColumn
            // 
            this.saatiDataGridViewTextBoxColumn.DataPropertyName = "Saati";
            this.saatiDataGridViewTextBoxColumn.HeaderText = "Servis Saati";
            this.saatiDataGridViewTextBoxColumn.Name = "saatiDataGridViewTextBoxColumn";
            this.saatiDataGridViewTextBoxColumn.Width = 220;
            // 
            // frmAracServisGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 521);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MskSaat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtgun);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAracServisGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arac Servis Guncelleme";
            this.Load += new System.EventHandler(this.frmAracServisGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisSaatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Txtgun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MskSaat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet30 yurtOtomasyonuDataSet30;
        private System.Windows.Forms.BindingSource servisSaatBindingSource;
        private YurtOtomasyonuDataSet30TableAdapters.ServisSaatTableAdapter servisSaatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saatiDataGridViewTextBoxColumn;
    }
}