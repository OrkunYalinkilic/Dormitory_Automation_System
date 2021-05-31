namespace YurtKayitSistemi
{
    partial class FrmOgrListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrListe));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrBolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrDogumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrOdaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrVeliTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrVeliAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet4 = new YurtKayitSistemi.YurtOtomasyonuDataSet4();
            this.ogrenciTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSet4TableAdapters.OgrenciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrIDDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrTCDataGridViewTextBoxColumn,
            this.ogrTelefonDataGridViewTextBoxColumn,
            this.ogrBolumDataGridViewTextBoxColumn,
            this.ogrDogumTarihiDataGridViewTextBoxColumn,
            this.ogrOdaNoDataGridViewTextBoxColumn,
            this.ogrMailDataGridViewTextBoxColumn,
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn,
            this.ogrVeliTelefonDataGridViewTextBoxColumn,
            this.ogrVeliAdresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1105, 388);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ogrIDDataGridViewTextBoxColumn
            // 
            this.ogrIDDataGridViewTextBoxColumn.DataPropertyName = "OgrID";
            this.ogrIDDataGridViewTextBoxColumn.HeaderText = "Öğrenci ID";
            this.ogrIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrIDDataGridViewTextBoxColumn.Name = "ogrIDDataGridViewTextBoxColumn";
            this.ogrIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogrIDDataGridViewTextBoxColumn.Width = 110;
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "Adı";
            this.ogrAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            this.ogrAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "Soyadı";
            this.ogrSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            this.ogrSoyadDataGridViewTextBoxColumn.Width = 50;
            // 
            // ogrTCDataGridViewTextBoxColumn
            // 
            this.ogrTCDataGridViewTextBoxColumn.DataPropertyName = "OgrTC";
            this.ogrTCDataGridViewTextBoxColumn.HeaderText = "TC Kimlik";
            this.ogrTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrTCDataGridViewTextBoxColumn.Name = "ogrTCDataGridViewTextBoxColumn";
            this.ogrTCDataGridViewTextBoxColumn.Width = 110;
            // 
            // ogrTelefonDataGridViewTextBoxColumn
            // 
            this.ogrTelefonDataGridViewTextBoxColumn.DataPropertyName = "OgrTelefon";
            this.ogrTelefonDataGridViewTextBoxColumn.HeaderText = "Telefon No";
            this.ogrTelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrTelefonDataGridViewTextBoxColumn.Name = "ogrTelefonDataGridViewTextBoxColumn";
            this.ogrTelefonDataGridViewTextBoxColumn.Width = 110;
            // 
            // ogrBolumDataGridViewTextBoxColumn
            // 
            this.ogrBolumDataGridViewTextBoxColumn.DataPropertyName = "OgrBolum";
            this.ogrBolumDataGridViewTextBoxColumn.HeaderText = "Bölüm";
            this.ogrBolumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrBolumDataGridViewTextBoxColumn.Name = "ogrBolumDataGridViewTextBoxColumn";
            this.ogrBolumDataGridViewTextBoxColumn.Width = 155;
            // 
            // ogrDogumTarihiDataGridViewTextBoxColumn
            // 
            this.ogrDogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "OgrDogumTarihi";
            this.ogrDogumTarihiDataGridViewTextBoxColumn.HeaderText = "Doğum Tarihi";
            this.ogrDogumTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrDogumTarihiDataGridViewTextBoxColumn.Name = "ogrDogumTarihiDataGridViewTextBoxColumn";
            this.ogrDogumTarihiDataGridViewTextBoxColumn.Width = 120;
            // 
            // ogrOdaNoDataGridViewTextBoxColumn
            // 
            this.ogrOdaNoDataGridViewTextBoxColumn.DataPropertyName = "OgrOdaNo";
            this.ogrOdaNoDataGridViewTextBoxColumn.HeaderText = "Oda No";
            this.ogrOdaNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrOdaNoDataGridViewTextBoxColumn.Name = "ogrOdaNoDataGridViewTextBoxColumn";
            this.ogrOdaNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrMailDataGridViewTextBoxColumn
            // 
            this.ogrMailDataGridViewTextBoxColumn.DataPropertyName = "OgrMail";
            this.ogrMailDataGridViewTextBoxColumn.HeaderText = "Mail Adresi";
            this.ogrMailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrMailDataGridViewTextBoxColumn.Name = "ogrMailDataGridViewTextBoxColumn";
            this.ogrMailDataGridViewTextBoxColumn.Width = 120;
            // 
            // ogrVeliAdSoyadDataGridViewTextBoxColumn
            // 
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrVeliAdSoyad";
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn.HeaderText = "OgrVeliAdSoyad";
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn.Name = "ogrVeliAdSoyadDataGridViewTextBoxColumn";
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn.Visible = false;
            this.ogrVeliAdSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrVeliTelefonDataGridViewTextBoxColumn
            // 
            this.ogrVeliTelefonDataGridViewTextBoxColumn.DataPropertyName = "OgrVeliTelefon";
            this.ogrVeliTelefonDataGridViewTextBoxColumn.HeaderText = "OgrVeliTelefon";
            this.ogrVeliTelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrVeliTelefonDataGridViewTextBoxColumn.Name = "ogrVeliTelefonDataGridViewTextBoxColumn";
            this.ogrVeliTelefonDataGridViewTextBoxColumn.Visible = false;
            this.ogrVeliTelefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrVeliAdresDataGridViewTextBoxColumn
            // 
            this.ogrVeliAdresDataGridViewTextBoxColumn.DataPropertyName = "OgrVeliAdres";
            this.ogrVeliAdresDataGridViewTextBoxColumn.HeaderText = "OgrVeliAdres";
            this.ogrVeliAdresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrVeliAdresDataGridViewTextBoxColumn.Name = "ogrVeliAdresDataGridViewTextBoxColumn";
            this.ogrVeliAdresDataGridViewTextBoxColumn.Visible = false;
            this.ogrVeliAdresDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "Ogrenci";
            this.ogrenciBindingSource.DataSource = this.yurtOtomasyonuDataSet4;
            // 
            // yurtOtomasyonuDataSet4
            // 
            this.yurtOtomasyonuDataSet4.DataSetName = "YurtOtomasyonuDataSet4";
            this.yurtOtomasyonuDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // FrmOgrListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 399);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmOgrListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Listesi";
            this.Load += new System.EventHandler(this.FrmOgrListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet4 yurtOtomasyonuDataSet4;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private YurtOtomasyonuDataSet4TableAdapters.OgrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrBolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrDogumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrOdaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrVeliAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrVeliTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrVeliAdresDataGridViewTextBoxColumn;
    }
}