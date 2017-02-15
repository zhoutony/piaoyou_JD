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
    /// 座位信息
    /// </summary>
    [Serializable]
    public class SeatInfo
    {
        /// <summary>
        /// 座位ID
        /// </summary>
        public string seatID { get; set; }

        /// <summary>
        /// 行号
        /// </summary>
        public string rowNum { get; set; }

        /// <summary>
        /// 列号
        /// </summary>
        public string colNum { get; set; }

        /// <summary>
        /// 横坐标 
        /// </summary>
        public int xCoord { get; set; }

        /// <summary>
        /// 纵坐标
        /// </summary>
        public int yCoord { get; set; }

        /// <summary>
        /// 座位名称
        /// </summary>
        public string seatName { get; set; }

        /// <summary>
        /// 座位类型（1：普通 2：左情侣，3右情侣）
        /// </summary>
        public int type { get; set; }

        /// <summary>
        /// 情侣座编码。当座位类型是情侣座时才有该编码，情侣座编码相同的两个座位互相关联。
        /// </summary>
        public string loveCode { get; set; }

        /// <summary>
        /// 可售状态（0：不可售 1：可售，2不是座位）
        /// </summary>
        public int status { get; set; }
    }

    public class SeatsResult
    {
        /// <summary>
        /// 座位集合
        /// </summary>
        public List<SeatInfo> seats { get; set; }

        /// <summary>
        /// 影院信息
        /// </summary>
        public CinemaInfo cinema { get; set; }

        /// <summary>
        /// 影片
        /// </summary>
        public Movie movie { get; set; }

        /// <summary>
        /// 场次
        /// </summary>
        public ShowtimeInfo show { get; set; }

        /// <summary>
        /// 分享描述
        /// </summary>
        public ShareResult shareInfo { get; set; }

        public SeatsResult()
        {
            this.cinema = new CinemaInfo();
            this.movie = new Movie();
            this.seats = new List<SeatInfo>();
            this.show = new ShowtimeInfo();
            this.shareInfo = new ShareResult();
        }
    }

    /// <summary>
    /// 查询场次集合
    /// </summary>
    public class QueryShowSeatsResult : InvokeResultList
    {
        /// <summary>
        /// 座位信息
        /// </summary>
        public SeatsResult data { get; set; }
    }

}
