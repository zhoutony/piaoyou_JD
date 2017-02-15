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
    /// 查看订单详情
    /// </summary>
    [Serializable]
    public class Order
    {
        /// <summary>
        /// 平台订单号
        /// </summary>
        public string orderID { get; set; }
        /// <summary>
        /// 电影ID
        /// </summary>
        public int movieID { get; set; }
        /// <summary>
        /// 电影名称
        /// </summary>
        public string movieName { get; set; }
        /// <summary>
        /// 影院ID
        /// </summary>
        public int cinemaID { get; set; }
        /// <summary>
        /// 影片版本（2D，3D，IMAX，IMAX3D…….）
        /// </summary>
        public string movieVersions { get; set; }
        /// <summary>
        ///影院名称
        /// </summary>
        public string cinemaName { get; set; }
        /// <summary>
        /// 影厅ID
        /// </summary>
        public int hallID { get; set; }
        /// <summary>
        /// 影厅名称
        /// </summary>
        public string hallName { get; set; }
        /// <summary>
        /// 订单金额
        /// </summary>
        public int amount { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string mobile { get; set; }
        /// <summary>
        /// 放映时间（格式: yyyy-MM-dd HH:mm:ss）
        /// </summary>
        public string showTime { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int count { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public int price { get; set; }
        /// <summary>
        /// 座位
        /// </summary>
        public string seatName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool status { get; set; }

        public string orderCode { get; set; }

        public string PrintCode { get; set; }

        public string VerifyCode { get; set; }

        public string ChangeInfo { get; set; }

    }
    /// <summary>
    /// 订单集合
    /// </summary>
    public class OrderList
    {
        public List<Order> orders { get; set; }
        public OrderList()
        {
            this.orders = new List<Order>();
        }
    }
    /// <summary>
    //查询订单详情
    /// </summary>
    public class OrderResult : InvokeResultList
    {
        /// <summary>
        /// 订单详情返回结果
        /// </summary>
        public OrderList data { get; set; }
    }
}
