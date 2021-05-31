namespace YurtKayitSistemi
{
    partial class frmOdaSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdaSil));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOdaID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.odaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaKapasiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaAktifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.odalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet23 = new YurtKayitSistemi.YurtOtomasyonuDataSet23();
            this.odalarTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSet23TableAdapters.OdalarTableAdapter();
            this.btnOdaSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet23)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(187, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Silmek istediğiniz odayı listeden seçiniz.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Oda ID:";
            // 
            // txtOdaID
            // 
            this.txtOdaID.Enabled = false;
            this.txtOdaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdaID.Location = new System.Drawing.Point(352, 49);
            this.txtOdaID.Name = "txtOdaID";
            this.txtOdaID.Size = new System.Drawing.Size(195, 32);
            this.txtOdaID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Oda Numarası:";
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.Enabled = false;
            this.txtOdaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdaNo.Location = new System.Drawing.Point(352, 96);
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Size = new System.Drawing.Size(195, 32);
            this.txtOdaNo.TabIndex = 3;
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
            this.odaDurumDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.odalarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(610, 290);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // odaIDDataGridViewTextBoxColumn
            // 
            this.odaIDDataGridViewTextBoxColumn.DataPropertyName = "OdaID";
            this.odaIDDataGridViewTextBoxColumn.HeaderText = "Oda ID";
            this.odaIDDataGridViewTextBoxColumn.Name = "odaIDDataGridViewTextBoxColumn";
            this.odaIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // odaNoDataGridViewTextBoxColumn
            // 
            this.odaNoDataGridViewTextBoxColumn.DataPropertyName = "OdaNo";
            this.odaNoDataGridViewTextBoxColumn.HeaderText = "Oda No";
            this.odaNoDataGridViewTextBoxColumn.Name = "odaNoDataGridViewTextBoxColumn";
            // 
            // odaKapasiteDataGridViewTextBoxColumn
            // 
            this.odaKapasiteDataGridViewTextBoxColumn.DataPropertyName = "OdaKapasite";
            this.odaKapasiteDataGridViewTextBoxColumn.HeaderText = "Oda Kapasitesi";
            this.odaKapasiteDataGridViewTextBoxColumn.Name = "odaKapasiteDataGridViewTextBoxColumn";
            this.odaKapasiteDataGridViewTextBoxColumn.Width = 150;
            // 
            // odaAktifDataGridViewTextBoxColumn
            // 
            this.odaAktifDataGridViewTextBoxColumn.DataPropertyName = "OdaAktif";
            this.odaAktifDataGridViewTextBoxColumn.HeaderText = "Odada Kalan Kişi Sayısı";
            this.odaAktifDataGridViewTextBoxColumn.Name = "odaAktifDataGridViewTextBoxColumn";
            this.odaAktifDataGridViewTextBoxColumn.Width = 200;
            // 
            // odaDurumDataGridViewCheckBoxColumn
            // 
            this.odaDurumDataGridViewCheckBoxColumn.DataPropertyName = "OdaDurum";
            this.odaDurumDataGridViewCheckBoxColumn.HeaderText = "OdaDurum";
            this.odaDurumDataGridViewCheckBoxColumn.Name = "odaDurumDataGridViewCheckBoxColumn";
            this.odaDurumDataGridViewCheckBoxColumn.Visible = false;
            // 
            // odalarBindingSource
            // 
            this.odalarBindingSource.DataMember = "Odalar";
            this.odalarBindingSource.DataSource = this.yurtOtomasyonuDataSet23;
            // 
            // yurtOtomasyonuDataSet23
            // 
            this.yurtOtomasyonuDataSet23.DataSetName = "YurtOtomasyonuDataSet23";
            this.yurtOtomasyonuDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odalarTableAdapter
            // 
            this.odalarTableAdapter.ClearBeforeFill = true;
            // 
            // btnOdaSil
            // 
            this.btnOdaSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdaSil.Location = new System.Drawing.Point(352, 138);
            this.btnOdaSil.Name = "btnOdaSil";
            this.btnOdaSil.Size = new System.Drawing.Size(195, 33);
            this.btnOdaSil.TabIndex = 0;
            this.btnOdaSil.Text = "ODAYI SİL";
            this.btnOdaSil.UseVisualStyleBackColor = true;
            this.btnOdaSil.Click += new System.EventHandler(this.btnOdaSil_Click);
            // 
            // frmOdaSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 536);
            this.Controls.Add(this.btnOdaSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtOdaNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOdaID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOdaSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oda Silme";
            this.Load += new System.EventHandler(this.frmOdaSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet23)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOdaID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet23 yurtOtomasyonuDataSet23;
        private System.Windows.Forms.BindingSource odalarBindingSource;
        private YurtOtomasyonuDataSet23TableAdapters.OdalarTableAdapter odalarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaKapasiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaAktifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn odaDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button btnOdaSil;
    }
}