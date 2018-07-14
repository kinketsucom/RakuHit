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

namespace RakuHit {
    public partial class MainForm : Form {
        RakumaAPI api = new RakumaAPI();
        Dictionary<string, string> param = new Dictionary<string, string>();//レスポンス用
        ResponseFormat resp_format = new ResponseFormat();
        Dictionary<string, int> count_dic = new Dictionary<string, int>();//統計用


        public MainForm() {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e) {
            AdjustLayout();
        }
        private void MainForm_SizeChanged(object sender, EventArgs e) {
            AdjustLayout();
        }

        private void button1_Click(object sender, EventArgs e) {
            string query = "";
            if (!string.IsNullOrEmpty(textBox1.Text)) query = textBox1.Text;
            progressBar.Value = 0;
            param.Clear();
            param.Add("page", "1");
            param.Add("query", query);
            param.Add("sort", "item_id");
            param.Add("order", "desc");
            resp_format = api.SearchItemWithCondition(param);
            progressBar.Value = 50;
            count_dic = api.CountResponseByBrandName(resp_format,(int)this.numericUpDown1.Value,this.checkBox1.Checked);
            progressBar.Value = 80;
            //グラフに反映
            string legend = "ブランド数";
            chart.Series.Clear();
            chart.Series.Add(legend);
            chart.Series[legend].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            foreach(var val in count_dic) {
                //グラフに追加するデータクラスを生成
                System.Windows.Forms.DataVisualization.Charting.DataPoint dp = new System.Windows.Forms.DataVisualization.Charting.DataPoint();
                dp.SetValueXY(val.Key, val.Value);  //XとYの値を設定
                dp.ToolTip = val.Key+"\n"+val.Value;
                chart.Series[legend].Points.Add(dp);   //グラフにデータ追加
            }
            progressBar.Value = 100;
        }

        private void AdjustLayout() {
            chart.Left = this.groupBox1.Width + 20;
        }

    }
}
