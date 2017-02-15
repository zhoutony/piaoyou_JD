using System;
using System.Collections.Generic;
using System.Text;

namespace JD.MovieAPI.Constants
{
    public enum StatusJD
    {
        /// <summary>
        /// 成功
        /// </summary>
        Success = 0,

        /// <summary>
        /// 请求 Ip 非法
        /// </summary>
        IPUnlawful = 100,

        /// <summary>
        /// 第三方ID错误
        /// </summary>
        ThirdPartyIDError  = 102,

        /// <summary>
        /// sign 校验失败
        /// </summary>
        SignError = 103,

        /// <summary>
        /// 重复同步订单
        /// </summary>
        RepeatSynchroOrder = 106,

        /// <summary>
        /// 重复同步订单
        /// </summary>
        OrderNonExistent = 107,

    }
}
