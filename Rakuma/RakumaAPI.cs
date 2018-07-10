using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RakuHit.Rakuma {
    public class RakumaAPI {
        private const string USER_AGENT = "Mozilla/5.0 (iPhone; CPU iPhone OS 10_3_3 like Mac OS X) AppleWebKit/603.3.8 (KHTML, like Gecko) Mobile/14G60Rakuma/7.2.0";
        private string proxy;
        private const string XPLATFORM = "android";
        private const string XAPPVERSION = "600";

        //GET,POSTのRequestのResponse
        private class RakumaRawResponse {
            public bool error = false;
            public string response = "";
            public RakumaRawResponse() { }
            public RakumaRawResponse(string response, bool error = false) {
                this.response = response; this.error = error;
            }

        }


        private RakumaRawResponse getRakumaAPI(string url, Dictionary<string, string> param, CookieContainer cc, bool webmode = false) {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            //ストップウォッチを開始する
            sw.Start();
            RakumaRawResponse res = new RakumaRawResponse();
            try {
                //url = Uri.EscapeDataString(url);//日本語などを％エンコードする
                //パラメータをURLに付加 ?param1=val1&param2=val2...
                if (param.Count != 0) {
                    url += "?";
                    List<string> paramstr = new List<string>();
                    foreach (KeyValuePair<string, string> p in param) {
                        string k = Uri.EscapeDataString(p.Key);
                        string v = Uri.EscapeDataString(p.Value);
                        paramstr.Add(k + "=" + v);
                    }
                    url += string.Join("&", paramstr);
                }
                //HttpWebRequestの作成
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.CookieContainer = cc;
                req.UserAgent = RakumaAPI.USER_AGENT;
                req.Method = "GET";
                //webモードのときはauth_tokenをヘッダにいれる
                //if (webmode && !string.IsNullOrEmpty(this.account.auth_token)) req.Headers.Add("Authorization", this.account.auth_token);
                //プロキシの設定
                if (string.IsNullOrEmpty(this.proxy) == false) {
                    System.Net.WebProxy proxy = new System.Net.WebProxy(this.proxy);
                    req.Proxy = proxy;
                }
                //結果取得
                string content = "";
                var task = Task.Factory.StartNew(() => executeGetRequest(req));
                task.Wait(10000);
                if (task.IsCompleted) {
                    res = task.Result;
                } else
                    throw new Exception("Timed out");
                if (res.error) throw new Exception("webrequest error");
                //Log.Logger.Info("RakumaGETリクエスト成功");
                return res;
            } catch (Exception e) {
                //Log.Logger.Error("RakumaGETリクエスト失敗:" + res.response);
                Console.WriteLine(e);
                return res;
            }
        }
        private RakumaRawResponse executeGetRequest(HttpWebRequest req) {
            try {
                HttpWebResponse webres = (HttpWebResponse)req.GetResponse();
                Stream s = webres.GetResponseStream();
                StreamReader sr = new StreamReader(s);
                string content = sr.ReadToEnd();
                return new RakumaRawResponse(content, false);
            } catch {
                return new RakumaRawResponse("", true);
            }
        }


        //FrilAPIをPOSTでたたく
        private RakumaRawResponse postFrilAPI(string url, Dictionary<string, string> param, CookieContainer cc, bool webmode = false) {
           RakumaRawResponse res = new RakumaRawResponse();
            try {
                string text = "";
                List<string> paramstr = new List<string>();
                int num = 0;
                foreach (KeyValuePair<string, string> p in param) {
                    string k = Uri.EscapeDataString(p.Key);
                    string v = Uri.EscapeDataString(p.Value);
                    if (num != 0) text += "&";
                    text = text + (k + "=" + v);
                    num++;
                }
                byte[] bytes = Encoding.ASCII.GetBytes(text);
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.UserAgent =RakumaAPI.USER_AGENT;
                req.Method = "POST";
                //リクエストヘッダを付加
                req.Headers.Add("Accept-Encoding", "br, gzip, deflate");
                req.ContentType = "application/x-www-form-urlencoded";
                req.Accept = "*/*";
                req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                req.ContentLength = (long)bytes.Length;
                //webモードのときはauth_tokenをヘッダにいれる
                //if (webmode && !string.IsNullOrEmpty(this.account.auth_token)) req.Headers.Add("Authorization", this.account.auth_token);
                //クッキーコンテナの追加
                req.CookieContainer = cc;
                //プロキシの設定
                if (string.IsNullOrEmpty(this.proxy) == false) {
                    System.Net.WebProxy proxy = new System.Net.WebProxy(this.proxy);
                    req.Proxy = proxy;
                }
                //タイムアウト設定
                req.Timeout = 5000;
                //POST
                string content = "";
                var task = Task.Factory.StartNew(() => executePostRequest(ref req, bytes));
                task.Wait(10000);
                if (task.IsCompleted) {
                    content = task.Result;
                    Console.WriteLine(content);
                } else {
                    throw new Exception("Timed out");
                }
                if (res.error) throw new Exception("webrequest error");
                //if (res.Contains("false")) throw new Exception("item result false");
                res.error = false;
                res.response = content;
                //Log.Logger.Error("FrilPOSTリクエスト失敗" + res.response);
                req.Abort();
                return res;
            } catch (Exception e) {

                Console.WriteLine(e);
                //Log.Logger.Error("FrilPOSTリクエスト失敗");
                return res;
            }
        }
        private string executePostRequest(ref HttpWebRequest req, byte[] bytes) {
            try {
                using (Stream requestStream = req.GetRequestStream()) {
                    requestStream.Write(bytes, 0, bytes.Length);
                }
                //結果取得
                using (Stream responseStream = req.GetResponse().GetResponseStream()) {
                    using (StreamReader streamReader = new StreamReader(responseStream, Encoding.GetEncoding("UTF-8"))) {
                        return streamReader.ReadToEnd();
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex);
                if (ex.Message.Contains("500")) {
                    Console.WriteLine("500エラーメッセボックスだします");
                    MessageBox.Show("500エラーです。");

                }
                return "";
            }
        }
        private RakumaRawResponse executePostRequest(HttpWebRequest req, byte[] bytes) {
            try {
                using (Stream requestStream = req.GetRequestStream()) {
                    requestStream.Write(bytes, 0, bytes.Length);
                }
                //結果取得
                string result = "";
                using (Stream responseStream = req.GetResponse().GetResponseStream()) {
                    using (StreamReader streamReader = new StreamReader(responseStream, Encoding.GetEncoding("UTF-8"))) {
                        return new RakumaRawResponse(streamReader.ReadToEnd(), false);
                    }
                }
            } catch {
                return new RakumaRawResponse("", true);
            }
        }




    }
}
