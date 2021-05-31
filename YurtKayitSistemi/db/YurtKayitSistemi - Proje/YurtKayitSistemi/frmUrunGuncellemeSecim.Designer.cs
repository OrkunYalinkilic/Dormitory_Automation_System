namespace YurtKayitSistemi
{
    partial class frmUrunGuncellemeSecim
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunMarkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblUrunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet35 = new YurtKayitSistemi.YurtOtomasyonuDataSet35();
            this.tblUrunlerTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSet35TableAdapters.tblUrunlerTableAdapter();
            this.yurtOtomasyonuDataSet36 = new YurtKayitSistemi.YurtOtomasyonuDataSet36();
            this.tblUrunlerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblUrunlerTableAdapter1 = new YurtKayitSistemi.YurtOtomasyonuDataSet36TableAdapters.tblUrunlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunlerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "GÜNCELLENECEK ÜRÜNÜ SEÇİNİZ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunIDDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.urunMarkaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblUrunlerBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(30, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(356, 238);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // urunIDDataGridViewTextBoxColumn
            // 
            this.urunIDDataGridViewTextBoxColumn.DataPropertyName = "urunID";
            this.urunIDDataGridViewTextBoxColumn.HeaderText = "urun ID";
            this.urunIDDataGridViewTextBoxColumn.Name = "urunIDDataGridViewTextBoxColumn";
            this.urunIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "urunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "Adi";
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            // 
            // urunMarkaDataGridViewTextBoxColumn
            // 
            this.urunMarkaDataGridViewTextBoxColumn.DataPropertyName = "urunMarka";
            this.urunMarkaDataGridViewTextBoxColumn.HeaderText = "Marka";
            this.urunMarkaDataGridViewTextBoxColumn.Name = "urunMarkaDataGridViewTextBoxColumn";
            // 
            // tblUrunlerBindingSource
            // 
            this.tblUrunlerBindingSource.DataMember = "tblUrunler";
            this.tblUrunlerBindingSource.DataSource = this.yurtOtomasyonuDataSet35;
            // 
            // yurtOtomasyonuDataSet35
            // 
            this.yurtOtomasyonuDataSet35.DataSetName = "YurtOtomasyonuDataSet35";
            this.yurtOtomasyonuDataSet35.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUrunlerTableAdapter
            // 
            this.tblUrunlerTableAdapter.ClearBeforeFill = true;
            // 
            // yurtOtomasyonuDataSet36
            // 
            this.yurtOtomasyonuDataSet36.DataSetName = "YurtOtomasyonuDataSet36";
            this.yurtOtomasyonuDataSet36.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUrunlerBindingSource1
            // 
            this.tblUrunlerBindingSource1.DataMember = "tblUrunler";
            this.tblUrunlerBindingSource1.DataSource = this.yurtOtomasyonuDataSet36;
            // 
            // tblUrunlerTableAdapter1
            // 
            this.tblUrunlerTableAdapter1.ClearBeforeFill = true;
            // 
            // frmUrunGuncellemeSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 323);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUrunGuncellemeSecim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urun Guncelleme Secim";
            this.Load += new System.EventHandler(this.frmUrunGuncellemeSecim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunlerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunMarkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblUrunlerBindingSource;
        private YurtOtomasyonuDataSet35 yurtOtomasyonuDataSet35;
        private YurtOtomasyonuDataSet35TableAdapters.tblUrunlerTableAdapter tblUrunlerTableAdapter;
        private YurtOtomasyonuDataSet36 yurtOtomasyonuDataSet36;
        private System.Windows.Forms.BindingSource tblUrunlerBindingSource1;
        private YurtOtomasyonuDataSet36TableAdapters.tblUrunlerTableAdapter tblUrunlerTableAdapter1;
    }
}