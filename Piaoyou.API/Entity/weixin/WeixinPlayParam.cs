//===================================================================
// 文件名:		LocationInfo 
// 版权:		Copyright (C) 2011 Piaoyou
// 创建人:		xu
// 创建日期:	2015-9-20
// 描述:		
// 备注:		
//===================================================================

using System;
using System.Collections.Generic;
using System.Text;
using Mtime.Data;

namespace JD.MovieAPI.Entity
{
    /// <summary>
    /// 微信支付参数
    /// </summary>
    [Serializable]
    public class WeixinPlayParam
    {
        /// <summary>
        /// 商户注册具有支付权限的公众号成功后即可获得
        /// </summary>
        public string appId { get; set; }

        /// <summary>
        ///当前的时间，其他详见时间戳规则
        /// </summary>
        public string timeStamp { get; set; }

        /// <summary>
        /// 随机字符串，不长于32位。推荐随机数生成算法
        /// </summary>
        public string nonceStr { get; set; }

        /// <summary>
        /// 统一下单接口返回的prepay_id参数值，提交格式如：prepay_id=***
        /// </summary>
        public  string package { get; set; }

        /// <summary>
        /// 签名算法，暂支持MD5
        /// </summary>
        public  string signType { get; set; }

        /// <summary>
        /// 签名，详见签名生成算法
        /// </summary>
        public string paySign { get; set; }

    }

    /// <summary>
    /// 获取全局AccessToken
    /// </summary>
    public class QueryWeixinPlayParamResult : InvokeResult
    {
        /// <summary>
        /// 微信支付
        /// </summary>
        public WeixinPlayParam data { get; set; }
    }

}
