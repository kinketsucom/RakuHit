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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConditionGroupBox = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DetailGroupBox = new System.Windows.Forms.GroupBox();
            this.AverageCommentLabel = new System.Windows.Forms.Label();
            this.MinCommentLabel = new System.Windows.Forms.Label();
            this.MaxCommentLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.MaxLikeLabel = new System.Windows.Forms.Label();
            this.MinLikeLabel = new System.Windows.Forms.Label();
            this.llabel6 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.AverageLikeLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DetailQueryLabel = new System.Windows.Forms.Label();
            this.StartAmazonButton = new System.Windows.Forms.Button();
            this.AveragePriceLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.MaxPriceLabel = new System.Windows.Forms.Label();
            this.MinPriceLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.ConditionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.DetailGroupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "ブランドで統計を取る";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart.Legends.Add(legend3);
            this.chart.Location = new System.Drawing.Point(225, 0);
            this.chart.Name = "chart";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            series3.Font = new System.Drawing.Font("メイリオ", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.Name = "データ";
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(979, 643);
            this.chart.TabIndex = 1;
            this.chart.DoubleClick += new System.EventHandler(this.chart_DoubleClick);
            this.chart.MouseLeave += new System.EventHandler(this.chart_MouseLeave);
            this.chart.MouseHover += new System.EventHandler(this.chart_MouseHover);
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
            this.numericUpDown1.Location = new System.Drawing.Point(9, 36);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            49,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 22);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
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
            this.label2.Location = new System.Drawing.Point(6, 61);
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
            this.checkBox1.Location = new System.Drawing.Point(6, 105);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 19);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "未指定の除外";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.MouseLeave += new System.EventHandler(this.checkBox1_MouseLeave);
            this.checkBox1.MouseHover += new System.EventHandler(this.checkBox1_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "%";
            // 
            // ConditionGroupBox
            // 
            this.ConditionGroupBox.Controls.Add(this.label12);
            this.ConditionGroupBox.Controls.Add(this.numericUpDown2);
            this.ConditionGroupBox.Controls.Add(this.label1);
            this.ConditionGroupBox.Controls.Add(this.label3);
            this.ConditionGroupBox.Controls.Add(this.numericUpDown1);
            this.ConditionGroupBox.Controls.Add(this.checkBox1);
            this.ConditionGroupBox.Controls.Add(this.label2);
            this.ConditionGroupBox.Location = new System.Drawing.Point(0, 150);
            this.ConditionGroupBox.Name = "ConditionGroupBox";
            this.ConditionGroupBox.Size = new System.Drawing.Size(219, 276);
            this.ConditionGroupBox.TabIndex = 10;
            this.ConditionGroupBox.TabStop = false;
            this.ConditionGroupBox.Text = "条件";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "取得アイテムの最大数";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(9, 176);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(75, 22);
            this.numericUpDown2.TabIndex = 10;
            this.numericUpDown2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown2.Enter += new System.EventHandler(this.numericUpDown2_Enter);
            this.numericUpDown2.Leave += new System.EventHandler(this.numericUpDown2_Leave);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 22);
            this.textBox1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "検索クエリ";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(1215, 583);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(8, 8);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // DetailGroupBox
            // 
            this.DetailGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailGroupBox.Controls.Add(this.AverageCommentLabel);
            this.DetailGroupBox.Controls.Add(this.MinCommentLabel);
            this.DetailGroupBox.Controls.Add(this.MaxCommentLabel);
            this.DetailGroupBox.Controls.Add(this.label14);
            this.DetailGroupBox.Controls.Add(this.label13);
            this.DetailGroupBox.Controls.Add(this.MaxLikeLabel);
            this.DetailGroupBox.Controls.Add(this.MinLikeLabel);
            this.DetailGroupBox.Controls.Add(this.llabel6);
            this.DetailGroupBox.Controls.Add(this.label);
            this.DetailGroupBox.Controls.Add(this.AverageLikeLabel);
            this.DetailGroupBox.Controls.Add(this.label11);
            this.DetailGroupBox.Controls.Add(this.label7);
            this.DetailGroupBox.Controls.Add(this.label10);
            this.DetailGroupBox.Controls.Add(this.label8);
            this.DetailGroupBox.Controls.Add(this.DetailQueryLabel);
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
            // AverageCommentLabel
            // 
            this.AverageCommentLabel.AutoSize = true;
            this.AverageCommentLabel.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AverageCommentLabel.Location = new System.Drawing.Point(703, 72);
            this.AverageCommentLabel.Name = "AverageCommentLabel";
            this.AverageCommentLabel.Size = new System.Drawing.Size(19, 23);
            this.AverageCommentLabel.TabIndex = 34;
            this.AverageCommentLabel.Text = "0";
            // 
            // MinCommentLabel
            // 
            this.MinCommentLabel.AutoSize = true;
            this.MinCommentLabel.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MinCommentLabel.Location = new System.Drawing.Point(703, 45);
            this.MinCommentLabel.Name = "MinCommentLabel";
            this.MinCommentLabel.Size = new System.Drawing.Size(19, 23);
            this.MinCommentLabel.TabIndex = 33;
            this.MinCommentLabel.Text = "0";
            // 
            // MaxCommentLabel
            // 
            this.MaxCommentLabel.AutoSize = true;
            this.MaxCommentLabel.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaxCommentLabel.Location = new System.Drawing.Point(703, 18);
            this.MaxCommentLabel.Name = "MaxCommentLabel";
            this.MaxCommentLabel.Size = new System.Drawing.Size(19, 23);
            this.MaxCommentLabel.TabIndex = 32;
            this.MaxCommentLabel.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(636, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 23);
            this.label14.TabIndex = 31;
            this.label14.Text = "最低💬:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(636, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 23);
            this.label13.TabIndex = 30;
            this.label13.Text = "最高💬:";
            // 
            // MaxLikeLabel
            // 
            this.MaxLikeLabel.AutoSize = true;
            this.MaxLikeLabel.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaxLikeLabel.Location = new System.Drawing.Point(554, 20);
            this.MaxLikeLabel.Name = "MaxLikeLabel";
            this.MaxLikeLabel.Size = new System.Drawing.Size(19, 23);
            this.MaxLikeLabel.TabIndex = 29;
            this.MaxLikeLabel.Text = "0";
            // 
            // MinLikeLabel
            // 
            this.MinLikeLabel.AutoSize = true;
            this.MinLikeLabel.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MinLikeLabel.Location = new System.Drawing.Point(554, 47);
            this.MinLikeLabel.Name = "MinLikeLabel";
            this.MinLikeLabel.Size = new System.Drawing.Size(19, 23);
            this.MinLikeLabel.TabIndex = 28;
            this.MinLikeLabel.Text = "0";
            // 
            // llabel6
            // 
            this.llabel6.AutoSize = true;
            this.llabel6.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.llabel6.Location = new System.Drawing.Point(487, 46);
            this.llabel6.Name = "llabel6";
            this.llabel6.Size = new System.Drawing.Size(61, 23);
            this.llabel6.TabIndex = 27;
            this.llabel6.Text = "最低♡:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label.Location = new System.Drawing.Point(487, 20);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(61, 23);
            this.label.TabIndex = 26;
            this.label.Text = "最高♡:";
            // 
            // AverageLikeLabel
            // 
            this.AverageLikeLabel.AutoSize = true;
            this.AverageLikeLabel.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AverageLikeLabel.Location = new System.Drawing.Point(554, 72);
            this.AverageLikeLabel.Name = "AverageLikeLabel";
            this.AverageLikeLabel.Size = new System.Drawing.Size(19, 23);
            this.AverageLikeLabel.TabIndex = 25;
            this.AverageLikeLabel.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(636, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 23);
            this.label11.TabIndex = 23;
            this.label11.Text = "平均💭:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(487, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "平均♡:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(814, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Amazon類似商品検索";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "絞りこみ:";
            // 
            // DetailQueryLabel
            // 
            this.DetailQueryLabel.AutoSize = true;
            this.DetailQueryLabel.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DetailQueryLabel.Location = new System.Drawing.Point(82, 20);
            this.DetailQueryLabel.Name = "DetailQueryLabel";
            this.DetailQueryLabel.Size = new System.Drawing.Size(48, 23);
            this.DetailQueryLabel.TabIndex = 17;
            this.DetailQueryLabel.Text = "None";
            // 
            // StartAmazonButton
            // 
            this.StartAmazonButton.BackColor = System.Drawing.Color.Orange;
            this.StartAmazonButton.Location = new System.Drawing.Point(828, 46);
            this.StartAmazonButton.Name = "StartAmazonButton";
            this.StartAmazonButton.Size = new System.Drawing.Size(133, 23);
            this.StartAmazonButton.TabIndex = 15;
            this.StartAmazonButton.Text = "Amazon";
            this.StartAmazonButton.UseVisualStyleBackColor = false;
            this.StartAmazonButton.Click += new System.EventHandler(this.StartAmazonButton_Click);
            this.StartAmazonButton.MouseLeave += new System.EventHandler(this.StartAmazonButton_MouseLeave);
            this.StartAmazonButton.MouseHover += new System.EventHandler(this.StartAmazonButton_MouseHover);
            // 
            // AveragePriceLabel
            // 
            this.AveragePriceLabel.AutoSize = true;
            this.AveragePriceLabel.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AveragePriceLabel.Location = new System.Drawing.Point(324, 69);
            this.AveragePriceLabel.Name = "AveragePriceLabel";
            this.AveragePriceLabel.Size = new System.Drawing.Size(19, 23);
            this.AveragePriceLabel.TabIndex = 5;
            this.AveragePriceLabel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(242, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "最安価格:";
            // 
            // MaxPriceLabel
            // 
            this.MaxPriceLabel.AutoSize = true;
            this.MaxPriceLabel.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaxPriceLabel.Location = new System.Drawing.Point(324, 18);
            this.MaxPriceLabel.Name = "MaxPriceLabel";
            this.MaxPriceLabel.Size = new System.Drawing.Size(19, 23);
            this.MaxPriceLabel.TabIndex = 3;
            this.MaxPriceLabel.Text = "0";
            // 
            // MinPriceLabel
            // 
            this.MinPriceLabel.AutoSize = true;
            this.MinPriceLabel.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MinPriceLabel.Location = new System.Drawing.Point(324, 43);
            this.MinPriceLabel.Name = "MinPriceLabel";
            this.MinPriceLabel.Size = new System.Drawing.Size(19, 23);
            this.MinPriceLabel.TabIndex = 2;
            this.MinPriceLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(242, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "平均価格:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(242, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "最高価格:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 121);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(219, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 782);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1216, 25);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1216, 807);
            this.Controls.Add(this.statusStrip1);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.DetailGroupBox.ResumeLayout(false);
            this.DetailGroupBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.Button StartAmazonButton;
        private System.Windows.Forms.Label DetailQueryLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label AverageLikeLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label MinLikeLabel;
        private System.Windows.Forms.Label llabel6;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label MaxLikeLabel;
        private System.Windows.Forms.Label AverageCommentLabel;
        private System.Windows.Forms.Label MinCommentLabel;
        private System.Windows.Forms.Label MaxCommentLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}

