using RakuHit.Forms;
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

        RakumaAPI api = new RakumaAPI();
        string request_type = "";
        string detail_query = "";
        Dictionary<string, string> param = new Dictionary<string, string>();//レスポンス用
        ResponseFormat resp_format = new ResponseFormat();
        Dictionary<string, int> count_dic = new Dictionary<string, int>();//統計用

        string[] name = new string[5];
        double[] id = new double[5];
        string[] url = new string[5];


        public MainForm() {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e) {
            AdjustLayout();
            #region ライセンス関連
            //初回起動(キーがなければ起動時刻+3日をレジストリに書き込み）
            string stringValue = (string)Microsoft.Win32.Registry.GetValue(MainForm.Registry_Path, "Expire", "");
            string datestr = DateTime.Now.AddDays(3).ToString();
            if (string.IsNullOrEmpty(stringValue)) Microsoft.Win32.Registry.SetValue(Registry_Path, "Expire", datestr);
            //ライセンスチェックを行う
            string LicenseKey = (string)Microsoft.Win32.Registry.GetValue(Registry_Path, Key_LicenseKey, "");
            bool showflag = false;
            if (string.IsNullOrEmpty(LicenseKey)) {
                //初回起動は必ずライセンス画面表示
                showflag = true;
            } else {
                //ライセンスチェックしてダメならライセンス画面表示
                if (!LicenseForm.checkCanUseWithErrorWindow()) showflag = true;
            }
            if (showflag) {
                //ライセンス画面をだす コントロール使えないように
                EnableFalse();
                this.StartAmazonButton.Enabled = false;
                LicenseForm lf = new LicenseForm(this);
                lf.Show();
            }
            #endregion
            
        }
        private void MainForm_SizeChanged(object sender, EventArgs e) {
            AdjustLayout();
        }

        private async void button1_Click(object sender, EventArgs e) {
            EnableFalse();
            timer1.Enabled = true;
            string query = "";
            if (!string.IsNullOrEmpty(textBox1.Text)) query = textBox1.Text;
            param.Clear();
            param.Add("page", "1");
            param.Add("query", query);
            param.Add("sort", "item_id");
            param.Add("order", "desc");
            toolStripStatusLabel1.Text = "データ取得を開始しました";
            api.stop_num = (int)numericUpDown2.Value;
            await Task.Run(() => resp_format = api.SearchItemWithCondition(param));
            toolStripStatusLabel1.Text = "データ解析を開始しました";
            count_dic = api.CountResponseByBrandName(resp_format, (int)this.numericUpDown1.Value, this.checkBox1.Checked);

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
            EnableTrue();
            toolStripStatusLabel1.Text = "";
        }

        private void AdjustLayout() {
            chart.Left = this.ConditionGroupBox.Width+10;
            DetailGroupBox.Left = this.ConditionGroupBox.Width+10;
            DetailGroupBox.Top = this.chart.Height+10;
        }
        private void ResetDetail() {
            MaxPriceLabel.Text = 0.ToString();
            MinPriceLabel.Text = 0.ToString();
            AveragePriceLabel.Text = 0.ToString();
            MaxLikeLabel.Text = 0.ToString();
            MinLikeLabel.Text = 0.ToString();
            AverageLikeLabel.Text = 0.ToString();
            MaxCommentLabel.Text = 0.ToString();
            MinCommentLabel.Text = 0.ToString();
            AverageCommentLabel.Text = 0.ToString();
            detail_query = "";
            DetailQueryLabel.Text = "None";
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
                        double max_like = 0;
                        double min_like = 9999;
                        double max_comment = 0;
                        double min_comment = 9999;
                        double average_like = 0;
                        double average_comment = 0;
                        int item_count = 0;
                        Dictionary<double, SellUserData> sell_user_data = new Dictionary<double,SellUserData>();

                        foreach(var val in resp_format.items) {

                            if (dp.AxisLabel == val.brand_name) {//クリックしたグラフの情報を取り出す
                                if (val.price > max_price) {
                                    max_price = val.price;
                                }
                                if (val.price < min_price) {
                                    min_price = val.price;
                                }
                                average_price += val.price;

                                //コメント、ライクカウント
                                average_like += val.like_count;
                                average_comment += val.comment_count;
                                if (val.like_count > max_like) {
                                    max_like = val.like_count;
                                }
                                if (val.like_count < min_like) {
                                    min_like = val.like_count;
                                }
                                if (val.comment_count > max_comment) {
                                    max_comment = val.comment_count;
                                }
                                if (val.comment_count < min_comment) {
                                    min_comment = val.comment_count;
                                }
                                //販売ユーザー情報
                                if (!sell_user_data.ContainsKey(val.user_id)) {//新規なら
                                    var dat = new SellUserData();
                                    dat.user_id = val.user_id;
                                    dat.screen_name = val.screen_name;
                                    dat.pc_url = val.pc_url;
                                    dat.item_count += 1;
                                    sell_user_data.Add(val.user_id,dat);
                                } else {
                                    sell_user_data[val.user_id].item_count += 1;
                                }

                                item_count += 1;
                            }
                        }
                 


                        //情報をセット
                        average_price /= item_count;
                        MaxPriceLabel.Text = ((int)max_price).ToString();
                        MinPriceLabel.Text = ((int)min_price).ToString();
                        AveragePriceLabel.Text = ((int)average_price).ToString();
                        average_like /= item_count;
                        MaxLikeLabel.Text = ((int)max_like).ToString();
                        MinLikeLabel.Text = ((int)min_like).ToString();
                        AverageLikeLabel.Text = ((int)average_like).ToString();
                        average_comment /= item_count;
                        MaxCommentLabel.Text = ((int)max_comment).ToString();
                        MinCommentLabel.Text = ((int)min_comment).ToString();
                        AverageCommentLabel.Text = ((int)average_comment).ToString();
                        detail_query = dp.AxisLabel;
                        DetailQueryLabel.Text = detail_query;
                        var orderdic = sell_user_data.OrderByDescending((x) => x.Value.item_count);
                        name = new string[5];
                        id = new double[5];
                        url = new string[5];
                        int count = 0;
                        foreach(var val in orderdic) {
                            if (count >= 5) break;
                            name[count] = val.Value.screen_name;
                            id[count] = val.Value.user_id;
                            url[count] = val.Value.pc_url;
                            Console.WriteLine(val.Value.user_id.ToString()+":"+val.Value.screen_name+":"+val.Value.item_count.ToString());
                            count += 1;
                        }

                        UserLabel0.Text = name[0];
                        if (!string.IsNullOrEmpty(UserLabel0.Text)) {
                            UserButton0.Enabled = true;
                        } else {
                            UserButton0.Enabled = false;
                        }
                        UserLabel1.Text = name[1];
                        if (!string.IsNullOrEmpty(UserLabel1.Text)) {
                            UserButton1.Enabled = true;
                        } else {
                            UserButton1.Enabled = false;
                        }
                        UserLabel2.Text = name[2];
                        if (!string.IsNullOrEmpty(UserLabel2.Text)) {
                            UserButton2.Enabled = true;
                        } else {
                            UserButton2.Enabled = false;
                        }
                        UserLabel3.Text = name[3];
                        if (!string.IsNullOrEmpty(UserLabel3.Text)) { UserButton3.Enabled = true;
                        } else {
                            UserButton3.Enabled = false;
                        }
                        UserLabel4.Text = name[4];
                        if (!string.IsNullOrEmpty(UserLabel4.Text)) {
                            UserButton4.Enabled = true;
                        } else {
                            UserButton4.Enabled = false;
                        }


                        break;
                    default:
                        MessageBox.Show("先に検索を行ってください");
                        break;
                }
            }

        }




        #region ボタン関連
        private void StartAmazonButton_Click(object sender, EventArgs e) {
            string url = "https://www.amazon.co.jp/s?field-keywords=";
            if (detail_query == "未指定") {
                System.Diagnostics.Process.Start(url);
            } else {
                url += detail_query;
                if (!string.IsNullOrEmpty(textBox1.Text)) {
                    url += " " + textBox1.Text;
                }
                url += "&tag=2018result-22";
                System.Diagnostics.Process.Start(url);
            }
        }
        private void UserButton0_Click(object sender, EventArgs e) {
            string url = this.url[0];
            System.Diagnostics.Process.Start(url);
        }
        private void UserButton1_Click(object sender, EventArgs e) {
            string url = this.url[1];
            System.Diagnostics.Process.Start(url);
        }
        private void UserButton2_Click(object sender, EventArgs e) {
            string url = this.url[2];
            System.Diagnostics.Process.Start(url);
        }
        private void UserButton3_Click(object sender, EventArgs e) {
            string url = this.url[3];
            System.Diagnostics.Process.Start(url);
        }
        private void UserButton4_Click(object sender, EventArgs e) {
            string url = this.url[4];
            System.Diagnostics.Process.Start(url);
        }
        #endregion
        #region ステータスバー表示関連
        private void chart_MouseHover(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "ダブルクリックで詳細を取得できます。";
        }

        private void chart_MouseLeave(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "";
        }

        private void StartAmazonButton_MouseHover(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "アマゾンで商品を検索します";
        }

        private void StartAmazonButton_MouseLeave(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "";
        }

        private void checkBox1_MouseHover(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "チェックオンで探索条件が未指定なものを除外します";
        }

        private void checkBox1_MouseLeave(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "";
        }

        private void numericUpDown2_Enter(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "サーバーからの情報取得数を選択します。多いほど時間がかかります。";
        }

        private void numericUpDown2_Leave(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "";
        }
        #endregion
        private void EnableFalse() {
            this.button1.Enabled = false;
            this.numericUpDown1.Enabled = false;
            this.numericUpDown2.Enabled = false;
            this.checkBox1.Enabled = false;
            this.UserButton0.Enabled = false;
            this.UserButton1.Enabled = false;
            this.UserButton2.Enabled = false;
            this.UserButton3.Enabled = false;
            this.UserButton4.Enabled = false;
        }
        private void EnableTrue() {
            this.button1.Enabled = true;
            this.numericUpDown1.Enabled = true;
            this.numericUpDown2.Enabled = true;
            this.checkBox1.Enabled = true;
        }
        #region プログレスバー関連
        private void timer1_Tick(object sender, EventArgs e) {
            //通知をバックグラウンドで取得する,新着通知があればメッセージを表示
            if (backgroundWorker1.IsBusy) return;
            else backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
            backgroundWorker1.ReportProgress(api.progress_num);
            //進捗を進める
            if (progressBar1.Value >= progressBar1.Maximum) {
                timer1.Enabled = false;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            //プログレスバーの値を変更する
            progressBar1.Value = e.ProgressPercentage;
        }
        #endregion
        #region ライセンス関連
        public const string Key_LicenseKey = "LicenseKey";
        public const string Registry_Path = @"HKEY_CURRENT_USER\Software\RakuHit";
        public const string ProductName = "RakuHit";
        public const string ProductKind = "rakuland";
        public void unlockLicense() {
            EnableTrue();
        }
        #endregion


    }
}
