namespace YurtKayitSistemi
{
    partial class OgleYemekGun
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
            this.yurtOtomasyonuDataSet24 = new YurtKayitSistemi.YurtOtomasyonuDataSet24();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecilenAy = new System.Windows.Forms.TextBox();
            this.txtSecilenGun = new System.Windows.Forms.TextBox();
            this.yemekhaneTableAdapter = new YurtKayitSistemi.YurtOtomasyonuDataSet24TableAdapters.YemekhaneTableAdapter();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekhaneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet24)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(27, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(578, 366);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // yilDataGridViewTextBoxColumn
            // 
            this.yilDataGridViewTextBoxColumn.DataPropertyName = "Yil";
            this.yilDataGridViewTextBoxColumn.HeaderText = "Yil";
            this.yilDataGridViewTextBoxColumn.Name = "yilDataGridViewTextBoxColumn";
            this.yilDataGridViewTextBoxColumn.Visible = false;
            // 
            // ayAdiDataGridViewTextBoxColumn
            // 
            this.ayAdiDataGridViewTextBoxColumn.DataPropertyName = "AyAdi";
            this.ayAdiDataGridViewTextBoxColumn.HeaderText = "Ay Adi";
            this.ayAdiDataGridViewTextBoxColumn.Name = "ayAdiDataGridViewTextBoxColumn";
            this.ayAdiDataGridViewTextBoxColumn.Width = 300;
            // 
            // gunSirasiDataGridViewTextBoxColumn
            // 
            this.gunSirasiDataGridViewTextBoxColumn.DataPropertyName = "GunSirasi";
            this.gunSirasiDataGridViewTextBoxColumn.HeaderText = "GunSirasi";
            this.gunSirasiDataGridViewTextBoxColumn.Name = "gunSirasiDataGridViewTextBoxColumn";
            // 
            // yemekOgunDataGridViewTextBoxColumn
            // 
            this.yemekOgunDataGridViewTextBoxColumn.DataPropertyName = "YemekOgun";
            this.yemekOgunDataGridViewTextBoxColumn.HeaderText = "YemekOgun";
            this.yemekOgunDataGridViewTextBoxColumn.Name = "yemekOgunDataGridViewTextBoxColumn";
            this.yemekOgunDataGridViewTextBoxColumn.Visible = false;
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
            this.yemeklerIDDataGridViewTextBoxColumn.HeaderText = "Yemekler ID";
            this.yemeklerIDDataGridViewTextBoxColumn.Name = "yemeklerIDDataGridViewTextBoxColumn";
            this.yemeklerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.yemeklerIDDataGridViewTextBoxColumn.Width = 130;
            // 
            // yemekhaneBindingSource
            // 
            this.yemekhaneBindingSource.DataMember = "Yemekhane";
            this.yemekhaneBindingSource.DataSource = this.yurtOtomasyonuDataSet24;
            // 
            // yurtOtomasyonuDataSet24
            // 
            this.yurtOtomasyonuDataSet24.DataSetName = "YurtOtomasyonuDataSet24";
            this.yurtOtomasyonuDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seçilen Ay:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seçilen Gün:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(99, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(550, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "ÖĞLE YEMEĞİ GÖRÜNTÜLEME";
            // 
            // txtSecilenAy
            // 
            this.txtSecilenAy.Enabled = false;
            this.txtSecilenAy.Location = new System.Drawing.Point(220, 82);
            this.txtSecilenAy.Name = "txtSecilenAy";
            this.txtSecilenAy.Size = new System.Drawing.Size(181, 28);
            this.txtSecilenAy.TabIndex = 0;
            // 
            // txtSecilenGun
            // 
            this.txtSecilenGun.Enabled = false;
            this.txtSecilenGun.Location = new System.Drawing.Point(219, 115);
            this.txtSecilenGun.Name = "txtSecilenGun";
            this.txtSecilenGun.Size = new System.Drawing.Size(181, 28);
            this.txtSecilenGun.TabIndex = 1;
            // 
            // yemekhaneTableAdapter
            // 
            this.yemekhaneTableAdapter.ClearBeforeFill = true;
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(418, 82);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(92, 59);
            this.btnAra.TabIndex = 0;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // OgleYemekGun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 538);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtSecilenGun);
            this.Controls.Add(this.txtSecilenAy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OgleYemekGun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğle Yemeği Görüntüleme";
            this.Load += new System.EventHandler(this.OgleYemekGun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekhaneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet24)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecilenAy;
        private System.Windows.Forms.TextBox txtSecilenGun;
        private YurtOtomasyonuDataSet24 yurtOtomasyonuDataSet24;
        private System.Windows.Forms.BindingSource yemekhaneBindingSource;
        private YurtOtomasyonuDataSet24TableAdapters.YemekhaneTableAdapter yemekhaneTableAdapter;
        private System.Windows.Forms.Button btnAra;
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