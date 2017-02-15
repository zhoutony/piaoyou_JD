//===================================================================
// 文件名:		LocationInfo 
// 版权:		Copyright (C) 2011 Piaoyou
// 创建人:		tony.zhou
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
    public class WeiXinUserInfo
    {
        /// <summary>
        /// 微信公众号ID
        /// </summary>
        public int weixinBaseID { get; set; }

        /// <summary>
        ///公众号ID
        /// </summary>
        public string openID { get; set; }

        /// <summary>
        /// 票友用户ID
        /// </summary>
        public int userID { get; set; }

        /// <summary>
        /// 微信unionID
        /// </summary>
        public string unionID { get; set; }

        /// <summary>
        /// 关注时间
        /// </summary>
        public string subscribeTime { get; set; }

        /// <summary>
        /// 取消关注时间
        /// </summary>
        public string unsubscribeTime { get; set; }

        /// <summary>
        /// 用户状态；1--正常，0取消关注
        /// </summary>
        public int status { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string nick { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        public string country { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        public string province { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        public string city { get; set; }

        /// <summary>
        /// 图像
        /// </summary>
        public string headImgurl { get; set; }

        /// <summary>
        /// 性别，0--女，1男，2--未知
        /// </summary>
        public int sex { get; set; }

        /// <summary>
        /// 余额
        /// </summary>
        public int balance { get; set; }
    }

    /// <summary>
    /// 获取用户基本信息
    /// </summary>
    public class QueryWeiXinUserResult : InvokeResult
    {
        /// <summary>
        /// 用户信息
        /// </summary>
        public WeiXinUserInfo data { get; set; }
    }

}
