//===================================================================
// 文件名:		VideoInfo 
// 版权:		Copyright (C) 2011 Piaoyou
// 创建人:		wei
// 创建日期:	2016/4/26
// 描述:		
// 备注:		
//===================================================================

using System;
using System.Collections.Generic;
using System.Text;
using Mtime.Data;
using TicketFriend.Community.Entity;

namespace JD.MovieAPI.Entity
{
    /// <summary>
    /// 视频信息
    /// </summary>
    [Serializable]
    public class Video
    {
        /// <summary>
        /// 视频ID
        /// </summary>
        public int vID { get; set; }

        /// <summary>
        /// 样式类型,0--预告片样式，1--正片样式
        /// </summary>
        public int styleType { get; set; }

        /// <summary>
        ///视频URL
        /// </summary>
        public string videoUrl { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        public string summry { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        public string publishTime { get; set; }

        /// <summary>
        ///自媒体名称
        /// </summary>
        public string sourceName { get; set; }

        /// <summary>
        /// 时长，格式为hh:ss
        /// </summary>
        public string duration { get; set; }

        /// <summary>
        /// logoUrl
        /// </summary>
        public string logoUrl { get; set; }

        /// <summary>
        /// 视频播放次数
        /// </summary>
        public int count { get; set; }

    }

    public class VideoInfoList
    {
        /// <summary>
        /// 视频集合
        /// </summary>
        public List<Video> videos { get; set; }

        public VideoInfoList()
        {
            this.videos = new List<Video>();
        }
    }


    /// <summary>
    /// 查询地区集合
    /// </summary>
    public class QueryVideosResult : InvokeResult
    {
        /// <summary>
        /// 地区集合
        /// </summary>
        public VideoInfoList data { get; set; }
    }


    public class VideoList : InvokeResult
    {
        public VideoList()
        {
            Videos = new List<VideoInfo>();
        }
        public List<VideoInfo> Videos { get; set; }
    }

}
