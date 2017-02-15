// ===================================================================
//  文件名:		
//  版权:		Copyright (C) 2010 Piaoyou
//  创建人:		tony.zhou
//  创建日期:	2015-09-16
//  描述:		
//  备注:		
// ===================================================================

using System.IO;
using System.Text;
using Mtime.Web;
using System.Net;

namespace JD.MovieAPI.MVC
{
    /// <summary>
    /// 加载图片
    /// </summary>
	public class DownloadImageResult : ActionResult
	{
		public string Url { get; set; }

		public DownloadImageResult(string url)
		{
			this.Url = url;
		}

		public override void Execute(RequestContext context)
		{
			context.Context.Response.Clear();
			context.Context.Response.ContentType = "image/jpeg";
			context.Context.Response.AddHeader("Content-Type", "image/jpeg");

			if (!string.IsNullOrEmpty(Url))
			{
				WebClient web = new WebClient();
				context.Context.Response.BinaryWrite(web.DownloadData(Url));
			}
			context.Context.Response.End();
		}
	}
}
