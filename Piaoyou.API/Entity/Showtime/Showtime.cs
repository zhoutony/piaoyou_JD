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
    /// 场次信息
    /// </summary>
    [Serializable]
    public class ShowtimeInfo
    {
        /// <summary>
        /// 场次ID
        /// </summary>
        public int showtimeID { get; set; }

        /// <summary>
        /// 影片ID
        /// </summary>
        public int movieID { get; set; }

        /// <summary>
        /// 影院ID
        /// </summary>
        public int cinemaID { get; set; }


        /// <summary>
        /// 影厅ID
        /// </summary>
        public int hallID { get; set; }

        /// <summary>
        /// 影厅名称
        /// </summary>
        public string hallName { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        public string version { get; set; }

        /// <summary>
        /// 语言
        /// </summary>
        public string language { get; set; }

        /// <summary>
        /// 场次开始时间
        /// </summary>
        public string ticketStartTime { get; set; }

        /// <summary>
        /// 场次结束时间
        /// </summary>
        public string ticketEndTime { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public string price { get; set; }

        /// <summary>
        /// 门市价
        /// </summary>
        public string retailPrice { get; set; }

        /// <summary>
        /// 优惠信息
        /// </summary>
        public string voucherNote { get; set; }

        /// <summary>
        /// 放映时间
        /// </summary>
        public string showTime { get; set; }

        /// <summary>
        /// 时长，单位分钟
        /// </summary>
        public int duration { get; set; }

        /// <summary>
        /// 停售时间
        /// </summary>
        public bool stopSellTime { get; set; }

        /// <summary>
        /// true显示太阳图标,false显示月亮图标
        /// </summary>
        public bool isSun { get; set; }
    }

    public class ShowtimeInfoDates
    {
        /// <summary>
        /// 时间字符串
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// 场次集合
        /// </summary>
        public List<ShowtimeInfo> shows { get; set; }

        /// <summary>
        /// 分享描述
        /// </summary>
        public ShareResult shareInfo { get; set; }

        public ShowtimeInfoDates()
        {
            this.shows = new List<ShowtimeInfo>();
            this.shareInfo = new ShareResult();
        }
    }

    public class ShowtimeListResult
    {
        /// <summary>
        /// 场次集合
        /// </summary>
        public List<ShowtimeInfoDates> shows { get; set; }

        /// <summary>
        /// 影院信息
        /// </summary>
        public CinemaInfo cinema { get; set; }

        /// <summary>
        /// 影片集合
        /// </summary>
        public List<MovieDetail> movies { get; set; }

        /// <summary>
        /// 分享描述
        /// </summary>
        public ShareResult shareInfo { get; set; }

        public ShowtimeListResult()
        {
            this.shows = new List<ShowtimeInfoDates>();
            this.cinema = new CinemaInfo();
            this.movies = new List<MovieDetail>();
            this.shareInfo = new ShareResult();
        }
    }

    /// <summary>
    /// 查询场次集合
    /// </summary>
    public class QueryShowsResult : InvokeResultList
    {
        /// <summary>
        /// 场次集合
        /// </summary>
        public ShowtimeListResult data { get; set; }
        public QueryShowsResult()
        {
            this.data = new ShowtimeListResult();
        }
    }
}
