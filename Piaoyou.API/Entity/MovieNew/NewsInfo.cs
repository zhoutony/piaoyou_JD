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
    public class NewsInfo
    {
        /// <summary>
        /// 新闻ID
        /// </summary>
        public int newID { get; set; }

        /// <summary>
        /// 新闻置顶类型，NoTop--无，Top--置顶  Recommended--力荐  Hot--热门
        /// </summary>
        public string NewTopType { get; set; }

        /// <summary>
        /// 新闻类型，new--新闻，video视频，ads--广告
        /// </summary>
        public string newType { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 图片集合
        /// </summary>
        public List<string> images { get; set; }

        /// <summary>
        /// 链接地址，若链接为空，则表示是内部链接,标题不为空，则直接跳转到这个链接
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// 总数(阅读总数和)
        /// </summary>
        public string count { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        public string publishtime { get; set; }

        /// <summary>
        /// 自媒体名称
        /// </summary>
        public string publishName { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string content { get; set; }

        /// <summary>
        /// 新闻来源URL地址
        /// </summary>
        public string sourceURL { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        public string summary { get; set; }

        /// <summary>
        /// 自媒体Logo
        /// </summary>
        public string publishLogo { get; set; }

        /// <summary>
        /// 发布者ID
        /// </summary>
        public int publishID { get; set; }

        /// <summary>
        /// 是否订阅
        /// </summary>
        public bool isSubscribe { get; set; }

        /// <summary>
        /// 样式类型,big--大图模式，small--小图模式
        /// </summary>
        public string showType { get; set; }

        /// <summary>
        /// 时长，格式为hh:ss
        /// </summary>
        public string videoDuration { get; set; }

        public NewsInfo()
        {
            images = new List<string>();
        }
    }

    public class NewsInfoList
    {
        /// <summary>
        /// 新闻集合
        /// </summary>
        public List<NewsInfo> news { get; set; }

        /// <summary>
        /// 分享描述
        /// </summary>
        public ShareResult shareInfo { get; set; }

        public NewsInfoList()
        {
            this.news = new List<NewsInfo>();
            this.shareInfo = new ShareResult();
        }
    }

    public class NewInfoListBySourceType
    {
        /// <summary>
        /// 新闻集合
        /// </summary>
        public List<NewsInfo> news { get; set; }

        /// <summary>
        /// 自媒体信息
        /// </summary>
        public NewsSourceInfo sourceInfo { get; set; }

        /// <summary>
        /// 分享描述
        /// </summary>
        public ShareResult shareInfo { get; set; }
        public NewInfoListBySourceType()
        {
            this.news = new List<NewsInfo>();
            this.sourceInfo = new NewsSourceInfo();
            this.shareInfo = new ShareResult();
        }
    }

    /// <summary>
    /// 查询自媒体号的新闻集合
    /// </summary>
    public class QueryNewsInfoListBySourceTypeResult : InvokeResultList
    {
        /// <summary>
        /// 新闻集合
        /// </summary>
        public NewInfoListBySourceType data { get; set; }
    }

    /// <summary>
    /// 查询新闻集合
    /// </summary>
    public class QueryTopLineNewsInfoResult : InvokeResultList
    {
        /// <summary>
        /// 新闻集合
        /// </summary>
        public NewsInfoList data { get; set; }
    }

    /// <summary>
    /// 新闻
    /// </summary>
    public class QueryNewsInfoByID
    {
        /// <summary>
        /// 新闻集合
        /// </summary>
        public NewsInfo newsInfo { get; set; }

        /// <summary>
        /// 顶部广告
        /// </summary>
        public List<AdsInfo> topAds { get; set; }

        /// <summary>
        /// 底部广告
        /// </summary>
        public List<AdsInfo> bottomAds { get; set; }

        /// <summary>
        /// 随机推送到新闻列表
        /// </summary>
        public List<NewsInfo> news { get; set; }

        /// <summary>
        /// 分享描述
        /// </summary>
        public ShareResult shareInfo { get; set; }


        public QueryNewsInfoByID()
        {
            newsInfo = new NewsInfo();
            topAds = new List<AdsInfo>();
            bottomAds = new List<AdsInfo>();
            news = new DataList<NewsInfo>();
            this.shareInfo = new ShareResult();
        }
    }


    /// <summary>
    /// 查询新闻集合
    /// </summary>
    public class QueryNewsInfoByIDResult : InvokeResult
    {
        /// <summary>
        /// 新闻集合
        /// </summary>
        public QueryNewsInfoByID data { get; set; }
    }
}
