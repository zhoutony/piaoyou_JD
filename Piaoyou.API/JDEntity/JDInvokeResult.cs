﻿//===================================================================
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
    public class JDInvokeResult
    {
        /// <summary>
        ///结果信息
        /// </summary>
        public string success { get; set; }

        /// <summary>
        /// 请求接口名称
        /// </summary>
        public string requestInfo { get; set; }

        /// <summary>
        /// 结果状态码(处理结果状态码 0:成功  非0:失败 （详细请看错误码表）)
        /// </summary>
        public int status { get; set; }
    }
}