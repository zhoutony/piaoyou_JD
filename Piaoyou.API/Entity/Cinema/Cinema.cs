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
    /// 影片信息
    /// </summary>
    [Serializable]
    public class CinemaInfo
    {
        /// <summary>
        /// 影院ID
        /// </summary>
        public int cinemaID { get; set; }

        /// <summary>
        /// 影院名称
        /// </summary>
        public string cinemaName { get; set; }

        /// <summary>
        /// 影院地址
        /// </summary>
        public string cinemaAddress { get; set; }

        /// <summary>
        /// 省份ID
        /// </summary>
        public int provinceID { get; set; }

        /// <summary>
        /// 城市ID
        /// </summary>
        public int cityID { get; set; }

        /// <summary>
        /// 地区ID
        /// </summary>
        public int districtID { get; set; }

        /// <summary>
        /// 省名称
        /// </summary>
        public string provinceName { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        public string cityName { get; set; }

        /// <summary>
        /// 区域名称
        /// </summary>
        public string districtName { get; set; }

        /// <summary>
        /// 场次数字符串；”今日剩余10场”或者”今日暂无场次”
        /// </summary>
        public string showTimeCount { get; set; }

        /// <summary>
        /// 优惠描述
        /// </summary>
        public string voucherNote { get; set; }

        /// <summary>
        /// 门市价
        /// </summary>
        public string retailPrice { get; set; }

        /// <summary>
        /// 最低价格
        /// </summary>
        public string limitPrice { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        public decimal latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        public decimal longitude { get; set; }

        /// <summary>
        /// 是否在线选座
        /// </summary>
        public bool isTicket { get; set; }

        /// <summary>
        ///即将上映的场次信息
        /// </summary>
        public string RecentShowtime { get; set; }
    }

    public class QueryCinemasResultInfo
    {
        /// <summary>
        /// 影院集合
        /// </summary>
        public List<CinemaInfo> cinemas { get; set; }

        /// <summary>
        /// 影片信息
        /// </summary>
        public MovieDetail movie { get; set; }

        /// <summary>
        /// 分享描述
        /// </summary>
        public ShareResult shareInfo { get; set; }

        public QueryCinemasResultInfo()
        {
            this.cinemas = new List<CinemaInfo>();
            this.movie = new MovieDetail();
            this.shareInfo = new ShareResult();
        }
    }

    /// <summary>
    /// 查询地区集合
    /// </summary>
    public class QueryCinemasResult : InvokeResultList
    {
        /// <summary>
        /// 数据集合
        /// </summary>
        public QueryCinemasResultInfo data { get; set; }

    }


}
