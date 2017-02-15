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

namespace JD.MovieAPI.Entity
{
    /// <summary>
    /// 地区信息
    /// </summary>
    [Serializable]
    public class Location
    {
        /// <summary>
        /// 地区ID
        /// </summary>
        public int locationID { get; set; }

        /// <summary>
        /// 地区类型
        /// </summary>
        public int locationType { get; set; }

        /// <summary>
        /// 父ID
        /// </summary>
        public int parentID { get; set; }

        /// <summary>
        /// 中文名
        /// </summary>
        public string nameCN { get; set; }

        /// <summary>
        /// 英文名
        /// </summary>
        public string nameEN { get; set; }

        /// <summary>
        /// 拼音
        /// </summary>
        public string namePinyin { get; set; }

        /// <summary>
        /// 短拼音
        /// </summary>
        public string namePinyinShort { get; set; }

        /// <summary>
        /// 名称代码
        /// </summary>
        public string nameCode { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        public decimal latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        public decimal longitude { get; set; }

        /// <summary>
        /// 热门城市，true表示热门，false表示不热门
        /// </summary>
        public bool isHot { get; set; }
    }

    public class LocationList
    {
        /// <summary>
        /// 地区集合
        /// </summary>
        public List<Location> locations { get; set; }

        public LocationList()
        {
            this.locations = new List<Location>();
        }
    }

    public class LocationInfo
    {
        /// <summary>
        /// 地区
        /// </summary>
        public Location location { get; set; }

        public LocationInfo()
        {
         
        }
    }


    /// <summary>
    /// 查询地区集合
    /// </summary>
    public class QueryLocationsResult : InvokeResult
    {
        /// <summary>
        /// 地区集合
        /// </summary>
        public LocationList data { get; set; }
    }


    /// <summary>
    /// 查询地区集合
    /// </summary>
    public class QueryLocationByLatitudeLongitudeResult : InvokeResult
    {
        /// <summary>
        /// 地区集合
        /// </summary>
        public LocationInfo data { get; set; }
    }

}
