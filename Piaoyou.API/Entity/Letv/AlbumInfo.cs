//===================================================================
// 文件名:		Album 
// 版权:		Copyright (C) 2011 Piaoyou
// 创建人:		xu
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
    public class AlbumList : InvokeResult
    {
        public AlbumList()
        {
            Albums = new List<AlbumInfo>();
        }
        public List<AlbumInfo> Albums { get; set; }
    }


}
