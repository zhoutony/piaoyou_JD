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
using System.Security.Policy;
using System.Text;
using Mtime.Data;

namespace JD.MovieAPI.Entity
{
    /// <summary>
    /// 锁座结果信息
    /// </summary>
    [Serializable]
    public class LockSeatsInfo
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        public string orderID { get; set; }

        /// <summary>
        /// 锁座时长（分钟）
        /// </summary>
        public int lockTime { get; set; }

        /// <summary>
        /// 影片名称
        /// </summary>
        public string movieName { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        public string version { get; set; }

        /// <summary>
        /// 放映时间
        /// </summary>
        public string showTime { get; set; }

        /// <summary>
        /// 影院ID
        /// </summary>
        public int cinemaID { get; set; }

        /// <summary>
        /// 座位ID
        /// </summary>
        public string seatIDs { get; set; }

        /// <summary>
        /// 座位名称
        /// </summary>
        public string seatNames { get; set; }

        /// <summary>
        /// 支付截至时间
        /// </summary>
        public string playEndTime { get; set; }

        /// <summary>
        /// 影片ID
        /// </summary>
        public int movieID { get; set; }
    }

    /// <summary>
    /// 锁座返回结果
    /// </summary>
    public class LockSeatsInfoResult : InvokeResult
    {
        /// <summary>
        /// 锁座返回结果
        /// </summary>
        public LockSeatsInfo data { get; set; }
    }
}
