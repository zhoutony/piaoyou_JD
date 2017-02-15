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
    public class RedEnvelopes
    {
        /// <summary>
        /// 红包ID
        /// </summary>
        public string redEnvelopeID { get; set; }

        /// <summary>
        /// 红包金额
        /// </summary>
        public int money { get; set; }

        /// <summary>
        /// 最低消费金额
        /// </summary>
        public int lowest { get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        public string endTime { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///备注
        /// </summary>
        public string remarks { get; set; }

    }

    /// <summary>
    /// 红包本身属性
    /// </summary>
    public class RedEnvelope
    {
        /// <summary>
        /// 影片名称
        /// </summary>
        public string movieName { get; set; }

        /// <summary>
        /// 红包金额
        /// </summary>
        public int money { get; set; }

        /// <summary>
        /// 最低消费金额
        /// </summary>
        public int lowest { get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        public string endTime { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///备注
        /// </summary>
        public string remarks { get; set; }
        /// <summary>
        /// 影院
        /// </summary>
        public string cinemaName { get; set; }

        /// <summary>
        ///版本
        /// </summary>
        public string Versions { get; set; }
        /// <summary>
        ///规则
        /// </summary>
        public string rule { get; set; }
    }
    /// <summary>
    /// 红包信息
    /// </summary>

  
    public class RedEnvelopesInfoResult : InvokeResult
    {
        public RedEnvelope data { get; set; }
    }
    /// <summary>
    /// 红包集合
    /// </summary>
    public class RedEnvelopesList
    {

        public List<RedEnvelopes> redEnvelopes { get; set; }

        public RedEnvelopesList()
        {
            this.redEnvelopes = new List<RedEnvelopes>();
        }
    }

    /// <summary>
    //根据用户ID查询红包结果
    /// </summary>
    public class RedEnvelopesResult : InvokeResultList
    {
        /// <summary>
        /// 查询红包结果
        /// </summary>
        public RedEnvelopesList data { get; set; }
    }
}
