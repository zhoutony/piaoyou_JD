//===================================================================
// 文件名:		TicketResult 
// 版权:		Copyright (C) 2011 Piaoyou
// 创建人:		xu
// 创建日期:	2015-9-20
// 描述:		
// 备注:		
//===================================================================

using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;
using Mtime.Data;

namespace JD.MovieAPI.Entity
{
    /// <summary>
    /// 锁座结果信息
    /// </summary>
    [Serializable]
    public class TicketStatus
    {
        /// <summary>
        /// 状态
        /// </summary>
        public int externalOrderStatus { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class TicketStatusResult : InvokeResult
    {
        /// <summary>
        /// 
        /// </summary>
        public TicketStatus data { get; set; }
    }
}
