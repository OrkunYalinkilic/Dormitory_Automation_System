namespace YurtKayitSistemi
{
    partial class FrmGelirIstatistik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGelirIstatistik));
            this.lblKasadakiPara = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbAy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblSecilenAyPara = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKasadakiPara
            // 
            this.lblKasadakiPara.AutoSize = true;
            this.lblKasadakiPara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblKasadakiPara.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasadakiPara.Location = new System.Drawing.Point(621, 28);
            this.lblKasadakiPara.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKasadakiPara.Name = "lblKasadakiPara";
            this.lblKasadakiPara.Padding = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.lblKasadakiPara.Size = new System.Drawing.Size(46, 35);
            this.lblKasadakiPara.TabIndex = 0;
            this.lblKasadakiPara.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "KASADAKİ PARA:";
            // 
            // CmbAy
            // 
            this.CmbAy.Location = new System.Drawing.Point(293, 43);
            this.CmbAy.Name = "CmbAy";
            this.CmbAy.Size = new System.Drawing.Size(119, 29);
            this.CmbAy.TabIndex = 2;
            this.CmbAy.Text = "1-2019";
            this.CmbAy.SelectedIndexChanged += new System.EventHandler(this.CmbAy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ay Seçimi:";
            // 
            // LblSecilenAyPara
            // 
            this.LblSecilenAyPara.AutoSize = true;
            this.LblSecilenAyPara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LblSecilenAyPara.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSecilenAyPara.Location = new System.Drawing.Point(621, 65);
            this.LblSecilenAyPara.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSecilenAyPara.Name = "LblSecilenAyPara";
            this.LblSecilenAyPara.Padding = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.LblSecilenAyPara.Size = new System.Drawing.Size(46, 35);
            this.LblSecilenAyPara.TabIndex = 0;
            this.LblSecilenAyPara.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "SEÇİLEN AY:";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(28, 101);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Aylık";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(795, 300);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // FrmGelirIstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 435);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbAy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblSecilenAyPara);
            this.Controls.Add(this.lblKasadakiPara);
            this.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGelirIstatistik";
            this.Text = "Gelir Istatistik";
            this.Load += new System.EventHandler(this.FrmGelirIstatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKasadakiPara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblSecilenAyPara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox CmbAy;
    }
}