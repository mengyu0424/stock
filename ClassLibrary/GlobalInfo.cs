using System.Collections.Generic;

namespace ClassLibrary
{
    /// <summary>
    /// 全局信息类 用于存储不变信息
    /// </summary>
    public static class GlobalInfo
    {
        public static UserInfo userInfo { get; set; }

        static GlobalInfo()
        {
            // 初始化当前用户对象
            userInfo = new UserInfo();
        }
    }

    /// <summary>
    /// 操作员信息类
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// 操作员账号
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 操作员姓名
        /// </summary>
        public string Name { get; set; }

    }

}