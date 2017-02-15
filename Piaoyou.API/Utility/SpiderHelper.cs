//===================================================================
// 文件名:		SpiderHelper.cs
// 版权:		Copyright (C) 2016 Entgroup
// 创建人:		tony.zhou
// 创建日期:	2016-12-13
// 描述:		抓取网页实现
// 备注:		
//===================================================================

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Text;
using HtmlAgilityPack;
using System.Web;
using System.IO.Compression;
using System.Net.Sockets;
namespace JD.MovieAPI.Utility
{
    public class SpiderHelper
    {
        #region 属性

        /// <summary>
        /// 超时时间
        /// </summary>
        private readonly int _TimeOutSeconds = 3 * 60 * 1000;

        /// <summary>
        /// request
        /// </summary>
        private HttpWebRequest _request;

        /// <summary>
        /// response
        /// </summary>
        private HttpWebResponse _response;

        /// <summary>
        /// 页面编码
        /// </summary>
        private Encoding _encoding;

        public CookieCollection Cookies { get; set; }

        #endregion

        #region 构造函数

        public SpiderHelper(string url)
            : this(url, Encoding.GetEncoding("utf-8"))
        {
        }

        public SpiderHelper(string url, string userAgent)
            : this(url, Encoding.GetEncoding("utf-8"), userAgent)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url">url地址</param>
        /// <param name="encoding">页面编码</param>
        public SpiderHelper(string url, Encoding encoding)
        {
            _request = (HttpWebRequest)WebRequest.Create(url);
            //Settings
            //string proxyIPAddress = Entgroup.Community.Components.Settings.GetConfig().GetSetting("ProxyIPAddress");
            //int port = ConvertHelper.ToInt32(Entgroup.Community.Components.Settings.GetConfig().GetSetting("ProxyIPPort"), 0);
            //WebProxy myproxy = new WebProxy(proxyIPAddress, port);
            //_request.Proxy = myproxy;

            _request.Timeout = _TimeOutSeconds;
            _encoding = encoding;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url">url地址</param>
        /// <param name="encoding">页面编码</param>
        /// <param name="proxyIPAddress">代理ip</param>
        /// <param name="port">代理端口</param>
        public SpiderHelper(string url, Encoding encoding,string proxyIPAddress,int port)
        {
            _request = (HttpWebRequest)WebRequest.Create(url);
            //Settings 设置代理
            WebProxy myproxy = new WebProxy(proxyIPAddress, port);
            _request.Proxy = myproxy;

            _request.Timeout = _TimeOutSeconds;
            _encoding = encoding;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url">url地址</param>
        /// <param name="encoding">编码</param>
        /// <param name="userAgent">userAgent</param>
        public SpiderHelper(string url, Encoding encoding, string userAgent)
        {
            _request = (HttpWebRequest)WebRequest.Create(url);
            //Settings
            //string proxyIPAddress = Entgroup.Community.Components.Settings.GetConfig().GetSetting("ProxyIPAddress");
            //int port = ConvertHelper.ToInt32(Entgroup.Community.Components.Settings.GetConfig().GetSetting("ProxyIPPort"), 0);
            //WebProxy myproxy = new WebProxy(proxyIPAddress, port);
            //_request.Proxy = myproxy;
            _request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            _request.UserAgent = userAgent;
            _request.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip, deflate, sdch");
            _request.Headers.Add(HttpRequestHeader.AcceptLanguage, "zh-CN,zh;q=0.8");
            _encoding = encoding;
            _request.Timeout = _TimeOutSeconds;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url">url地址</param>
        /// <param name="encoding">编码</param>
        /// <param name="userAgent">userAgent</param>
        public SpiderHelper(string url, Encoding encoding, string userAgent, string proxyIPAddress, int port)
        {
            _request = (HttpWebRequest)WebRequest.Create(url);
            //Settings
            WebProxy myproxy = new WebProxy(proxyIPAddress, port);
            _request.Proxy = myproxy;
            _request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            _request.UserAgent = userAgent;
            _request.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip, deflate, sdch");
            _request.Headers.Add(HttpRequestHeader.AcceptLanguage, "zh-CN,zh;q=0.8");
            _encoding = encoding;
            _request.Timeout = _TimeOutSeconds;
        }


        #endregion

        #region 对request操作

        /// <summary>
        /// 设置cookie
        /// </summary>
        /// <param name="cookie"></param>
        public void MakeCookieRequest(string cookie)
        {
            _request.Headers.Add(HttpRequestHeader.Cookie, cookie);
        }

        /// <summary>
        /// 设置UnsafeAuthenticated
        /// </summary>
        public void MakeUnsafeAuthenticatedRequest()
        {
            _request.UnsafeAuthenticatedConnectionSharing = true;
        }

        /// <summary>
        /// 设置KeepAlive
        /// </summary>
        public void MakeKeepAliveRequest()
        {
            _request.ServicePoint.Expect100Continue = false;
            _request.KeepAlive = true;
            _request.AllowAutoRedirect = true;
        }

        public void MakeAllowAutoRedirectRequest(bool auto)
        {
            _request.AllowAutoRedirect = auto;
        }

        /// <summary>
        /// 设置Refer
        /// </summary>
        /// <param name="refer"></param>
        public void MakeReferRequest(string refer)
        {
            _request.Referer = refer;
        }

        /// <summary>
        /// 更新url
        /// </summary>
        /// <param name="url"></param>
        public void ChangeUrl(string url)
        {
            _request = (HttpWebRequest)WebRequest.Create(url);
            _request.Timeout = _TimeOutSeconds;
        }

        /// <summary>
        /// 设置post数据
        /// </summary>
        /// <param name="postdata"></param>
        public void MakePostDataRequest(string postdata)
        {
            MakePostDataRequest(postdata, "application/x-www-form-urlencoded");
        }

        public void MakePostDataRequest(string postdata, string contentType)
        {
            _request.Method = "POST";
            ASCIIEncoding postencoding = new ASCIIEncoding();
            byte[] data = postencoding.GetBytes(postdata);
            if (!string.IsNullOrEmpty(contentType)) _request.ContentType = contentType;
            _request.ContentLength = data.Length;

            using (Stream newStream = _request.GetRequestStream())
            {
                // Send the data.
                newStream.Write(data, 0, data.Length);
                newStream.Close();
            }
        }

        #endregion

        #region 获得操作

        /// <summary>
        /// 获得HtmlDocument
        /// </summary>
        /// <returns></returns>
        public HtmlDocument GetHtmlDocument()
        {
            HttpWebResponse response = null;
            HtmlDocument htmlDoc = new HtmlDocument();
            try
            {
                _request.CookieContainer = new CookieContainer();
                if (this.Cookies != null)
                {
                    _request.CookieContainer.Add(this.Cookies);
                }

                response = (HttpWebResponse)_request.GetResponse();
                int count = 0;
                while ((int)response.StatusCode != 200 && count < 3)
                {
                    response = (HttpWebResponse)_request.GetResponse();
                    count++;
                }
                if ((int)response.StatusCode == 200)
                {
                    this.Cookies = response.Cookies;

                    using (Stream streamReceive = response.GetResponseStream())
                    {
                        Stream responseStream = streamReceive;
                        if (response.ContentEncoding.ToLower().Contains("gzip"))
                            responseStream = new GZipStream(streamReceive, CompressionMode.Decompress);
                        else if (response.ContentEncoding.ToLower().Contains("deflate"))
                            responseStream = new DeflateStream(streamReceive, CompressionMode.Decompress);

                        using (StreamReader sr = new StreamReader(responseStream, _encoding))
                        {
                            string html = sr.ReadToEnd();
                            htmlDoc.LoadHtml(html.Replace("&quot;", "\"").Replace("&amp;", "&"));
                            responseStream.Close();
                        }
                    }
                }
            }
            finally
            {
                if (response != null)
                    response.Close();
            }

            return htmlDoc;
        }

        /// <summary>
        /// 得到html内容字符串
        /// </summary>
        /// <returns></returns>
        public string GetHtmlString()
        {
            HttpWebResponse response = null;
            var htmlString = string.Empty;
            //htmlDoc.Encoding.EncodingName =Encoding.UTF8.EncodingName;
            try
            {
                _request.CookieContainer = new CookieContainer();
                if (this.Cookies != null)
                {
                    _request.CookieContainer.Add(this.Cookies);
                }

                response = (HttpWebResponse)_request.GetResponse();
                int count = 0;
                while ((int)response.StatusCode != 200 && count < 3)
                {
                    response = (HttpWebResponse)_request.GetResponse();
                    count++;
                }
                if ((int)response.StatusCode == 200)
                {
                    this.Cookies = response.Cookies;

                    using (Stream streamReceive = response.GetResponseStream())
                    {
                        Stream responseStream = streamReceive;
                        if (response.ContentEncoding.ToLower().Contains("gzip"))
                            responseStream = new GZipStream(streamReceive, CompressionMode.Decompress);
                        else if (response.ContentEncoding.ToLower().Contains("deflate"))
                            responseStream = new DeflateStream(streamReceive, CompressionMode.Decompress);

                        using (StreamReader sr = new StreamReader(responseStream, _encoding))
                        {
                            htmlString = sr.ReadToEnd();
                            responseStream.Close();
                        }
                    }
                }
            }
            finally
            {
                if (response != null)
                    response.Close();
            }

            return htmlString;
        }

        /// <summary>
        /// 只请求
        /// </summary>
        public void GetNothing()
        {
            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse)_request.GetResponse();
            }
            finally
            {
                if (response != null)
                    response.Close();
            }
        }

        /// <summary>
        /// 获取Cookie
        /// </summary>
        /// <returns></returns>
        public string GetCookie()
        {
            HttpWebResponse response = null;
            List<string> cookies = new List<string>();
            try
            {
                response = (HttpWebResponse)_request.GetResponse();
                string[] cookiestring = response.Headers["Set-Cookie"].Replace("; HttpOnly", "").Replace("path=/,", "|").Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string s in cookiestring)
                    cookies.Add(s.Split(new char[] { ';' })[0]);
            }
            finally
            {
                if (response != null)
                    response.Close();
            }

            return (cookies.Count == 0) ? string.Empty :
                string.Join(";", cookies.ToArray());
        }

        #endregion
    }
}
