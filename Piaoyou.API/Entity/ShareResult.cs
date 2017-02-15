//===================================================================
// 文件名:		InvokeResult.cs
// 版权:		Copyright (C) 2013 Piaoyou
// 创建人:		tony.zhou
// 创建日期:	2015-09-23  
// 描述:		结果
// 备注:		
//===================================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Mtime.Log;

namespace JD.MovieAPI.Entity
{
    /// <summary>
    ///分享结果
    /// </summary>
    public class ShareResult
    {
        /// <summary>
        /// 朋友的标题
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 朋友圈标题
        /// </summary>
        public string timelineTitle { get; set; }

        /// <summary>
        /// 分享的内容（描述）
        /// </summary>
        public string desc { get; set; }

        /// <summary>
        /// 分享图标
        /// </summary>
        public string imgUrl { get; set; }

        /// <summary>
        /// 新闻页面缓存时间
        /// </summary>
        public int cachetime { get; set; }
    }
}