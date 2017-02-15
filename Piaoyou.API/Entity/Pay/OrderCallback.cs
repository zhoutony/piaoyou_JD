using System;
using System.Xml.Serialization;
using TicketFriend.Community.Entity;
using System.Xml;
using Mtime.Helper;
using System.Text;
using System.Collections.Generic;

namespace JD.MovieAPI.Entity
{

    public class OrderCallback
    {
        public const string Success = "SUCCESS";

        public string return_code { get; set; }

        public string return_msg { get; set; }

        public string appid { get; set; }

        public string mch_id { get; set; }

        public string device_info { get; set; }

        public string nonce_str { get; set; }

        public string sign { get; set; }

        public string result_code { get; set; }

        public string err_code { get; set; }

        public string err_code_des { get; set; }

        public string openid { get; set; }

        public string is_subscribe { get; set; }

        public string trade_type { get; set; }
        public string bank_type { get; set; }
        public int total_fee { get; set; }
        public string fee_type { get; set; }
        public int cash_fee { get; set; }
        public string cash_fee_type { get; set; }
        public int coupon_fee { get; set; }
        public int coupon_count { get; set; }
        public string coupon_id_str { get; set; }
        public string coupon_fee_str { get; set; }
        public string transaction_id { get; set; }
        public string out_trade_no { get; set; }
        public string attach { get; set; }
        public string time_end { get; set; }

        public void Load(XmlDocument doc)
        {
            this.return_code = GetElementValue(doc, "/xml/return_code");
            this.return_msg = GetElementValue(doc, "/xml/return_msg");
            this.appid = GetElementValue(doc, "/xml/appid");
            this.mch_id = GetElementValue(doc, "/xml/mch_id");
            this.device_info = GetElementValue(doc, "/xml/device_info");
            this.nonce_str = GetElementValue(doc, "/xml/nonce_str");
            this.sign = GetElementValue(doc, "/xml/sign");
            this.result_code = GetElementValue(doc, "/xml/result_code");
            this.err_code = GetElementValue(doc, "/xml/err_code");
            this.err_code_des = GetElementValue(doc, "/xml/err_code_des");
            this.openid = GetElementValue(doc, "/xml/openid");
            this.is_subscribe = GetElementValue(doc, "/xml/is_subscribe");
            this.trade_type = GetElementValue(doc, "/xml/trade_type");
            this.bank_type = GetElementValue(doc, "/xml/bank_type");
            this.total_fee = ConvertHelper.ToInt32(GetElementValue(doc, "/xml/total_fee"), 0);
            this.fee_type = GetElementValue(doc, "/xml/fee_type");
            this.cash_fee = ConvertHelper.ToInt32(GetElementValue(doc, "/xml/cash_fee"));
            this.cash_fee_type = GetElementValue(doc, "/xml/cash_fee_type");
            this.coupon_fee = ConvertHelper.ToInt32(GetElementValue(doc, "/xml/coupon_fee"));
            this.coupon_count = ConvertHelper.ToInt32(GetElementValue(doc, "/xml/coupon_count"));
            this.transaction_id = GetElementValue(doc, "/xml/transaction_id");
            this.out_trade_no = GetElementValue(doc, "/xml/out_trade_no");
            this.attach = GetElementValue(doc, "/xml/attach");
            this.time_end = GetElementValue(doc, "/xml/time_end");

            var idlist = new List<string>();
            var feelist = new List<string>();
            for (int i = 0; i < coupon_count; i++)
            {
                idlist.Add(GetElementValue(doc, "/xml/coupon_id_"+i));
                feelist.Add(GetElementValue(doc, "/xml/coupon_fee_" + i));
            }
            this.coupon_id_str = string.Join(",", idlist.ToArray());
            this.coupon_fee_str = string.Join(",", feelist.ToArray());
        }

        public static string GetElementValue(XmlDocument doc, string xpath)
        {
            var elem = doc.SelectSingleNode(xpath);
            return elem == null ? string.Empty : elem.InnerText;
        }
    }
}