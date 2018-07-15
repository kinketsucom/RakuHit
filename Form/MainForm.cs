using RakuHit.Rakuma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RakuHit {
    public partial class MainForm : Form {

        RakumaAPI api;
        string request_type = "";
        string detail_query = "";
        Dictionary<string, string> param = new Dictionary<string, string>();//レスポンス用
        ResponseFormat resp_format = new ResponseFormat();
        Dictionary<string, int> count_dic = new Dictionary<string, int>();//統計用



        public MainForm() {
            InitializeComponent();
            this.api = new RakumaAPI(this);
        }
        private void MainForm_Load(object sender, EventArgs e) {
            AdjustLayout();
        }
        private void MainForm_SizeChanged(object sender, EventArgs e) {
            AdjustLayout();
        }

        private void button1_Click(object sender, EventArgs e) {
            timer1.Enabled = true;
            string query = "";
            if (!string.IsNullOrEmpty(textBox1.Text)) query = textBox1.Text;
            param.Clear();
            param.Add("page", "1");
            param.Add("query", query);
            param.Add("sort", "item_id");
            param.Add("order", "desc");
            resp_format = api.SearchItemWithCondition(param);
            count_dic = api.CountResponseByBrandName(resp_format,(int)this.numericUpDown1.Value,this.checkBox1.Checked);
            //グラフに反映
            string legend = "ブランド数";
            chart.Series.Clear();
            chart.Series.Add(legend);
            chart.Series[legend].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart.ChartAreas["ChartArea1"].AxisX.Title = "ブランド名";
            chart.ChartAreas["ChartArea1"].AxisY.Title = "販売個数";
            
            foreach (var val in count_dic) {
                //グラフに追加するデータクラスを生成
                System.Windows.Forms.DataVisualization.Charting.DataPoint dp = new System.Windows.Forms.DataVisualization.Charting.DataPoint();
                dp.SetValueXY(val.Key, val.Value);  //XとYの値を設定
                dp.ToolTip = val.Key+"\n"+val.Value;
                chart.Series[legend].Points.Add(dp);   //グラフにデータ追加
            }
            request_type = "ブランド名";
        }

        private void AdjustLayout() {
            chart.Left = this.ConditionGroupBox.Width + 20;
            DetailGroupBox.Left = this.ConditionGroupBox.Width + 20;

        }
        private void ResetDetail() {
            MaxPriceLabel.Text = 0.ToString();
            MinPriceLabel.Text = 0.ToString();
            AveragePriceLabel.Text = 0.ToString();
            detail_query = "";
            DetailQueryLabel.Text = "";
        }

        //価格表示とかその辺の構造
        private void chart_DoubleClick(object sender, EventArgs e) {
            HitTestResult result;
            result = this.chart.HitTest(((MouseEventArgs)e).X, ((MouseEventArgs)e).Y);
            if (result.ChartElementType == ChartElementType.DataPoint) {
                DataPoint dp = result.Series.Points[result.PointIndex];

                switch (request_type) {
                    case "ブランド名":
                        double max_price = 0;
                        double min_price = 500000;
                        double average_price = 0;
                        int item_count = 0;
                        foreach(var val in resp_format.items) {
                            if (dp.AxisLabel == val.brand_name) {
                                if (val.price > max_price) {
                                    max_price = val.price;
                                }
                                if (val.price < min_price) {
                                    min_price = val.price;
                                }
                                average_price += val.price;
                                item_count += 1;
                            }
                        }
                        average_price /= item_count;

                        MaxPriceLabel.Text = ((int)max_price).ToString();
                        MinPriceLabel.Text = ((int)min_price).ToString();
                        AveragePriceLabel.Text = ((int)average_price).ToString();
                        detail_query = dp.AxisLabel;
                        DetailQueryLabel.Text = detail_query;
                        break;
                    default:
                        MessageBox.Show("先に検索を行ってください");
                        break;
                    
                }


                //MessageBox.Show(dp.AxisLabel + "," + dp.YValues[0]);
            }

        }

        private void StartAmazonButton_Click(object sender, EventArgs e) {
            string url = "https://www.amazon.co.jp/s?field-keywords=";
            url += detail_query;
            url += "/2018result-22/";
            System.Diagnostics.Process.Start(url);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            // 進捗を進める
            progressBar1.Value = api.progress_num;
            Console.WriteLine(progressBar1.Value);
            if (progressBar1.Value >= progressBar1.Maximum) {
                timer1.Enabled = false;
                MessageBox.Show("完了！");
            }

        }
    }
}
