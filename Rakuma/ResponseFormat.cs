using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RakuHit.Rakuma {

    //sortについて
    //relevance:おすすめ順
    //item_id:新しい順 
    //さらにorder desc 新しい順 order ascをつけると古い順
    //sell_price:価格順
    //さらにorder asc 安い順 order desc 高い順
    //like_count
    //さらにorder desc
    public class ResponseFormat {
        public bool result = false;
        public List<Items> items = new List<Items>();
        public double? hit_count;
        public double? per_page;
        public string banner="";//?
        public Paging paging = new Paging();
    }
    public class Paging {
        public bool has_next;
        public double? next_page;
    }
    public class Items {
        public double? tl_id;
        public double? item_id;
        public double? img_id;
        public string img_date;
        public string img_url;
        public string item_name;
        public string item_detail;
        public double price;
        public double? t_status;
        public double? user_id;
        public string pc_url;
        public double? brand_id;//null
        public string brand_name;//null
        public double? i_brand_id;//null
        public string i_brand_name;//null
        public string screen_name;//null
        public string profile_img_url;//null
        public bool liked;
        public string created_at;//null
        public double? like_count;
        public double? comment_count;
        public string liked_user_name;
        public string liked_at;
        public string discount_rate;//null
    }


}
