//===================================================================
// 文件名:		CinemaFacade.cs
// 版权:		Copyright (C) 2010 Piaoyou
// 创建人:		xu
// 创建日期:	2016/4/26
// 描述:		专辑信息
// 备注:		
//===================================================================
using System;
using System.Collections.Generic;
using System.Text;
using Mtime.Helper;
using Mtime.Collections;
using System.Linq;
using System.Runtime.CompilerServices;
using TicketFriend.Community.Entity;
using Mtime.Cache;
using System.Configuration;
using JD.MovieAPI.Entity;
using JD.MovieAPI.Utility;

namespace JD.MovieAPI.Facade
{
    public static class JDFacade
    {
        /// <summary>
        /// key值为京东电影票平台与供应商约定的数据
        /// </summary>
        static  string KEY = ConfigurationManager.AppSettings["JDAndPiaoyouKey"];

        #region 返回给京东影院信息

        public static JDGetCinemaInfoInvokeResult getCinemaInfo(string bid, string timestamp, string requestDate,
            int startpos, int count, string sign)
        {
            var result = new JDGetCinemaInfoInvokeResult();

            var signStr = string.Format("bid={0}&timestamp={1}&requestDate={2}&startpos={3}&count={4}&key={5}",
                                         bid, timestamp, requestDate, startpos, count, KEY);
            var signPiaoyou = EncryptHelper.MD5Encrypt(signStr);
            //签名正确
            //if (sign == signPiaoyou)
            //{
            //}
            //else//签名错误
            //{

            //}

            var piaoyouCinemaResult = PiaoyouHelper.GetCinemas(startpos + 1);
            result.cinemaCount = piaoyouCinemaResult.cinemas.Count;
            piaoyouCinemaResult.cinemas.ForEach(cinema =>
            {
                var jdCinema = new JDCinemaInfo();
                jdCinema.address = cinema.cinemaAddress;
                jdCinema.agentCinemaId = cinema.cinemaID;

                result.cinemaList.Add(jdCinema);
            });

            return result;
        }

        #endregion
    }
}
