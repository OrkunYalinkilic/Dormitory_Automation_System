namespace YurtKayitSistemi
{
    partial class FrmBolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBolumId = new System.Windows.Forms.TextBox();
            this.TxtBolumAd = new System.Windows.Forms.TextBox();
            this.pcbEkleme = new System.Windows.Forms.PictureBox();
            this.pcbGuncelleme = new System.Windows.Forms.PictureBox();
            this.pcbSilme = new System.Windows.Forms.PictureBox();
            this.yurtOtomasyonuDataSet = new YurtKayitSistemi.YurtOtomasyonuDataSet();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bolumlerTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSetTableAdapters.BolumlerTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bolumIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEkleme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGuncelleme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSilme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bölüm ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bolum Ad:";
            // 
            // TxtBolumId
            // 
            this.TxtBolumId.Enabled = false;
            this.TxtBolumId.Location = new System.Drawing.Point(425, 177);
            this.TxtBolumId.Name = "TxtBolumId";
            this.TxtBolumId.Size = new System.Drawing.Size(239, 24);
            this.TxtBolumId.TabIndex = 2;
            // 
            // TxtBolumAd
            // 
            this.TxtBolumAd.Enabled = false;
            this.TxtBolumAd.Location = new System.Drawing.Point(426, 212);
            this.TxtBolumAd.Name = "TxtBolumAd";
            this.TxtBolumAd.Size = new System.Drawing.Size(239, 24);
            this.TxtBolumAd.TabIndex = 2;
            // 
            // pcbEkleme
            // 
            this.pcbEkleme.Image = ((System.Drawing.Image)(resources.GetObject("pcbEkleme.Image")));
            this.pcbEkleme.Location = new System.Drawing.Point(297, 41);
            this.pcbEkleme.Name = "pcbEkleme";
            this.pcbEkleme.Size = new System.Drawing.Size(70, 65);
            this.pcbEkleme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbEkleme.TabIndex = 3;
            this.pcbEkleme.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbEkleme, "Bölüm Ekle");
            this.pcbEkleme.Click += new System.EventHandler(this.pcbEkleme_Click);
            // 
            // pcbGuncelleme
            // 
            this.pcbGuncelleme.Image = ((System.Drawing.Image)(resources.GetObject("pcbGuncelleme.Image")));
            this.pcbGuncelleme.Location = new System.Drawing.Point(425, 41);
            this.pcbGuncelleme.Name = "pcbGuncelleme";
            this.pcbGuncelleme.Size = new System.Drawing.Size(70, 65);
            this.pcbGuncelleme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbGuncelleme.TabIndex = 3;
            this.pcbGuncelleme.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbGuncelleme, "Bölüm Güncelle");
            this.pcbGuncelleme.Click += new System.EventHandler(this.pcbGuncelleme_Click);
            // 
            // pcbSilme
            // 
            this.pcbSilme.Image = ((System.Drawing.Image)(resources.GetObject("pcbSilme.Image")));
            this.pcbSilme.Location = new System.Drawing.Point(545, 41);
            this.pcbSilme.Name = "pcbSilme";
            this.pcbSilme.Size = new System.Drawing.Size(70, 65);
            this.pcbSilme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSilme.TabIndex = 3;
            this.pcbSilme.TabStop = false;
            this.pcbSilme.Tag = "";
            this.toolTip1.SetToolTip(this.pcbSilme, "Bölüm Sil");
            this.pcbSilme.Click += new System.EventHandler(this.pcbSilme_Click);
            // 
            // yurtOtomasyonuDataSet
            // 
            this.yurtOtomasyonuDataSet.DataSetName = "YurtOtomasyonuDataSet";
            this.yurtOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "Bolumler";
            this.bolumlerBindingSource.DataSource = this.yurtOtomasyonuDataSet;
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumIDDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(141, 409);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(695, 265);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bolumIDDataGridViewTextBoxColumn
            // 
            this.bolumIDDataGridViewTextBoxColumn.DataPropertyName = "BolumID";
            this.bolumIDDataGridViewTextBoxColumn.HeaderText = "Bölüm ID";
            this.bolumIDDataGridViewTextBoxColumn.Name = "bolumIDDataGridViewTextBoxColumn";
            this.bolumIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "Bölüm Adı";
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            this.bolumAdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(560, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bölüm düzenlemek için düzenlemek isteğiniz bölümü listeden seçip düzenle butonu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(558, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bölüm eklemek için eklemek istediğiniz bölümün adını girip ekle butonuna basınız." +
    "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(395, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bölüm silmek için silmek istediğiniz bölümü listeden seçip ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(319, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "BÖLÜM EKLE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(434, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "BÖLÜM DÜZENLE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(581, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "BÖLÜM SİL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(634, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            this.pictureBox1.Click += new System.EventHandler(this.pcbSilme_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(721, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "";
            this.pictureBox2.Click += new System.EventHandler(this.pcbSilme_Click);
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 713);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pcbSilme);
            this.Controls.Add(this.pcbGuncelleme);
            this.Controls.Add(this.pcbEkleme);
            this.Controls.Add(this.TxtBolumAd);
            this.Controls.Add(this.TxtBolumId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmBolumler";
            this.Text = "Bölümler";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbEkleme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGuncelleme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSilme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBolumId;
        private System.Windows.Forms.TextBox TxtBolumAd;
        private System.Windows.Forms.PictureBox pcbEkleme;
        private System.Windows.Forms.PictureBox pcbGuncelleme;
        private System.Windows.Forms.PictureBox pcbSilme;
        private YurtOtomasyonuDataSet yurtOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private YurtOtomasyonuDataSetTableAdapters.BolumlerTableAdapter bolumlerTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}