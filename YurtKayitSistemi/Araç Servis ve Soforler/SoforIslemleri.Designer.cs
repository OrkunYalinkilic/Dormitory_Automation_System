namespace YurtKayitSistemi
{
    partial class SoforIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoforIslemleri));
            this.soforlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet27 = new YurtKayitSistemi.YurtOtomasyonuDataSet27();
            this.soforlerTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSet27TableAdapters.SoforlerTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSoforSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSoforAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoforID = new System.Windows.Forms.TextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.soforIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soforAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soforSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soforTCKimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soforYasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soforTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soforlerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet33 = new YurtKayitSistemi.YurtOtomasyonuDataSet33();
            this.soforlerTableAdapter1 = new YurtKayitSistemi.YurtOtomasyonuDataSet33TableAdapters.SoforlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.soforlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soforlerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet33)).BeginInit();
            this.SuspendLayout();
            // 
            // soforlerBindingSource
            // 
            this.soforlerBindingSource.DataMember = "Soforler";
            this.soforlerBindingSource.DataSource = this.yurtOtomasyonuDataSet27;
            // 
            // yurtOtomasyonuDataSet27
            // 
            this.yurtOtomasyonuDataSet27.DataSetName = "YurtOtomasyonuDataSet27";
            this.yurtOtomasyonuDataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soforlerTableAdapter
            // 
            this.soforlerTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Silmek istediğiniz şoförü listeden seçiniz.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtSoforSoyad
            // 
            this.TxtSoforSoyad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtSoforSoyad.Enabled = false;
            this.TxtSoforSoyad.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoforSoyad.Location = new System.Drawing.Point(398, 117);
            this.TxtSoforSoyad.Name = "TxtSoforSoyad";
            this.TxtSoforSoyad.Size = new System.Drawing.Size(249, 28);
            this.TxtSoforSoyad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(276, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Şoför Soyad:";
            // 
            // TxtSoforAd
            // 
            this.TxtSoforAd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtSoforAd.Enabled = false;
            this.TxtSoforAd.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoforAd.Location = new System.Drawing.Point(398, 83);
            this.TxtSoforAd.Name = "TxtSoforAd";
            this.TxtSoforAd.Size = new System.Drawing.Size(249, 28);
            this.TxtSoforAd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(303, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Şoför Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(303, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Şoför ID:";
            // 
            // txtSoforID
            // 
            this.txtSoforID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSoforID.Enabled = false;
            this.txtSoforID.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoforID.Location = new System.Drawing.Point(398, 49);
            this.txtSoforID.Name = "txtSoforID";
            this.txtSoforID.Size = new System.Drawing.Size(249, 28);
            this.txtSoforID.TabIndex = 0;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(455, 165);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(133, 43);
            this.BtnKaydet.TabIndex = 3;
            this.BtnKaydet.Text = "SİL";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
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
            this.dataGridView1.DataSource = this.soforlerBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(666, 320);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // soforIdDataGridViewTextBoxColumn
            // 
            this.soforIdDataGridViewTextBoxColumn.DataPropertyName = "SoforId";
            this.soforIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.soforIdDataGridViewTextBoxColumn.Name = "soforIdDataGridViewTextBoxColumn";
            this.soforIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.soforIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // soforAdDataGridViewTextBoxColumn
            // 
            this.soforAdDataGridViewTextBoxColumn.DataPropertyName = "SoforAd";
            this.soforAdDataGridViewTextBoxColumn.HeaderText = "Adı";
            this.soforAdDataGridViewTextBoxColumn.Name = "soforAdDataGridViewTextBoxColumn";
            this.soforAdDataGridViewTextBoxColumn.Width = 225;
            // 
            // soforSoyadDataGridViewTextBoxColumn
            // 
            this.soforSoyadDataGridViewTextBoxColumn.DataPropertyName = "SoforSoyad";
            this.soforSoyadDataGridViewTextBoxColumn.HeaderText = "Soyadı";
            this.soforSoyadDataGridViewTextBoxColumn.Name = "soforSoyadDataGridViewTextBoxColumn";
            this.soforSoyadDataGridViewTextBoxColumn.Width = 225;
            // 
            // soforTCKimlikDataGridViewTextBoxColumn
            // 
            this.soforTCKimlikDataGridViewTextBoxColumn.DataPropertyName = "SoforTCKimlik";
            this.soforTCKimlikDataGridViewTextBoxColumn.HeaderText = "SoforTCKimlik";
            this.soforTCKimlikDataGridViewTextBoxColumn.Name = "soforTCKimlikDataGridViewTextBoxColumn";
            this.soforTCKimlikDataGridViewTextBoxColumn.Visible = false;
            // 
            // soforYasDataGridViewTextBoxColumn
            // 
            this.soforYasDataGridViewTextBoxColumn.DataPropertyName = "SoforYas";
            this.soforYasDataGridViewTextBoxColumn.HeaderText = "SoforYas";
            this.soforYasDataGridViewTextBoxColumn.Name = "soforYasDataGridViewTextBoxColumn";
            this.soforYasDataGridViewTextBoxColumn.Visible = false;
            // 
            // soforTelefonDataGridViewTextBoxColumn
            // 
            this.soforTelefonDataGridViewTextBoxColumn.DataPropertyName = "SoforTelefon";
            this.soforTelefonDataGridViewTextBoxColumn.HeaderText = "SoforTelefon";
            this.soforTelefonDataGridViewTextBoxColumn.Name = "soforTelefonDataGridViewTextBoxColumn";
            this.soforTelefonDataGridViewTextBoxColumn.Visible = false;
            // 
            // soforlerBindingSource1
            // 
            this.soforlerBindingSource1.DataMember = "Soforler";
            this.soforlerBindingSource1.DataSource = this.yurtOtomasyonuDataSet33;
            // 
            // yurtOtomasyonuDataSet33
            // 
            this.yurtOtomasyonuDataSet33.DataSetName = "YurtOtomasyonuDataSet33";
            this.yurtOtomasyonuDataSet33.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soforlerTableAdapter1
            // 
            this.soforlerTableAdapter1.ClearBeforeFill = true;
            // 
            // SoforIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 608);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.TxtSoforSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoforID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSoforAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SoforIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sofor Islemleri";
            this.Load += new System.EventHandler(this.SoforIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.soforlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soforlerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet33)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private YurtOtomasyonuDataSet27 yurtOtomasyonuDataSet27;
        private System.Windows.Forms.BindingSource soforlerBindingSource;
        private YurtOtomasyonuDataSet27TableAdapters.SoforlerTableAdapter soforlerTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSoforSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSoforAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoforID;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet33 yurtOtomasyonuDataSet33;
        private System.Windows.Forms.BindingSource soforlerBindingSource1;
        private YurtOtomasyonuDataSet33TableAdapters.SoforlerTableAdapter soforlerTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn soforIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soforAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soforSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soforTCKimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soforYasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soforTelefonDataGridViewTextBoxColumn;
    }
}