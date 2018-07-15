using Codeplex.Data;
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
        public CookieContainer cc = new CookieContainer();
        public MainForm main_form;
        public int progress_num;

        public RakumaAPI(MainForm form) {
            this.main_form = form;
        }


        //レスポンスを300件まで取得する
        public ResponseFormat SearchItemWithCondition(Dictionary<string,string> param) {
            try {
                ResponseFormat resp_format = new ResponseFormat();
                this.progress_num = 0;
                #region 一回目の取得
                string url = "https://api.fril.jp/api/v3/items/search/open";
                RakumaRawResponse rawres = getRakumaAPI(url, param, this.cc);
                if (rawres.error) throw new Exception("ネットワークエラーが発生しています。レスポンスが取得できません。");
                dynamic resjson = DynamicJson.Parse(rawres.response);
                resp_format.result = resjson.result;
                int item_count = -1;
                foreach (var val in resjson.items) {
                    resp_format.items.Add(new Items());
                    item_count += 1;
                    resp_format.items[item_count].tl_id = val.tl_id;
                    resp_format.items[item_count].item_id = val.item_id;
                    resp_format.items[item_count].img_id = val.img_id;
                    resp_format.items[item_count].img_date = val.img_date;
                    resp_format.items[item_count].img_url = val.img_url;
                    resp_format.items[item_count].item_name = val.item_name;
                    resp_format.items[item_count].item_detail = val.item_detail;
                    resp_format.items[item_count].price = val.price;
                    resp_format.items[item_count].t_status = val.t_status;
                    resp_format.items[item_count].user_id = val.user_id;
                    resp_format.items[item_count].pc_url = val.pc_url;
                    resp_format.items[item_count].brand_id = val.brand_id;
                    if (!string.IsNullOrEmpty(val.brand_name)) resp_format.items[item_count].brand_name = val.brand_name;
                    resp_format.items[item_count].i_brand_id = val.i_brand_id;
                    if (!string.IsNullOrEmpty(val.i_brand_name)) resp_format.items[item_count].i_brand_name = val.i_brand_name;
                    resp_format.items[item_count].screen_name = val.screen_name;
                    if (!string.IsNullOrEmpty(val.profile_img_url)) resp_format.items[item_count].profile_img_url = val.profile_img_url;
                    resp_format.items[item_count].liked = val.liked;
                    resp_format.items[item_count].created_at = val.created_at;
                    resp_format.items[item_count].like_count = val.like_count;
                    resp_format.items[item_count].comment_count = val.comment_count;
                    resp_format.items[item_count].liked_user_name = val.liked_user_name;
                    resp_format.items[item_count].liked_at = val.liked_at;
                    resp_format.items[item_count].discount_rate = val.discount_rate;
                }
                resp_format.hit_count = resjson.hit_count;
                resp_format.per_page = resjson.per_page;
                //resp_format.banner = resjson.banner;FIXME:挙動不明
                resp_format.paging.has_next = resjson.paging.has_next;
                resp_format.paging.next_page = resjson.paging.next_page;
                #endregion
                this.progress_num = (int)(item_count/resp_format.hit_count);
                #region 2週目以降の取得
                while (item_count < 400 && resp_format.paging.has_next) {
                    param["page"] = resp_format.paging.next_page.ToString();
                    rawres = getRakumaAPI(url, param, this.cc);
                    if (rawres.error) throw new Exception("ネットワークエラーが発生しています。レスポンスが取得できません");
                    resjson = DynamicJson.Parse(rawres.response);
                    resp_format.result = resjson.result;
                    foreach (var val in resjson.items) {
                        resp_format.items.Add(new Items());
                        item_count += 1;
                        resp_format.items[item_count].tl_id = val.tl_id;
                        resp_format.items[item_count].item_id = val.item_id;
                        resp_format.items[item_count].img_id = val.img_id;
                        resp_format.items[item_count].img_date = val.img_date;
                        resp_format.items[item_count].img_url = val.img_url;
                        resp_format.items[item_count].item_name = val.item_name;
                        resp_format.items[item_count].item_detail = val.item_detail;
                        resp_format.items[item_count].price = val.price;
                        resp_format.items[item_count].t_status = val.t_status;
                        resp_format.items[item_count].user_id = val.user_id;
                        resp_format.items[item_count].pc_url = val.pc_url;
                        resp_format.items[item_count].brand_id = val.brand_id;
                        if (!string.IsNullOrEmpty(val.brand_name)) resp_format.items[item_count].brand_name = val.brand_name;
                        resp_format.items[item_count].i_brand_id = val.i_brand_id;
                        if (!string.IsNullOrEmpty(val.i_brand_name)) resp_format.items[item_count].i_brand_name = val.i_brand_name;
                        resp_format.items[item_count].screen_name = val.screen_name;
                        if (!string.IsNullOrEmpty(val.profile_img_url)) resp_format.items[item_count].profile_img_url = val.profile_img_url;
                        resp_format.items[item_count].liked = val.liked;
                        resp_format.items[item_count].created_at = val.created_at;
                        resp_format.items[item_count].like_count = val.like_count;
                        resp_format.items[item_count].comment_count = val.comment_count;
                        resp_format.items[item_count].liked_user_name = val.liked_user_name;
                        resp_format.items[item_count].liked_at = val.liked_at;
                        resp_format.items[item_count].discount_rate = val.discount_rate;
                    }
                    resp_format.hit_count = resjson.hit_count;
                    resp_format.per_page = resjson.per_page;
                    //resp_format.banner = resjson.banner;FIXME:挙動不明
                    resp_format.paging.has_next = resjson.paging.has_next;
                    if (resp_format.paging.has_next == false) break;
                    resp_format.paging.next_page = resjson.paging.next_page;
                    this.progress_num = (int)(item_count / resp_format.hit_count);
                }
                #endregion
                this.progress_num = Math.Max((int)(item_count / resp_format.hit_count),80);
                return resp_format;
            }catch(Exception ex) {
                Console.WriteLine(ex);
                return new ResponseFormat();
            }
        }

        //レスポンスを解析する
        public Dictionary<string,int> CountResponseByBrandName(ResponseFormat resp_format,int remove_rate,bool remove_nodata) {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic["未指定"] = 0;
            foreach(var val in resp_format.items) {
                if (string.IsNullOrEmpty(val.brand_name)) {//ブランドがnull
                    dic["未指定"] += 1;
                } else {
                    if (dic.ContainsKey(val.brand_name)) {//ブランドが既に辞書にある時
                        dic[val.brand_name] += 1;
                    } else {
                        dic.Add(val.brand_name, 1);
                    }
                }
            }
            double del_item_count = 0;
            //未指定を除去する設定
            if (remove_nodata) {//FIXME:条件分岐
                del_item_count = -dic["未指定"];
                dic.Remove("未指定");
            }
            //20%に満たないと除去する設定
            if (true) {//FIXME:ここは削除設定のon,off分岐
                List<string> del_list = new List<string>();
                del_item_count += resp_format.items.Count;
                del_item_count *= (double)remove_rate / 100.0;//これ以下のvalue値を持つものを削除
                foreach(var val in dic) {
                    if (val.Value < del_item_count) {
                        del_list.Add(val.Key);
                    }
                }
                foreach(var val in del_list) {
                    dic.Remove(val);
                }
            }
            //foreach(var val in dic) {
            //    Console.WriteLine(val.Key + ":" + val.Value.ToString());
            //}
            this.progress_num = 100;
            return dic;
        }



        #region APIリクエストテンプレート
        //GET,POSTのRequestのResponse
        private class RakumaRawResponse {
            public bool error = false;
            public string response = "";
            public RakumaRawResponse() { }
            public RakumaRawResponse(string response, bool error = false) {
                this.response = response; this.error = error;
            }
        }
        //FrilAPIをPOSTでたたく
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
            } catch(Exception ex) {
                Console.WriteLine(ex);
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
        #endregion
    }
}
