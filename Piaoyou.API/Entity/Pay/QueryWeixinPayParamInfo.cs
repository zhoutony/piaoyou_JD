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
    /// 微信支付信息
    /// </summary>
    [Serializable]
    public class QueryWeixinPayParamInfo
    {
        /// <summary>
        /// Appid
        /// </summary>
        public string appId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string nonceStr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string package { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string paySign { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string signType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string timeStamp { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class QueryWeixinPayParamResult : OrderInvokeResult
    {
        /// <summary>
        /// 
        /// </summary>
        public QueryWeixinPayParamInfo data { get; set; }
    }
}
