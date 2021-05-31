namespace YurtKayitSistemi
{
    partial class frmDuyuruGoruntule
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yurtOtomasyonuDataSet34 = new YurtKayitSistemi.YurtOtomasyonuDataSet34();
            this.duyurularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duyurularTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSet34TableAdapters.DuyurularTableAdapter();
            this.duyuruBaslikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duyuruicerikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duyurularBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.duyuruBaslikDataGridViewTextBoxColumn,
            this.duyuruicerikDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.duyurularBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(409, 270);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // yurtOtomasyonuDataSet34
            // 
            this.yurtOtomasyonuDataSet34.DataSetName = "YurtOtomasyonuDataSet34";
            this.yurtOtomasyonuDataSet34.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // duyurularBindingSource
            // 
            this.duyurularBindingSource.DataMember = "Duyurular";
            this.duyurularBindingSource.DataSource = this.yurtOtomasyonuDataSet34;
            // 
            // duyurularTableAdapter
            // 
            this.duyurularTableAdapter.ClearBeforeFill = true;
            // 
            // duyuruBaslikDataGridViewTextBoxColumn
            // 
            this.duyuruBaslikDataGridViewTextBoxColumn.DataPropertyName = "duyuruBaslik";
            this.duyuruBaslikDataGridViewTextBoxColumn.HeaderText = "Duyuru Başlığı";
            this.duyuruBaslikDataGridViewTextBoxColumn.Name = "duyuruBaslikDataGridViewTextBoxColumn";
            this.duyuruBaslikDataGridViewTextBoxColumn.Width = 350;
            // 
            // duyuruicerikDataGridViewTextBoxColumn
            // 
            this.duyuruicerikDataGridViewTextBoxColumn.DataPropertyName = "duyuruicerik";
            this.duyuruicerikDataGridViewTextBoxColumn.HeaderText = "duyuruicerik";
            this.duyuruicerikDataGridViewTextBoxColumn.Name = "duyuruicerikDataGridViewTextBoxColumn";
            this.duyuruicerikDataGridViewTextBoxColumn.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Görüntülemek istediğiniz duyuruyu seçiniz..";
            // 
            // frmDuyuruGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDuyuruGoruntule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duyuru Goruntuleme";
            this.Load += new System.EventHandler(this.frmDuyuruGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duyurularBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet34 yurtOtomasyonuDataSet34;
        private System.Windows.Forms.BindingSource duyurularBindingSource;
        private YurtOtomasyonuDataSet34TableAdapters.DuyurularTableAdapter duyurularTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn duyuruBaslikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duyuruicerikDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}