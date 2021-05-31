namespace YurtKayitSistemi
{
    partial class frmUrunSilme
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
            this.label1 = new System.Windows.Forms.Label();
            this.yurtOtomasyonuDataSet35 = new YurtKayitSistemi.YurtOtomasyonuDataSet35();
            this.tblUrunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUrunlerTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSet35TableAdapters.tblUrunlerTableAdapter();
            this.urunIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunMarkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunIDDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.urunMarkaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblUrunlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(356, 238);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(76, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "SİLİNECEK ÜRÜNÜ SEÇİNİZ";
            // 
            // yurtOtomasyonuDataSet35
            // 
            this.yurtOtomasyonuDataSet35.DataSetName = "YurtOtomasyonuDataSet35";
            this.yurtOtomasyonuDataSet35.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUrunlerBindingSource
            // 
            this.tblUrunlerBindingSource.DataMember = "tblUrunler";
            this.tblUrunlerBindingSource.DataSource = this.yurtOtomasyonuDataSet35;
            // 
            // tblUrunlerTableAdapter
            // 
            this.tblUrunlerTableAdapter.ClearBeforeFill = true;
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(125, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "ÜRÜN SİL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // frmUrunSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 360);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUrunSilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urun Silme";
            this.Load += new System.EventHandler(this.frmUrunSilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunlerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private YurtOtomasyonuDataSet35 yurtOtomasyonuDataSet35;
        private System.Windows.Forms.BindingSource tblUrunlerBindingSource;
        private YurtOtomasyonuDataSet35TableAdapters.tblUrunlerTableAdapter tblUrunlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunMarkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}