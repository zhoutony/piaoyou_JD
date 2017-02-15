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
    /// 广告信息
    /// </summary>
    [Serializable]
    public class AdsInfo
    {
        /// <summary>
        /// 广告ID
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 广告位置
        /// 1--首页顶部,首页顶部广告必须关联一部电
        /// 2--首页中部
        /// 3--影片列表页顶部
        /// </summary>
        public string adsLocation { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        public string imageUrl { get; set; }

        /// <summary>
        /// 跳转URL
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// 影片ID
        /// </summary>
        public int movieID { get; set; }

        /// <summary>
        /// 视频ID
        /// </summary>
        public int videoID { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string intro { get; set; }

        /// <summary>
        /// 广告类型，video视频广告，imageText--图文，movieTicket--购票
        /// </summary>
        public string advertisementType { get; set; }

        /// <summary>
        /// 影片中文名
        /// </summary>
        public string movieNameCN { get; set; }

        /// <summary>
        /// 时长，格式为hh:ss
        /// </summary>
        public string duration { get; set; }

        /// <summary>
        /// 影片详情
        /// </summary>
        public MovieDetail movie { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime createTime { get; set; }

        /// <summary>
        /// 点击次数
        /// </summary>
        public int count { get; set; }
    }

    public class AdsInfoList
    {
        /// <summary>
        /// 广告集合
        /// </summary>
        public List<AdsInfo> advertisements { get; set; }

        /// <summary>
        /// 分享描述
        /// </summary>
        public ShareResult shareInfo { get; set; }

        public AdsInfoList()
        {
            this.advertisements = new List<AdsInfo>();
            this.shareInfo = new ShareResult();
        }
    }

    /// <summary>
    /// 查询地区集合
    /// </summary>
    public class QueryAdsInfoResult : InvokeResult
    {
        /// <summary>
        /// 广告集合
        /// </summary>
        public AdsInfoList data { get; set; }
    }
}
