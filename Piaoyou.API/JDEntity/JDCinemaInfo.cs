//===================================================================
// 文件名:		LocationInfo 
// 版权:		Copyright (C) 2011 Piaoyou
// 创建人:		xu
// 创建日期:	2015-9-20
// 描述:		
// 备注:		
//===================================================================

using System;
using System.Collections.Generic;
using System.Text;
using Mtime.Data;
using System.Xml.Serialization;

namespace JD.MovieAPI.Entity
{
    /// <summary>
    /// 京东影院信息
    /// </summary>
    [Serializable]
    [XmlRootAttribute("cinemaDetail")]
    public class JDCinemaInfo
    {
        /// <summary>
        /// 影院名称
        /// </summary>
        public string cinemaName { get; set; }

        /// <summary>
        /// 供应商影院id
        /// </summary>
        public int agentCinemaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string regionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int regionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string contactPhone { get; set; }

        /// <summary>
        /// 影院类型 1: 电子券影院,2: 在线选座影院 3.都支持
        /// </summary>
        public int cinemaType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int cityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string cityName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string cinemaDesc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string cinemaNotice { get; set; }

        /// <summary>
        /// 影院地址
        /// </summary>
        public string address { get; set; }
    }

    /// <summary>
    /// 得到影院信息返回结果
    /// </summary>
    public class JDGetCinemaInfoInvokeResult : JDInvokeResult
    {
        /// <summary>
        /// 本次返回的电影院数量(本次返回的电影院数量cinemaCount <= count)
        /// </summary>
        public int cinemaCount { get; set; }

        /// <summary>
        /// 影院列表
        /// </summary>
        public List<JDCinemaInfo> cinemaList { get; set; }

        public JDGetCinemaInfoInvokeResult()
        {
            this.cinemaList = new List<JDCinemaInfo>();
        }
    }

}
