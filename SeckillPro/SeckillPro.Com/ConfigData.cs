using System;
using System.Collections.Generic;
using System.Text;

namespace SeckillPro.Com
{
    /// <summary>
    /// 配置数据
    /// </summary>
    public class ConfigData
    {
        /// <summary>
        /// api接口地址
        /// </summary>
        public static  string ApiUrl { get; set; }
        /// <summary>
        /// redis连接字符串
        /// </summary>
        public static string RedisConnectionString { get; set; }
        /// <summary>
        /// redis数据库
        /// </summary>
        public static int ResisDb { get; set; }


    }
}
