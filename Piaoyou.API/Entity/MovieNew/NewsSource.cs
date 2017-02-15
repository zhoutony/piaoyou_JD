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
    /// 自媒体信息
    /// </summary>
    [Serializable]
    public class NewsSourceInfo
    {
        /// <summary>
        /// 自媒体ID
        /// </summary>
        public int sourceID { get; set; }

        /// <summary>
        /// 自媒体名称
        /// </summary>
        public string sourceName { get; set; }

        /// <summary>
        /// 自媒体logo
        /// </summary>
        public string logoURL { get; set; }

        /// <summary>
        /// 自媒体简介
        /// </summary>
        public string summary { get; set; }

        /// <summary>
        /// 自媒背景图
        /// </summary>
        public string backImageURL { get; set; }

        /// <summary>
        /// 订阅数量
        /// </summary>
        public int subscribeCount { get; set; }

        /// <summary>
        /// 自媒体所有文章的阅读数总和
        /// </summary>
        public string AllReadCount { get; set; }

        /// <summary>
        /// 是否订阅
        /// </summary>
        public string isSubscribe { get; set; }

    }

    public class QueryNewsSourceList
    {
        public List<NewsSourceInfo> newsSourceInfos { get; set; }
        public List<NewsSourceInfo> topNewsSourceInfos { get; set; }
        public QueryNewsSourceList()
        {
            this.newsSourceInfos = new List<NewsSourceInfo>();
            this.topNewsSourceInfos = new List<NewsSourceInfo>();
        }
    }

    /// <summary>
    /// 自媒体列表
    /// </summary>
    public class QueryNewsSourceListResult : InvokeResult
    {
        public QueryNewsSourceList data { get; set; }

        public QueryNewsSourceListResult()
        {
            data = new QueryNewsSourceList();
        }
    }

    /// <summary>
    /// 订阅自媒体
    /// </summary>
    public class SubscriberWeMediaResult : InvokeResult
    {

    }

    /// <summary>
    /// 取消订阅自媒体
    /// </summary>
    public class UnSubscriberWeMediaResult : InvokeResult
    {

    }

    /// <summary>
    /// 是否订阅自媒体
    /// </summary>
    public class IsSubscriberWeMediaResult : InvokeResult
    {

    }
}
