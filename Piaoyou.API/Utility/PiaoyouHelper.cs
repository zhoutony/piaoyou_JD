//===================================================================
// 文件名:		PiaoyouHelper.cs
// 版权:		Copyright (C) 2016 Entgroup
// 创建人:		tony.zhou
// 创建日期:	2016-12-13
// 描述:		票友采集公共类
// 备注:		
//===================================================================

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Text;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Configuration;
using JD.MovieAPI.Entity;
using Mtime.Log;

namespace JD.MovieAPI.Utility
{
    public static class PiaoyouHelper
    {
        /// <summary>
        /// 票友url地址
        /// </summary>
        private static string url = ConfigurationManager.AppSettings["piaoyouURL"];

        /// <summary>
        /// 票友渠道号
        /// </summary>
        private static string channelCode = ConfigurationManager.AppSettings["piaoyouChannelCode"];

        #region 获取电影院信息接口

        /// <summary>
        /// 获取电影院信息接口
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        public static QueryCinemasResultInfo GetCinemas(int pageIndex)
        {
            try
            {
                var paramdict = new Dictionary<string, object>();
                paramdict.Add("channelCode", channelCode);
                paramdict.Add("pageIndex", pageIndex);
                var cinemaurl = GetPiaoyouURL(url + "queryCinemas.aspx", paramdict);
                //请求url获取json数据
                var spider = new SpiderHelper(cinemaurl);
                var cinemaJsonStr = spider.GetHtmlString();
                if (string.IsNullOrEmpty(cinemaJsonStr))
                    return null;

                ///票友影院集合结果
                return Mtime.Helper.JsonHelper.Deserialize<QueryCinemasResultInfo>(cinemaJsonStr);
            }
            catch (Exception ex)
            {
                LogHelper.SafeWriteException(ex);
                return null;
            }
        }

        #endregion


        #region 拼接url地址

        /// <summary>
        /// 拼接url地址
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="paramdicts">参数集合</param>
        /// <returns></returns>
        private static string GetPiaoyouURL(string url, Dictionary<string, object> paramdicts)
        {
            var sign = GetSign(paramdicts);
            paramdicts.Add("sign", sign);
            var paramsb = new StringBuilder();
            paramsb.Append(url);
            var i = 0;
            foreach (var param in paramdicts)
            {
                if (i == 0)
                    paramsb.Append("?" + param.Key + "=" + param.Value);
                else
                    paramsb.Append("&" + param.Key + "=" + param.Value);

                i++;
            }

            return paramsb.ToString();
        }

        #endregion

        #region 得到签名

        /// <summary>
        /// 得到签名
        /// </summary>
        /// <returns></returns>
        private static string GetSign(Dictionary<string, object> paramdicts)
        {
            List<string> paramKeys = new List<string>();
            foreach (var paramkey in paramdicts)
            {
                if (!paramKeys.Contains(paramkey.Key))
                    paramKeys.Add(paramkey.Key);
            }
            //参数排序，规则按照A-Z
            paramKeys.Sort();

            var paramsb = new StringBuilder();
            for (var i = 0; i < paramKeys.Count; i++)
            {
                if (i == 0)
                    paramsb.Append(paramKeys[i] + "=" + paramdicts[paramKeys[i]]);
                else
                    paramsb.Append("&" + paramKeys[i] + "=" + paramdicts[paramKeys[i]]);
            }

            return MD5Encrypt(paramsb.ToString(), 0).ToLower();
        }

        #endregion

        #region md5加密

        /// <summary>
        /// md5加密
        /// </summary>
        /// <param name="input">需要加密字符串</param>
        /// <param name="length">md5长度</param>
        /// <returns></returns>
        public static string MD5Encrypt(string input, int length)
        {
            byte[] buffer = Encoding.Default.GetBytes(input);
            byte[] hashValue = MD5.Create().ComputeHash(buffer);

            string result;
            switch (length)
            {
                case 16:
                    result = BitConverter.ToString(hashValue, 4, 8).Replace("-", "");
                    break;
                case 32:
                    result = BitConverter.ToString(hashValue, 0, 16).Replace("-", "");
                    break;
                default:
                    result = BitConverter.ToString(hashValue).Replace("-", "");
                    break;
            }

            return result;
        }

        #endregion
    }
}
