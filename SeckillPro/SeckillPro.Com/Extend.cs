using System;
using System.Collections.Generic;
using System.Text;

namespace SeckillPro.Com
{
    /// <summary>
    /// 扩展方法
    /// </summary>
    public static class Extend
    {
        /// <summary>
        /// 对象转字符串，将Null转成默认字符串 def
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="def"></param>
        /// <returns></returns>
        public static string ToAllStr(this object obj,string def = "")
        {
            if (obj != null)
            {
                def = obj.ToString();
            }
            return def;
        }
        /// <summary>
        /// 字符串转成int
        /// </summary>
        /// <param name="str"></param>
        /// <param name="def"></param>
        /// <returns></returns>
        public static int Toint(this string str,int def=0)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                int.TryParse(str, out def);
            }
            return def;
        }
    }
}
