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
    /// 微信基础配置信息
    /// </summary>
    [Serializable]
    public class WeixinBaseConfigInfo
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        public string appId { get; set; }

        /// <summary>
        /// 应用密钥
        /// </summary>
        public string appSecret { get; set; }

        /// <summary>
        /// 令牌
        /// </summary>
        public string token { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        public string merchantId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        public string merchantName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string currentToken { get; set; }

        /// <summary>
        /// 支付api密钥
        /// </summary>
        public string merchantApiKey { get; set; }

        /// <summary>
        /// 消息加解密密钥
        /// </summary>
        public string encodingAESKey { get; set; }

        /// <summary>
        /// 微信号
        /// </summary>
        public  string weixinNo { get; set; }
    }

    /// <summary>
    /// 微信配置信息结果
    /// </summary>
    public class QueryWeixinBaseConfigInfoResult : InvokeResult
    {
        /// <summary>
        /// 微信配置信息
        /// </summary>
        public WeixinBaseConfigInfo data { get; set; }
    }

}
