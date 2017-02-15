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
    public class WiexinRightConfig
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        public string appId { get; set; }

        /// <summary>
        /// 必填，生成签名的时间戳
        /// </summary>
        public int timestamp { get; set; }

        /// <summary>
        /// 必填，生成签名的随机串
        /// </summary>
        public string nonceStr { get; set; }

        /// <summary>
        /// 必填，签名，见附录1
        /// </summary>
        public string signature { get; set; }

    }

    /// <summary>
    /// 微信配置信息结果
    /// </summary>
    public class QueryWeixinRightConfigResult:InvokeResult
    {
        /// <summary>
        /// 微信权限配置信息
        /// </summary>
        public WiexinRightConfig data { get; set; }
    }

}
