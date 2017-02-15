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
using System.Security.Policy;
using System.Text;
using Mtime.Data;

namespace JD.MovieAPI.Entity
{
    /// <summary>
    ///根据用户ID查询红包的属性
    /// </summary>
    [Serializable]
    public class PiaoyouCardList : InvokeResultList
    {
        public List<PiaoyouCard> piaoyouCards { get; set; }

        public PiaoyouCardList()
        {
            piaoyouCards = new List<PiaoyouCard>();
        }
    }

    /// <summary>
    /// 红包本身属性
    /// </summary>
    public class PiaoyouCard
    {
        public string piaoyouCardID { get; set; }
        public int denomination { get; set; }
        public int remainder { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public string status { get; set; }

    }

}
