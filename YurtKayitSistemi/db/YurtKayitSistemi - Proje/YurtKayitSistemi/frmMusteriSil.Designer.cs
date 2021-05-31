namespace YurtKayitSistemi
{
    partial class frmMusteriSil
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
            this.btnSil = new System.Windows.Forms.Button();
            this.yurtOtomasyonuDataSet37 = new YurtKayitSistemi.YurtOtomasyonuDataSet37();
            this.tblMusteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblMusteriTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSet37TableAdapters.tblMusteriTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yurtOtomasyonuDataSet38 = new YurtKayitSistemi.YurtOtomasyonuDataSet38();
            this.tblMusteriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblMusteriTableAdapter1 = new YurtKayitSistemi.YurtOtomasyonuDataSet38TableAdapters.tblMusteriTableAdapter();
            this.musteriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriSoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "SİLMEK İSTEDİĞİNİZ MÜŞTERİYİ SEÇİNİZ";
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(122, 248);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(175, 46);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "MÜŞTERİ SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // yurtOtomasyonuDataSet37
            // 
            this.yurtOtomasyonuDataSet37.DataSetName = "YurtOtomasyonuDataSet37";
            this.yurtOtomasyonuDataSet37.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMusteriBindingSource
            // 
            this.tblMusteriBindingSource.DataMember = "tblMusteri";
            this.tblMusteriBindingSource.DataSource = this.yurtOtomasyonuDataSet37;
            // 
            // tblMusteriTableAdapter
            // 
            this.tblMusteriTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriIDDataGridViewTextBoxColumn,
            this.musteriAdiDataGridViewTextBoxColumn,
            this.musteriSoyadiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblMusteriBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(34, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(374, 190);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yurtOtomasyonuDataSet38
            // 
            this.yurtOtomasyonuDataSet38.DataSetName = "YurtOtomasyonuDataSet38";
            this.yurtOtomasyonuDataSet38.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMusteriBindingSource1
            // 
            this.tblMusteriBindingSource1.DataMember = "tblMusteri";
            this.tblMusteriBindingSource1.DataSource = this.yurtOtomasyonuDataSet38;
            // 
            // tblMusteriTableAdapter1
            // 
            this.tblMusteriTableAdapter1.ClearBeforeFill = true;
            // 
            // musteriIDDataGridViewTextBoxColumn
            // 
            this.musteriIDDataGridViewTextBoxColumn.DataPropertyName = "musteriID";
            this.musteriIDDataGridViewTextBoxColumn.HeaderText = "musteri ID";
            this.musteriIDDataGridViewTextBoxColumn.Name = "musteriIDDataGridViewTextBoxColumn";
            this.musteriIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musteriAdiDataGridViewTextBoxColumn
            // 
            this.musteriAdiDataGridViewTextBoxColumn.DataPropertyName = "musteriAdi";
            this.musteriAdiDataGridViewTextBoxColumn.HeaderText = "Adi";
            this.musteriAdiDataGridViewTextBoxColumn.Name = "musteriAdiDataGridViewTextBoxColumn";
            // 
            // musteriSoyadiDataGridViewTextBoxColumn
            // 
            this.musteriSoyadiDataGridViewTextBoxColumn.DataPropertyName = "musteriSoyadi";
            this.musteriSoyadiDataGridViewTextBoxColumn.HeaderText = "Soyadi";
            this.musteriSoyadiDataGridViewTextBoxColumn.Name = "musteriSoyadiDataGridViewTextBoxColumn";
            // 
            // frmMusteriSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 315);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMusteriSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musteri Silme";
            this.Load += new System.EventHandler(this.frmMusteriSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSil;
        private YurtOtomasyonuDataSet37 yurtOtomasyonuDataSet37;
        private System.Windows.Forms.BindingSource tblMusteriBindingSource;
        private YurtOtomasyonuDataSet37TableAdapters.tblMusteriTableAdapter tblMusteriTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet38 yurtOtomasyonuDataSet38;
        private System.Windows.Forms.BindingSource tblMusteriBindingSource1;
        private YurtOtomasyonuDataSet38TableAdapters.tblMusteriTableAdapter tblMusteriTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriSoyadiDataGridViewTextBoxColumn;
    }
}