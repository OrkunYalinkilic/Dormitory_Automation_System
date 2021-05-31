namespace YurtKayitSistemi
{
    partial class frmSoforListecs
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
            this.yurtOtomasyonuDataSet28 = new YurtKayitSistemi.YurtOtomasyonuDataSet28();
            this.soforlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soforlerTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSet28TableAdapters.SoforlerTableAdapter();
            this.soforIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soforAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soforSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soforTCKimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soforYasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soforTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soforlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soforIdDataGridViewTextBoxColumn,
            this.soforAdDataGridViewTextBoxColumn,
            this.soforSoyadDataGridViewTextBoxColumn,
            this.soforTCKimlikDataGridViewTextBoxColumn,
            this.soforYasDataGridViewTextBoxColumn,
            this.soforTelefonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.soforlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(921, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(338, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "ŞOFÖRLER LİSTESİ";
            // 
            // yurtOtomasyonuDataSet28
            // 
            this.yurtOtomasyonuDataSet28.DataSetName = "YurtOtomasyonuDataSet28";
            this.yurtOtomasyonuDataSet28.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soforlerBindingSource
            // 
            this.soforlerBindingSource.DataMember = "Soforler";
            this.soforlerBindingSource.DataSource = this.yurtOtomasyonuDataSet28;
            // 
            // soforlerTableAdapter
            // 
            this.soforlerTableAdapter.ClearBeforeFill = true;
            // 
            // soforIdDataGridViewTextBoxColumn
            // 
            this.soforIdDataGridViewTextBoxColumn.DataPropertyName = "SoforId";
            this.soforIdDataGridViewTextBoxColumn.HeaderText = "Sofor Id";
            this.soforIdDataGridViewTextBoxColumn.Name = "soforIdDataGridViewTextBoxColumn";
            this.soforIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soforAdDataGridViewTextBoxColumn
            // 
            this.soforAdDataGridViewTextBoxColumn.DataPropertyName = "SoforAd";
            this.soforAdDataGridViewTextBoxColumn.HeaderText = "Sofor Ad";
            this.soforAdDataGridViewTextBoxColumn.Name = "soforAdDataGridViewTextBoxColumn";
            this.soforAdDataGridViewTextBoxColumn.Width = 120;
            // 
            // soforSoyadDataGridViewTextBoxColumn
            // 
            this.soforSoyadDataGridViewTextBoxColumn.DataPropertyName = "SoforSoyad";
            this.soforSoyadDataGridViewTextBoxColumn.HeaderText = "Sofor Soyad";
            this.soforSoyadDataGridViewTextBoxColumn.Name = "soforSoyadDataGridViewTextBoxColumn";
            this.soforSoyadDataGridViewTextBoxColumn.Width = 130;
            // 
            // soforTCKimlikDataGridViewTextBoxColumn
            // 
            this.soforTCKimlikDataGridViewTextBoxColumn.DataPropertyName = "SoforTCKimlik";
            this.soforTCKimlikDataGridViewTextBoxColumn.HeaderText = "Sofor TC Kimlik";
            this.soforTCKimlikDataGridViewTextBoxColumn.Name = "soforTCKimlikDataGridViewTextBoxColumn";
            this.soforTCKimlikDataGridViewTextBoxColumn.Width = 200;
            // 
            // soforYasDataGridViewTextBoxColumn
            // 
            this.soforYasDataGridViewTextBoxColumn.DataPropertyName = "SoforYas";
            this.soforYasDataGridViewTextBoxColumn.HeaderText = "Sofor Yas";
            this.soforYasDataGridViewTextBoxColumn.Name = "soforYasDataGridViewTextBoxColumn";
            this.soforYasDataGridViewTextBoxColumn.Width = 120;
            // 
            // soforTelefonDataGridViewTextBoxColumn
            // 
            this.soforTelefonDataGridViewTextBoxColumn.DataPropertyName = "SoforTelefon";
            this.soforTelefonDataGridViewTextBoxColumn.HeaderText = "Sofor Telefon";
            this.soforTelefonDataGridViewTextBoxColumn.Name = "soforTelefonDataGridViewTextBoxColumn";
            this.soforTelefonDataGridViewTextBoxColumn.Width = 200;
            // 
            // frmSoforListecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSoforListecs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şoförler Listesi";
            this.Load += new System.EventHandler(this.frmSoforListecs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soforlerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private YurtOtomasyonuDataSet28 yurtOtomasyonuDataSet28;
        private System.Windows.Forms.BindingSource soforlerBindingSource;
        private YurtOtomasyonuDataSet28TableAdapters.SoforlerTableAdapter soforlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn soforIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soforAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soforSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soforTCKimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soforYasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soforTelefonDataGridViewTextBoxColumn;
    }
}