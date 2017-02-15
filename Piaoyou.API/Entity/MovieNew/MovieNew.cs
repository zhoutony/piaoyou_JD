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
using Mtime.Collections;
using Mtime.Data;

namespace JD.MovieAPI.Entity
{
    /// <summary>
    /// 影片新闻
    /// </summary>
    [Serializable]
    public class MovieNew
    {
        /// <summary>
        /// 新闻ID
        /// </summary>
        public int movieNewID { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 图片1
        /// </summary>
        public string image1 { get; set; }


        /// <summary>
        /// 图片2
        /// </summary>
        public string image2 { get; set; }

        /// <summary>
        /// 图片3
        /// </summary>
        public string image3 { get; set; }

        /// <summary>
        /// 是否置顶，true置顶，false不置顶
        /// </summary>
        public int isTop { get; set; }

        /// <summary>
        /// 阅读总数
        /// </summary>
        public string readCount { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        public string publishtime { get; set; }

        /// <summary>
        /// 自媒体名称
        /// </summary>
        public string weMediaName { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string content { get; set; }

        /// <summary>
        /// 原始URL地址
        /// </summary>
        public string sourceURL { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        public string summary { get; set; }

        /// <summary>
        /// 自媒体Logo
        /// </summary>
        public string logoURL { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public int sourceType { get; set; }

        /// <summary>
        /// 是否订阅
        /// </summary>
        public string isSubscribe { get; set; }
        /// <summary>
        ///是否为视频
        /// </summary>
        public int isVideo { get; set; }
    }


    public class MovieNewList
    {
        /// <summary>
        /// 新闻集合
        /// </summary>
        public List<MovieNew> movieNews { get; set; }

        /// <summary>
        /// 分享描述
        /// </summary>
        public ShareResult shareInfo { get; set; }

        public MovieNewList()
        {
            this.movieNews = new List<MovieNew>();
            this.shareInfo = new ShareResult();
        }
    }

    public class MovieNewListBySourceType
    {
        /// <summary>
        /// 新闻集合
        /// </summary>
        public List<MovieNew> movieNews { get; set; }

        /// <summary>
        /// 自媒体信息
        /// </summary>
        public NewsSourceInfo sourceInfo { get; set; }

        /// <summary>
        /// 分享描述
        /// </summary>
        public ShareResult shareInfo { get; set; }
        public MovieNewListBySourceType()
        {
            this.movieNews = new List<MovieNew>();
            this.sourceInfo = new NewsSourceInfo();
            this.shareInfo = new ShareResult();
        }
    }

    /// <summary>
    /// 查询自媒体号的新闻集合
    /// </summary>
    public class QueryNewListBySourceTypeResult : InvokeResultList
    {
        /// <summary>
        /// 新闻集合
        /// </summary>
        public MovieNewListBySourceType data { get; set; }
    }

    /// <summary>
    /// 查询新闻集合
    /// </summary>
    public class QueryTopLineMovieNewsResult : InvokeResultList
    {
        /// <summary>
        /// 新闻集合
        /// </summary>
        public MovieNewList data { get; set; }
    }

    /// <summary>
    /// 新闻
    /// </summary>
    public class QueryMovieNewsByID
    {
        /// <summary>
        /// 新闻集合
        /// </summary>
        public MovieNew newsInfo { get; set; }

        /// <summary>
        /// 顶部推荐影片集合
        /// </summary>
        public List<MovieDetail> movies { get; set; }

        /// <summary>
        /// 视频集合
        /// </summary>
        public List<Video> videos { get; set; }

        /// <summary>
        /// 随机推送到新闻列表
        /// </summary>
        public List<MovieNew> movieNews { get; set; }

        /// <summary>
        /// 分享描述
        /// </summary>
        public ShareResult shareInfo { get; set; }


        public QueryMovieNewsByID()
        {
            videos = new List<Video>();
            newsInfo = new MovieNew();
            movies = new DataList<MovieDetail>();
            videos = new List<Video>();
            movieNews = new DataList<MovieNew>();
            this.shareInfo = new ShareResult();
        }
    }


    /// <summary>
    /// 查询新闻集合
    /// </summary>
    public class QueryMovieNewsByIDResult : InvokeResult
    {
        /// <summary>
        /// 新闻集合
        /// </summary>
        public QueryMovieNewsByID data { get; set; }
    }
}
