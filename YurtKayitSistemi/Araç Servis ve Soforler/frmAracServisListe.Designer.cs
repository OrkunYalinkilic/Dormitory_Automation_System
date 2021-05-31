namespace YurtKayitSistemi
{
    partial class frmAracServisListe
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
            this.ogrenciTableAdapter1 = new YurtKayitSistemi.YurtOtomasyonuDataSet14TableAdapters.OgrenciTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.yurtOtomasyonuDataSet29 = new YurtKayitSistemi.YurtOtomasyonuDataSet29();
            this.servisSaatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servisSaatTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSet29TableAdapters.ServisSaatTableAdapter();
            this.gunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisSaatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ogrenciTableAdapter1
            // 
            this.ogrenciTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gunAdiDataGridViewTextBoxColumn,
            this.saatiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.servisSaatBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(415, 268);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(79, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "ARAÇ SERVİS SAATLERİ";
            // 
            // yurtOtomasyonuDataSet29
            // 
            this.yurtOtomasyonuDataSet29.DataSetName = "YurtOtomasyonuDataSet29";
            this.yurtOtomasyonuDataSet29.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servisSaatBindingSource
            // 
            this.servisSaatBindingSource.DataMember = "ServisSaat";
            this.servisSaatBindingSource.DataSource = this.yurtOtomasyonuDataSet29;
            // 
            // servisSaatTableAdapter
            // 
            this.servisSaatTableAdapter.ClearBeforeFill = true;
            // 
            // gunAdiDataGridViewTextBoxColumn
            // 
            this.gunAdiDataGridViewTextBoxColumn.DataPropertyName = "GunAdi";
            this.gunAdiDataGridViewTextBoxColumn.HeaderText = "GÜN ADI";
            this.gunAdiDataGridViewTextBoxColumn.Name = "gunAdiDataGridViewTextBoxColumn";
            this.gunAdiDataGridViewTextBoxColumn.Width = 170;
            // 
            // saatiDataGridViewTextBoxColumn
            // 
            this.saatiDataGridViewTextBoxColumn.DataPropertyName = "Saati";
            this.saatiDataGridViewTextBoxColumn.HeaderText = "SERVİS SAATİ";
            this.saatiDataGridViewTextBoxColumn.Name = "saatiDataGridViewTextBoxColumn";
            this.saatiDataGridViewTextBoxColumn.Width = 200;
            // 
            // frmAracServisListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAracServisListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arac Servis Listesi";
            this.Load += new System.EventHandler(this.frmAracServisListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisSaatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private YurtOtomasyonuDataSet14TableAdapters.OgrenciTableAdapter ogrenciTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private YurtOtomasyonuDataSet29 yurtOtomasyonuDataSet29;
        private System.Windows.Forms.BindingSource servisSaatBindingSource;
        private YurtOtomasyonuDataSet29TableAdapters.ServisSaatTableAdapter servisSaatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saatiDataGridViewTextBoxColumn;
    }
}