using HelloWorlds.Infrastructure.Utitily;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorlds.MyWorld.Infrastructures
{
    public static class SessionHelper
    {
        /// <summary>
        /// 添加Session，调动有效期为20分钟
        /// </summary>
        /// <param name="strSessionName">Session对象名称</param>
        /// <param name="v">Session值</param>
        public static void Add<T>(string strSessionName, T v)
        {
            Add<T>(strSessionName, v, 20);
        }

        /// <summary>
        /// 添加Session
        /// </summary>
        /// <param name="strSessionName">Session对象名称</param>
        /// <param name="v">Session值</param>
        /// <param name="iExpires">调动有效期（分钟）</param>
        public static void Add<T>(string strSessionName, T v, int iExpires)
        {
            string jsonTarget = SerializeHelper.JSONSerialize(v);
            HttpContext.Current.Session[strSessionName] = jsonTarget;
            HttpContext.Current.Session.Timeout = iExpires;
        }

        /// <summary>
        /// 读取某个Session对象值
        /// </summary>
        /// <param name="strSessionName">Session对象名称</param>
        /// <returns>Session对象值</returns>
        public static T Get<T>(string strSessionName)
        {
            if (!CheckSession(strSessionName))
            {
                return default(T);
            }
            else
            {
                string v = HttpContext.Current.Session[strSessionName] as string;
                T obj = SerializeHelper.JSONDeserialize<T>(v);
                return obj;
            }
        }

        /// <summary>
        /// 删除某个Session对象
        /// </summary>
        /// <param name="strSessionName">Session对象名称</param>
        public static void Del(string strSessionName)
        {
            HttpContext.Current.Session[strSessionName] = null;
        }

        /// <summary>
        /// 验证是否存在该session
        /// </summary>
        /// <param name="sessionKey">Session对象名称</param>
        /// <returns>是否存在该session</returns>
        public static bool CheckSession(string sessionKey)
        {
            return HttpContext.Current.Session[sessionKey] != null;
        }

    }
}