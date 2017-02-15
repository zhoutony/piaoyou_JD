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
    public class Movie
    {
        /// <summary>
        /// 影片ID
        /// </summary>
        public int movieID { get; set; }

        /// <summary>
        /// 影片中文名
        /// </summary>
        public string movieNameCN { get; set; }

        /// <summary>
        /// 影片英文名
        /// </summary>
        public string movieNameEN { get; set; }


        /// <summary>
        /// 影片图片
        /// </summary>
        public string movieImage { get; set; }

        /// <summary>
        /// 影片版本（2D，3D，IMAX，IMAX3D…….）,多个版本之间用英文的逗号隔开
        /// </summary>
        public string movieVersions { get; set; }

        /// <summary>
        /// 影片描述
        /// </summary>
        public string intro { get; set; }

        /// <summary>
        /// 是否购票
        /// </summary>
        public bool isBuyTicket { get; set; }

        /// <summary>
        /// 是否好友买单
        /// </summary>
        public bool isFriendsPay { get; set; }

        /// <summary>
        /// 是否要红包
        /// </summary>
        public bool isMoneyPacket { get; set; }
    }

    public class MovieDetail : Movie
    {
        /// <summary>
        /// 导演
        /// </summary>
        public string director { get; set; }

        /// <summary>
        /// 演员
        /// </summary>
        public string actors { get; set; }

        /// <summary>
        /// 上映时间
        /// </summary>
        public string releaseTime { get; set; }

        /// <summary>
        /// 片长
        /// </summary>
        public string filmLength { get; set; }

        /// <summary>
        /// 片场，分钟
        /// </summary>
        public int duration { get; set; }

    }

    public class MoviesList
    {
        /// <summary>
        /// 影片集合
        /// </summary>
        public List<MovieDetail> movies { get; set; }

        /// <summary>
        /// 分享描述
        /// </summary>
        public ShareResult shareInfo { get; set; }

        public MoviesList()
        {
            this.movies = new List<MovieDetail>();
            this.shareInfo = new ShareResult();
        }

    }

    /// <summary>
    /// 查询地区集合
    /// </summary>
    public class QueryMoviesResult : InvokeResultList
    {
        /// <summary>
        /// 影片集合
        /// </summary>
        public MoviesList data { get; set; }
    }
}
