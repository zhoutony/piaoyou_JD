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
    ///结果实体
    /// </summary>
    public class InvokeResult
    {
        /// <summary>
        /// 操作结果，true表示成功，false表示失败
        /// </summary>
        public bool success { get; set; }

        /// <summary>
        /// 错误代码
        /// </summary>
        public int errorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        public string errorInfo { get; set; }
    }
}