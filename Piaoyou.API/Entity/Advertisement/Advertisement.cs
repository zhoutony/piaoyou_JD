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
    public class Advertisement
    {
        /// <summary>
        /// 广告ID
        /// </summary>
        public int advertisementID { get; set; }

        /// <summary>
        /// 广告名称
        /// </summary>
        public string advertisementName { get; set; }

        /// <summary>
        /// 广告类型
        /// 1--首页顶部,首页顶部广告必须关联一部电
        /// 2--首页中部
        /// 3--影片列表页顶部
        /// </summary>
        public int advertisementType { get; set; }

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
        /// 描述
        /// </summary>
        public string intro { get; set; }

        /// <summary>
        /// 影片信息
        /// </summary>
        public Movie movie { get; set; }

        /// <summary>
        ///是否为视频
        /// </summary>
        public int isVideo { get; set; }

        /// <summary>
        /// 视频信息
        /// </summary>
        public Video video { get; set; }
       
       
    }

    public class AdvertisementList
    {
        /// <summary>
        /// 广告集合
        /// </summary>
        public List<Advertisement> advertisements { get; set; }

        /// <summary>
        /// 第3个广告位置的序号
        /// </summary>
        public int thirdIndex { get; set; }

        /// <summary>
        /// 分享描述
        /// </summary>
        public ShareResult shareInfo { get; set; }

        public AdvertisementList()
        {
            this.advertisements = new List<Advertisement>();
            this.thirdIndex = 2;

            this.shareInfo = new ShareResult();
        }
    }


    /// <summary>
    /// 查询地区集合
    /// </summary>
    public class QueryAdvertisementsResult : InvokeResult
    {
        /// <summary>
        /// 广告集合
        /// </summary>
        public AdvertisementList data { get; set; }
    }
}
