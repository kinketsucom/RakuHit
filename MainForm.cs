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
        public MainForm() {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e) {
        }



        private void button1_Click(object sender, EventArgs e) {
            Dictionary<string, string> param = new Dictionary<string, string>();
            ResponseFormat resp_format = new ResponseFormat();
            param.Add("page", "1");
            param.Add("query", "中学用制服");
            param.Add("sort", "relevance");
            resp_format = api.SearchItemWithCondition(param);
            api.CountResponseBySize(resp_format);
        }


    }
}
