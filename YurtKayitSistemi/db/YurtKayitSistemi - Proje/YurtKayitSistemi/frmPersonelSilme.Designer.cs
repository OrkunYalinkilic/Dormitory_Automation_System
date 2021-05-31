namespace YurtKayitSistemi
{
    partial class frmPersonelSilme
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
            this.tblUrunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet35 = new YurtKayitSistemi.YurtOtomasyonuDataSet35();
            this.label1 = new System.Windows.Forms.Label();
            this.tblUrunlerTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSet35TableAdapters.tblUrunlerTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yurtOtomasyonuDataSet39 = new YurtKayitSistemi.YurtOtomasyonuDataSet39();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPersonelTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSet39TableAdapters.tblPersonelTableAdapter();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "SİLİNECEK PERSONELİ SEÇİNİZ";
            // 
            // tblUrunlerTableAdapter
            // 
            this.tblUrunlerTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(113, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "PERSONEL SİL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelIDDataGridViewTextBoxColumn,
            this.personelAdSoyadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 226);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yurtOtomasyonuDataSet39
            // 
            this.yurtOtomasyonuDataSet39.DataSetName = "YurtOtomasyonuDataSet39";
            this.yurtOtomasyonuDataSet39.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "tblPersonel";
            this.tblPersonelBindingSource.DataSource = this.yurtOtomasyonuDataSet39;
            // 
            // tblPersonelTableAdapter
            // 
            this.tblPersonelTableAdapter.ClearBeforeFill = true;
            // 
            // personelIDDataGridViewTextBoxColumn
            // 
            this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "personelID";
            this.personelIDDataGridViewTextBoxColumn.HeaderText = "personel ID";
            this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
            this.personelIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personelIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // personelAdSoyadDataGridViewTextBoxColumn
            // 
            this.personelAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "personelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.HeaderText = "Ad Soyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.Name = "personelAdSoyadDataGridViewTextBoxColumn";
            this.personelAdSoyadDataGridViewTextBoxColumn.Width = 150;
            // 
            // frmPersonelSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 361);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPersonelSilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Silme";
            this.Load += new System.EventHandler(this.frmPersonelSilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tblUrunlerBindingSource;
        private YurtOtomasyonuDataSet35 yurtOtomasyonuDataSet35;
        private System.Windows.Forms.Label label1;
        private YurtOtomasyonuDataSet35TableAdapters.tblUrunlerTableAdapter tblUrunlerTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet39 yurtOtomasyonuDataSet39;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private YurtOtomasyonuDataSet39TableAdapters.tblPersonelTableAdapter tblPersonelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdSoyadDataGridViewTextBoxColumn;
    }
}