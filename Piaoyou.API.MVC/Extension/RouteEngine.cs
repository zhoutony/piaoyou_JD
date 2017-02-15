//===================================================================
// 文件名:	RouteEngine.cs
// 版权:		Copyright (C) 2011 Mtime
// 创建人:	guohua.cui
// 创建日期:	2011/12/11
// 描述:		TOT路由引擎
// 备注:		
//===================================================================
using System;
using System.Collections.Generic;
using System.Text;
using Mtime.Web;
using JD.MovieAPI.Controllers;

namespace JD.MovieAPI
{
    public class RouteEngine : RouteEngineBase
    {
        public RouteEngine()
        {
            // 站点控制
            base.RegisterController<SiteController>();
        }
    }
}
