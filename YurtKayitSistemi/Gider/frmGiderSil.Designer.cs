namespace YurtKayitSistemi
{
    partial class frmGiderSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiderSil));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiderID = new System.Windows.Forms.TextBox();
            this.btnGiderSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.odemeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elektrikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogalgazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ınternetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.digerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giderlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet16 = new YurtKayitSistemi.YurtOtomasyonuDataSet16();
            this.giderlerTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSet16TableAdapters.GiderlerTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(212, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(421, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gider ID: ";
            // 
            // txtGiderID
            // 
            this.txtGiderID.Enabled = false;
            this.txtGiderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGiderID.Location = new System.Drawing.Point(515, 54);
            this.txtGiderID.Name = "txtGiderID";
            this.txtGiderID.Size = new System.Drawing.Size(196, 30);
            this.txtGiderID.TabIndex = 0;
            // 
            // btnGiderSil
            // 
            this.btnGiderSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiderSil.Location = new System.Drawing.Point(453, 94);
            this.btnGiderSil.Name = "btnGiderSil";
            this.btnGiderSil.Size = new System.Drawing.Size(224, 43);
            this.btnGiderSil.TabIndex = 1;
            this.btnGiderSil.Text = "GİDER SİL";
            this.btnGiderSil.UseVisualStyleBackColor = true;
            this.btnGiderSil.Click += new System.EventHandler(this.btnGiderSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odemeIDDataGridViewTextBoxColumn,
            this.elektrikDataGridViewTextBoxColumn,
            this.suDataGridViewTextBoxColumn,
            this.dogalgazDataGridViewTextBoxColumn,
            this.ınternetDataGridViewTextBoxColumn,
            this.gidaDataGridViewTextBoxColumn,
            this.personelDataGridViewTextBoxColumn,
            this.digerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.giderlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(875, 242);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // odemeIDDataGridViewTextBoxColumn
            // 
            this.odemeIDDataGridViewTextBoxColumn.DataPropertyName = "OdemeID";
            this.odemeIDDataGridViewTextBoxColumn.HeaderText = "Ödeme ID";
            this.odemeIDDataGridViewTextBoxColumn.Name = "odemeIDDataGridViewTextBoxColumn";
            this.odemeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.odemeIDDataGridViewTextBoxColumn.Width = 130;
            // 
            // elektrikDataGridViewTextBoxColumn
            // 
            this.elektrikDataGridViewTextBoxColumn.DataPropertyName = "Elektrik";
            this.elektrikDataGridViewTextBoxColumn.HeaderText = "Elektrik";
            this.elektrikDataGridViewTextBoxColumn.Name = "elektrikDataGridViewTextBoxColumn";
            // 
            // suDataGridViewTextBoxColumn
            // 
            this.suDataGridViewTextBoxColumn.DataPropertyName = "Su";
            this.suDataGridViewTextBoxColumn.HeaderText = "Su";
            this.suDataGridViewTextBoxColumn.Name = "suDataGridViewTextBoxColumn";
            // 
            // dogalgazDataGridViewTextBoxColumn
            // 
            this.dogalgazDataGridViewTextBoxColumn.DataPropertyName = "Dogalgaz";
            this.dogalgazDataGridViewTextBoxColumn.HeaderText = "Dogalgaz";
            this.dogalgazDataGridViewTextBoxColumn.Name = "dogalgazDataGridViewTextBoxColumn";
            // 
            // ınternetDataGridViewTextBoxColumn
            // 
            this.ınternetDataGridViewTextBoxColumn.DataPropertyName = "Internet";
            this.ınternetDataGridViewTextBoxColumn.HeaderText = "Internet";
            this.ınternetDataGridViewTextBoxColumn.Name = "ınternetDataGridViewTextBoxColumn";
            // 
            // gidaDataGridViewTextBoxColumn
            // 
            this.gidaDataGridViewTextBoxColumn.DataPropertyName = "Gida";
            this.gidaDataGridViewTextBoxColumn.HeaderText = "Gida";
            this.gidaDataGridViewTextBoxColumn.Name = "gidaDataGridViewTextBoxColumn";
            // 
            // personelDataGridViewTextBoxColumn
            // 
            this.personelDataGridViewTextBoxColumn.DataPropertyName = "Personel";
            this.personelDataGridViewTextBoxColumn.HeaderText = "Personel";
            this.personelDataGridViewTextBoxColumn.Name = "personelDataGridViewTextBoxColumn";
            // 
            // digerDataGridViewTextBoxColumn
            // 
            this.digerDataGridViewTextBoxColumn.DataPropertyName = "Diger";
            this.digerDataGridViewTextBoxColumn.HeaderText = "Diger";
            this.digerDataGridViewTextBoxColumn.Name = "digerDataGridViewTextBoxColumn";
            // 
            // giderlerBindingSource
            // 
            this.giderlerBindingSource.DataMember = "Giderler";
            this.giderlerBindingSource.DataSource = this.yurtOtomasyonuDataSet16;
            // 
            // yurtOtomasyonuDataSet16
            // 
            this.yurtOtomasyonuDataSet16.DataSetName = "YurtOtomasyonuDataSet16";
            this.yurtOtomasyonuDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giderlerTableAdapter
            // 
            this.giderlerTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(262, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "  Silinmesini istediğiniz Gideri Listeden Seçiniz  ";
            // 
            // frmGiderSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 482);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGiderSil);
            this.Controls.Add(this.txtGiderID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGiderSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gider Silme";
            this.Load += new System.EventHandler(this.frmGiderSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiderID;
        private System.Windows.Forms.Button btnGiderSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet16 yurtOtomasyonuDataSet16;
        private System.Windows.Forms.BindingSource giderlerBindingSource;
        private YurtOtomasyonuDataSet16TableAdapters.GiderlerTableAdapter giderlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elektrikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogalgazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ınternetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn digerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}