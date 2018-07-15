namespace RakuHit {
    partial class MainForm {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConditionGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DetailGroupBox = new System.Windows.Forms.GroupBox();
            this.DetailQueryLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.StartAmazonButton = new System.Windows.Forms.Button();
            this.AveragePriceLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.MaxPriceLabel = new System.Windows.Forms.Label();
            this.MinPriceLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.ConditionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.DetailGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "ブランドで絞り込み";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea13.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.chart.Legends.Add(legend13);
            this.chart.Location = new System.Drawing.Point(225, 31);
            this.chart.Name = "chart";
            series13.ChartArea = "ChartArea1";
            series13.LabelToolTip = "aaaaaa";
            series13.Legend = "Legend1";
            series13.Name = "データ";
            this.chart.Series.Add(series13);
            this.chart.Size = new System.Drawing.Size(979, 643);
            this.chart.TabIndex = 1;
            this.chart.DoubleClick += new System.EventHandler(this.chart_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1216, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(61, 16);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            49,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 22);
            this.numericUpDown1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "全体の";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "以下のデータは含めない";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(9, 86);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 19);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "未指定の除外";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "%";
            // 
            // ConditionGroupBox
            // 
            this.ConditionGroupBox.Controls.Add(this.label1);
            this.ConditionGroupBox.Controls.Add(this.label3);
            this.ConditionGroupBox.Controls.Add(this.numericUpDown1);
            this.ConditionGroupBox.Controls.Add(this.checkBox1);
            this.ConditionGroupBox.Controls.Add(this.label2);
            this.ConditionGroupBox.Location = new System.Drawing.Point(0, 479);
            this.ConditionGroupBox.Name = "ConditionGroupBox";
            this.ConditionGroupBox.Size = new System.Drawing.Size(219, 299);
            this.ConditionGroupBox.TabIndex = 10;
            this.ConditionGroupBox.TabStop = false;
            this.ConditionGroupBox.Text = "条件";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 22);
            this.textBox1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "検索クエリ";
            // 
            // chart1
            // 
            chartArea14.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.chart1.Legends.Add(legend14);
            this.chart1.Location = new System.Drawing.Point(1215, 583);
            this.chart1.Name = "chart1";
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Series1";
            this.chart1.Series.Add(series14);
            this.chart1.Size = new System.Drawing.Size(8, 8);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // DetailGroupBox
            // 
            this.DetailGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailGroupBox.Controls.Add(this.DetailQueryLabel);
            this.DetailGroupBox.Controls.Add(this.label7);
            this.DetailGroupBox.Controls.Add(this.StartAmazonButton);
            this.DetailGroupBox.Controls.Add(this.AveragePriceLabel);
            this.DetailGroupBox.Controls.Add(this.label9);
            this.DetailGroupBox.Controls.Add(this.MaxPriceLabel);
            this.DetailGroupBox.Controls.Add(this.MinPriceLabel);
            this.DetailGroupBox.Controls.Add(this.label6);
            this.DetailGroupBox.Controls.Add(this.label5);
            this.DetailGroupBox.Location = new System.Drawing.Point(225, 680);
            this.DetailGroupBox.Name = "DetailGroupBox";
            this.DetailGroupBox.Size = new System.Drawing.Size(979, 98);
            this.DetailGroupBox.TabIndex = 14;
            this.DetailGroupBox.TabStop = false;
            this.DetailGroupBox.Text = "詳細情報";
            // 
            // DetailQueryLabel
            // 
            this.DetailQueryLabel.AutoSize = true;
            this.DetailQueryLabel.Location = new System.Drawing.Point(201, 45);
            this.DetailQueryLabel.Name = "DetailQueryLabel";
            this.DetailQueryLabel.Size = new System.Drawing.Size(0, 15);
            this.DetailQueryLabel.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(200, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Amazonで商品を見る";
            // 
            // StartAmazonButton
            // 
            this.StartAmazonButton.BackColor = System.Drawing.Color.Orange;
            this.StartAmazonButton.Location = new System.Drawing.Point(197, 67);
            this.StartAmazonButton.Name = "StartAmazonButton";
            this.StartAmazonButton.Size = new System.Drawing.Size(133, 23);
            this.StartAmazonButton.TabIndex = 15;
            this.StartAmazonButton.Text = "Amazon";
            this.StartAmazonButton.UseVisualStyleBackColor = false;
            this.StartAmazonButton.Click += new System.EventHandler(this.StartAmazonButton_Click);
            // 
            // AveragePriceLabel
            // 
            this.AveragePriceLabel.AutoSize = true;
            this.AveragePriceLabel.Location = new System.Drawing.Point(102, 71);
            this.AveragePriceLabel.Name = "AveragePriceLabel";
            this.AveragePriceLabel.Size = new System.Drawing.Size(15, 15);
            this.AveragePriceLabel.TabIndex = 5;
            this.AveragePriceLabel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(29, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "最安価格";
            // 
            // MaxPriceLabel
            // 
            this.MaxPriceLabel.AutoSize = true;
            this.MaxPriceLabel.Location = new System.Drawing.Point(102, 20);
            this.MaxPriceLabel.Name = "MaxPriceLabel";
            this.MaxPriceLabel.Size = new System.Drawing.Size(15, 15);
            this.MaxPriceLabel.TabIndex = 3;
            this.MaxPriceLabel.Text = "0";
            // 
            // MinPriceLabel
            // 
            this.MinPriceLabel.AutoSize = true;
            this.MinPriceLabel.Location = new System.Drawing.Point(102, 45);
            this.MinPriceLabel.Name = "MinPriceLabel";
            this.MinPriceLabel.Size = new System.Drawing.Size(15, 15);
            this.MinPriceLabel.TabIndex = 2;
            this.MinPriceLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(29, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "平均価格";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(29, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "最高価格";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 139);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(219, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1216, 807);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.DetailGroupBox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ConditionGroupBox);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "RakuHit";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ConditionGroupBox.ResumeLayout(false);
            this.ConditionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.DetailGroupBox.ResumeLayout(false);
            this.DetailGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox ConditionGroupBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox DetailGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AveragePriceLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label MaxPriceLabel;
        private System.Windows.Forms.Label MinPriceLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button StartAmazonButton;
        private System.Windows.Forms.Label DetailQueryLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

