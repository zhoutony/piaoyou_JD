//===================================================================
// 文件名:	SiteController.cs
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
using TicketFriend.Community.Constants;
using System.Xml.Serialization;
using System.Xml;
using JD.MovieAPI.Utility;

namespace JD.MovieAPI.Controllers
{
    [Controller("/")]
    public class SiteController : BaseController
    {
        public XmlResult getCinemaInfo()
        {
            var bid = Context.GetParam("bid");
            var timestamp = Context.GetParam("timestamp");
            var requestDate = Context.GetParam("requestDate");
            var startpos = ConvertHelper.ToInt32(Context.GetParam("startpos"), 0);
            var count = ConvertHelper.ToInt32(Context.GetParam("count"), 100);
            var sign = Context.GetParam("sign");
            var jdCinemas = JDFacade.getCinemaInfo(bid, timestamp, requestDate, startpos, count, sign);
            string xml = XmlUtil.Serializer(typeof(JDGetCinemaInfoInvokeResult), jdCinemas);

            return new XmlResult(xml);
        }
    }
}
