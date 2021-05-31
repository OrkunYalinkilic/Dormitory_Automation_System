namespace YurtKayitSistemi
{
    partial class frmOgleYemekGuncelleSecim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgleYemekGuncelleSecim));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAy = new System.Windows.Forms.TextBox();
            this.txtGun = new System.Windows.Forms.TextBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ayAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunSirasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yemekOgunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yemekBirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yemekIkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yemekUcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yemekDortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yemeklerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yemekhaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet26 = new YurtKayitSistemi.YurtOtomasyonuDataSet26();
            this.yemekhaneTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSet26TableAdapters.YemekhaneTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekhaneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet26)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Güncellemek istediğiniz Yemek gününü seçiniz.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "YIL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "AY:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "GÜN:";
            // 
            // txtAy
            // 
            this.txtAy.Enabled = false;
            this.txtAy.Location = new System.Drawing.Point(143, 52);
            this.txtAy.Name = "txtAy";
            this.txtAy.Size = new System.Drawing.Size(174, 28);
            this.txtAy.TabIndex = 2;
            // 
            // txtGun
            // 
            this.txtGun.Enabled = false;
            this.txtGun.Location = new System.Drawing.Point(143, 82);
            this.txtGun.Name = "txtGun";
            this.txtGun.Size = new System.Drawing.Size(174, 28);
            this.txtGun.TabIndex = 2;
            // 
            // txtYil
            // 
            this.txtYil.Enabled = false;
            this.txtYil.Location = new System.Drawing.Point(143, 22);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(174, 28);
            this.txtYil.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(341, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yilDataGridViewTextBoxColumn,
            this.ayAdiDataGridViewTextBoxColumn,
            this.gunSirasiDataGridViewTextBoxColumn,
            this.yemekOgunDataGridViewTextBoxColumn,
            this.yemekBirDataGridViewTextBoxColumn,
            this.yemekIkiDataGridViewTextBoxColumn,
            this.yemekUcDataGridViewTextBoxColumn,
            this.yemekDortDataGridViewTextBoxColumn,
            this.yemeklerIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yemekhaneBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(508, 214);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yilDataGridViewTextBoxColumn
            // 
            this.yilDataGridViewTextBoxColumn.DataPropertyName = "Yil";
            this.yilDataGridViewTextBoxColumn.HeaderText = "Yil";
            this.yilDataGridViewTextBoxColumn.Name = "yilDataGridViewTextBoxColumn";
            // 
            // ayAdiDataGridViewTextBoxColumn
            // 
            this.ayAdiDataGridViewTextBoxColumn.DataPropertyName = "AyAdi";
            this.ayAdiDataGridViewTextBoxColumn.HeaderText = "Ay Adi";
            this.ayAdiDataGridViewTextBoxColumn.Name = "ayAdiDataGridViewTextBoxColumn";
            // 
            // gunSirasiDataGridViewTextBoxColumn
            // 
            this.gunSirasiDataGridViewTextBoxColumn.DataPropertyName = "GunSirasi";
            this.gunSirasiDataGridViewTextBoxColumn.HeaderText = "Gun Sirasi";
            this.gunSirasiDataGridViewTextBoxColumn.Name = "gunSirasiDataGridViewTextBoxColumn";
            this.gunSirasiDataGridViewTextBoxColumn.Width = 120;
            // 
            // yemekOgunDataGridViewTextBoxColumn
            // 
            this.yemekOgunDataGridViewTextBoxColumn.DataPropertyName = "YemekOgun";
            this.yemekOgunDataGridViewTextBoxColumn.HeaderText = "Yemek Ogun";
            this.yemekOgunDataGridViewTextBoxColumn.Name = "yemekOgunDataGridViewTextBoxColumn";
            this.yemekOgunDataGridViewTextBoxColumn.Visible = false;
            this.yemekOgunDataGridViewTextBoxColumn.Width = 130;
            // 
            // yemekBirDataGridViewTextBoxColumn
            // 
            this.yemekBirDataGridViewTextBoxColumn.DataPropertyName = "YemekBir";
            this.yemekBirDataGridViewTextBoxColumn.HeaderText = "YemekBir";
            this.yemekBirDataGridViewTextBoxColumn.Name = "yemekBirDataGridViewTextBoxColumn";
            this.yemekBirDataGridViewTextBoxColumn.Visible = false;
            // 
            // yemekIkiDataGridViewTextBoxColumn
            // 
            this.yemekIkiDataGridViewTextBoxColumn.DataPropertyName = "YemekIki";
            this.yemekIkiDataGridViewTextBoxColumn.HeaderText = "YemekIki";
            this.yemekIkiDataGridViewTextBoxColumn.Name = "yemekIkiDataGridViewTextBoxColumn";
            this.yemekIkiDataGridViewTextBoxColumn.Visible = false;
            // 
            // yemekUcDataGridViewTextBoxColumn
            // 
            this.yemekUcDataGridViewTextBoxColumn.DataPropertyName = "YemekUc";
            this.yemekUcDataGridViewTextBoxColumn.HeaderText = "YemekUc";
            this.yemekUcDataGridViewTextBoxColumn.Name = "yemekUcDataGridViewTextBoxColumn";
            this.yemekUcDataGridViewTextBoxColumn.Visible = false;
            // 
            // yemekDortDataGridViewTextBoxColumn
            // 
            this.yemekDortDataGridViewTextBoxColumn.DataPropertyName = "YemekDort";
            this.yemekDortDataGridViewTextBoxColumn.HeaderText = "YemekDort";
            this.yemekDortDataGridViewTextBoxColumn.Name = "yemekDortDataGridViewTextBoxColumn";
            this.yemekDortDataGridViewTextBoxColumn.Visible = false;
            // 
            // yemeklerIDDataGridViewTextBoxColumn
            // 
            this.yemeklerIDDataGridViewTextBoxColumn.DataPropertyName = "YemeklerID";
            this.yemeklerIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.yemeklerIDDataGridViewTextBoxColumn.Name = "yemeklerIDDataGridViewTextBoxColumn";
            this.yemeklerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.yemeklerIDDataGridViewTextBoxColumn.Width = 130;
            // 
            // yemekhaneBindingSource
            // 
            this.yemekhaneBindingSource.DataMember = "Yemekhane";
            this.yemekhaneBindingSource.DataSource = this.yurtOtomasyonuDataSet26;
            // 
            // yurtOtomasyonuDataSet26
            // 
            this.yurtOtomasyonuDataSet26.DataSetName = "YurtOtomasyonuDataSet26";
            this.yurtOtomasyonuDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yemekhaneTableAdapter
            // 
            this.yemekhaneTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(180, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "BUL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmOgleYemekGuncelleSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 413);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.txtGun);
            this.Controls.Add(this.txtAy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOgleYemekGuncelleSecim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yemek Seçim";
            this.Load += new System.EventHandler(this.frmOgleYemekGuncelleSecim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekhaneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet26)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAy;
        private System.Windows.Forms.TextBox txtGun;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet26 yurtOtomasyonuDataSet26;
        private System.Windows.Forms.BindingSource yemekhaneBindingSource;
        private YurtOtomasyonuDataSet26TableAdapters.YemekhaneTableAdapter yemekhaneTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ayAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gunSirasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yemekOgunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yemekBirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yemekIkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yemekUcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yemekDortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yemeklerIDDataGridViewTextBoxColumn;
    }
}