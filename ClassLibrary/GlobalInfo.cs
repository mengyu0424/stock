using System.Collections.Generic;

namespace ClassLibrary
{
    /// <summary>
    /// 全局信息类 用于存储不变信息
    /// </summary>
    public static class GlobalInfo
    {
        public static UserInfo userInfo { get; set; }
        public static List<OrgData> orgData { get; set; }

        static GlobalInfo()
        {
            // 初始化当前用户对象
            userInfo = new UserInfo();
            orgData = new List<OrgData>();
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

        /// <summary>
        /// 机构代码
        /// </summary>
        public string orgCode { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public string orgName { get; set; }
    }

    public class OrgData
    {
        /// <summary>
        /// 机构代码
        /// </summary>
        public string CODE { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 拼音码
        /// </summary>
        public string PYM { get; set; }

        /// <summary>
        /// 启用标志
        /// </summary>
        public string FLAG { get; set; }
    }
}