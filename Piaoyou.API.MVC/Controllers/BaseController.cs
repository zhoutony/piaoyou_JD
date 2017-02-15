//===================================================================
// 文件名:	BaseController.cs
// 版权:		Copyright (C) 2015 Piaoyou
// 创建人:	  tony.zhou
// 创建日期:	2015/09/15
// 描述:		
// 备注:		
//===================================================================
using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using Mtime.Web;
using Mtime.Helper;
using JD.MovieAPI.Facade;
using System.Drawing.Imaging;
using JD.MovieAPI.Entity;
using Mtime.Log;

namespace JD.MovieAPI.Controllers
{
    public class BaseController : Controller
    {
        public string wxchannelCode
        {
            get
            {
                if (string.IsNullOrEmpty(_wxchannelCode))
                {
                    _wxchannelCode = ConvertHelper.ToString(Context.GetParam("wxchannelCode"), string.Empty);
                    if (string.IsNullOrEmpty(_wxchannelCode))
                        LogHelper.SafeWriteMessage("wxchannelCode", "wxchannelCode={0};url={1}", _wxchannelCode, Context.Context.Request.Url);
                }
                return _wxchannelCode;
            }
        }

        private string _wxchannelCode;
    }
}
