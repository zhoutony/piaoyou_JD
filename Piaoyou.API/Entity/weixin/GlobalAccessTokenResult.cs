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
    /// 全局AccessToken
    /// </summary>
    [Serializable]
    public class GlobalAccessTokenResult
    {
        /// <summary>
        /// 网页授权接口调用凭证,注意：此access_token与基础支持的access_token不同
        /// </summary>
        public string accessToken { get; set; }

        /// <summary>
        /// access_token接口调用凭证超时时间，单位（秒）
        /// </summary>
        public int expiresIn { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        public string expireTime { get; set; }

    }

    /// <summary>
    /// 获取全局AccessToken
    /// </summary>
    public class QueryGlobalAccessTokenResult : InvokeResult
    {
        /// <summary>
        /// 全局AccessToken
        /// </summary>
        public GlobalAccessTokenResult data { get; set; }
    }

}
