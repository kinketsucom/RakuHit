using RakuHit.Rakuma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RakuHit.Forms {
    public partial class DataForm : Form {
        private List<Items> load_items;
        private string detail_query;

        public DataForm() {
            InitializeComponent();
        }
        public DataForm(List<Items> load_items,string detail_query) {
            InitializeComponent();
            this.load_items = load_items;
            this.detail_query = detail_query;
        }

        private void DataForm_Load(object sender, EventArgs e) {
            foreach (var val in load_items) {
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(val.img_url);
                myRequest.Method = "GET";
                HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(myResponse.GetResponseStream());
                myResponse.Close();
                bmp = ResizeImage(bmp, 100, 100);
                dataGridView1.Rows.Add(bmp, val.item_name, val.price,val.screen_name,"Rakuma","Amazon");
            }
        }

        private static Bitmap ResizeImage(Bitmap image, double dw, double dh) {
            double hi;
            double imagew = image.Width;
            double imageh = image.Height;
            if ((dh / dw) <= (imageh / imagew)) {
                hi = dh / imageh;
            } else {
                hi = dw / imagew;
            }
            int w = (int)(imagew * hi);
            int h = (int)(imageh * hi);
            Bitmap result = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(result);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(image, 0, 0, result.Width, result.Height);
            return result;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            DataGridView dgv = (DataGridView)sender;
            //"Button"列ならば、ボタンがクリックされた
            if (dgv.Columns[e.ColumnIndex].Name == "RakumaButtonColumn") {
                System.Diagnostics.Process.Start(load_items[e.RowIndex].pc_url);
            }
            if (dgv.Columns[e.ColumnIndex].Name == "AmazonButtonColumn") {
                string url = "https://www.amazon.co.jp/s?field-keywords=";
                if (this.detail_query == "未指定") {
                    System.Diagnostics.Process.Start(url);
                } else {
                    string query = load_items[e.RowIndex].brand_name;
                    if (query.Contains("&")) query = query.Replace("&", "%26");
                    string query2 = load_items[e.RowIndex].item_name;
                    if(!string.IsNullOrEmpty(query2)) query += " "+RemoveUnnecessaryWord(query2);
                    url += query;
                    url += "&tag=2018result-22";
                    System.Diagnostics.Process.Start(url);
                }
            }
        }
    
        private string RemoveUnnecessaryWord(string query) {
            if (query.Contains(detail_query)) query = query.Replace(detail_query, " ");
            if (query.Contains("&")) query = query.Replace("&", "%26");
            if (query.Contains("新品")) query = query.Replace("新品", " ");
            if(query.Contains("【")) query = query.Replace("【", " ");
            if(query.Contains("】")) query = query.Replace("】", " ");
            if(query.Contains("『")) query = query.Replace("『", " ");
            if(query.Contains("』")) query = query.Replace("』", " ");
            if (query.Contains("美品")) query = query.Replace("美品", " ");
            if (query.Contains("良品")) query = query.Replace("良品", " ");
            if (query.Contains("☆本日限定価格☆")) query = query.Replace("☆本日限定価格☆", " ");
            if (query.Contains("正規品")) query = query.Replace("正規品", " ");
            if (query.Contains("本物")) query = query.Replace("本物", " ");
            var pattern = @"\s\s+";
            var regex = new Regex(pattern);
            query = regex.Replace(query, " ");
            return query;
        }




    }
}
