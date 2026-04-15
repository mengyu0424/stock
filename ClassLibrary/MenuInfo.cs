namespace ClassLibrary
{
    public class MenuInfo
    {
        /// <summary>
        /// 菜单唯一ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 父级菜单ID
        /// </summary>
        public int FatherID { get; set; }

        /// <summary>
        /// 分类名称（也是父级菜单名称）
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 菜单地址
        /// </summary>
        public string Url { get; set; }
    }
}