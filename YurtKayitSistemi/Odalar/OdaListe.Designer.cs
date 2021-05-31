namespace YurtKayitSistemi
{
    partial class OdaListe
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
            this.yurtOtomasyonuDataSet20 = new YurtKayitSistemi.YurtOtomasyonuDataSet20();
            this.odalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odalarTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSet20TableAdapters.OdalarTableAdapter();
            this.yurtOtomasyonuDataSet21 = new YurtKayitSistemi.YurtOtomasyonuDataSet21();
            this.odalarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.odalarTableAdapter1 = new YurtKayitSistemi.YurtOtomasyonuDataSet21TableAdapters.OdalarTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.odaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaKapasiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaAktifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaDurumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odalarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet22 = new YurtKayitSistemi.YurtOtomasyonuDataSet22();
            this.odalarTableAdapter2 = new YurtKayitSistemi.YurtOtomasyonuDataSet22TableAdapters.OdalarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet22)).BeginInit();
            this.SuspendLayout();
            // 
            // yurtOtomasyonuDataSet20
            // 
            this.yurtOtomasyonuDataSet20.DataSetName = "YurtOtomasyonuDataSet20";
            this.yurtOtomasyonuDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odalarBindingSource
            // 
            this.odalarBindingSource.DataMember = "Odalar";
            this.odalarBindingSource.DataSource = this.yurtOtomasyonuDataSet20;
            // 
            // odalarTableAdapter
            // 
            this.odalarTableAdapter.ClearBeforeFill = true;
            // 
            // yurtOtomasyonuDataSet21
            // 
            this.yurtOtomasyonuDataSet21.DataSetName = "YurtOtomasyonuDataSet21";
            this.yurtOtomasyonuDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odalarBindingSource1
            // 
            this.odalarBindingSource1.DataMember = "Odalar";
            this.odalarBindingSource1.DataSource = this.yurtOtomasyonuDataSet21;
            // 
            // odalarTableAdapter1
            // 
            this.odalarTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odaIDDataGridViewTextBoxColumn,
            this.odaNoDataGridViewTextBoxColumn,
            this.odaKapasiteDataGridViewTextBoxColumn,
            this.odaAktifDataGridViewTextBoxColumn,
            this.odaDurumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.odalarBindingSource2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(754, 360);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // odaIDDataGridViewTextBoxColumn
            // 
            this.odaIDDataGridViewTextBoxColumn.DataPropertyName = "OdaID";
            this.odaIDDataGridViewTextBoxColumn.HeaderText = "Oda ID";
            this.odaIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odaIDDataGridViewTextBoxColumn.Name = "odaIDDataGridViewTextBoxColumn";
            this.odaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.odaIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // odaNoDataGridViewTextBoxColumn
            // 
            this.odaNoDataGridViewTextBoxColumn.DataPropertyName = "OdaNo";
            this.odaNoDataGridViewTextBoxColumn.HeaderText = "Oda Numarası";
            this.odaNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odaNoDataGridViewTextBoxColumn.Name = "odaNoDataGridViewTextBoxColumn";
            this.odaNoDataGridViewTextBoxColumn.Width = 140;
            // 
            // odaKapasiteDataGridViewTextBoxColumn
            // 
            this.odaKapasiteDataGridViewTextBoxColumn.DataPropertyName = "OdaKapasite";
            this.odaKapasiteDataGridViewTextBoxColumn.HeaderText = "Oda Kapasitesi";
            this.odaKapasiteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odaKapasiteDataGridViewTextBoxColumn.Name = "odaKapasiteDataGridViewTextBoxColumn";
            this.odaKapasiteDataGridViewTextBoxColumn.Width = 140;
            // 
            // odaAktifDataGridViewTextBoxColumn
            // 
            this.odaAktifDataGridViewTextBoxColumn.DataPropertyName = "OdaAktif";
            this.odaAktifDataGridViewTextBoxColumn.HeaderText = "Oda Kalan Kişi Sayısı";
            this.odaAktifDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odaAktifDataGridViewTextBoxColumn.Name = "odaAktifDataGridViewTextBoxColumn";
            this.odaAktifDataGridViewTextBoxColumn.Width = 200;
            // 
            // odaDurumDataGridViewTextBoxColumn
            // 
            this.odaDurumDataGridViewTextBoxColumn.DataPropertyName = "OdaDurum";
            this.odaDurumDataGridViewTextBoxColumn.HeaderText = "Oda Durumu";
            this.odaDurumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odaDurumDataGridViewTextBoxColumn.Name = "odaDurumDataGridViewTextBoxColumn";
            this.odaDurumDataGridViewTextBoxColumn.Width = 120;
            // 
            // odalarBindingSource2
            // 
            this.odalarBindingSource2.DataMember = "Odalar";
            this.odalarBindingSource2.DataSource = this.yurtOtomasyonuDataSet22;
            // 
            // yurtOtomasyonuDataSet22
            // 
            this.yurtOtomasyonuDataSet22.DataSetName = "YurtOtomasyonuDataSet22";
            this.yurtOtomasyonuDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odalarTableAdapter2
            // 
            this.odalarTableAdapter2.ClearBeforeFill = true;
            // 
            // OdaListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 360);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OdaListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oda Listesi";
            this.Load += new System.EventHandler(this.OdaListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet22)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private YurtOtomasyonuDataSet20 yurtOtomasyonuDataSet20;
        private System.Windows.Forms.BindingSource odalarBindingSource;
        private YurtOtomasyonuDataSet20TableAdapters.OdalarTableAdapter odalarTableAdapter;
        private YurtOtomasyonuDataSet21 yurtOtomasyonuDataSet21;
        private System.Windows.Forms.BindingSource odalarBindingSource1;
        private YurtOtomasyonuDataSet21TableAdapters.OdalarTableAdapter odalarTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet22 yurtOtomasyonuDataSet22;
        private System.Windows.Forms.BindingSource odalarBindingSource2;
        private YurtOtomasyonuDataSet22TableAdapters.OdalarTableAdapter odalarTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaKapasiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaAktifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaDurumDataGridViewTextBoxColumn;
    }
}