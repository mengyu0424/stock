using ClassHelper;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Xml;
using TinyPinyin;

namespace WindowsFormsApp.Other
{
    public class PublicFun
    {
        /// <summary>
        /// string加密MD5
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ToMD5(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // 转成32位大写字符串
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
        #region 获取拼音码首字母
        public static string GetPinyin(string input)
        {
            if (input.Trim().Length>0)
            {
                return PinyinHelper.GetPinyinInitials(input.Trim()).ToUpper();
            }
            else
            {
                return "";
            }
            
        }

        public static int GetSeqBySeqName(string seqName) {
            try
            {
                return int.Parse(OracleDbHelper.ExecuteScalar(string.Format("select {0}.nextval from dual", seqName)).ToString());
            }
            catch (System.Exception)
            {
                return -1;
            }
        }
        /// <summary>
        /// 获取字典数据列表
        /// </summary>
        /// <param name="typeCode">字典代码</param>
        /// <param name="isAddAllSel">是否加"ALL"数据，不传则不加</param>
        /// <param name="defAllText">"ALL"数据的名称，不传则为"全部"</param>
        /// <returns></returns>
        public static DataTable GetDictDataList(string typeCode,bool isAddAllSel=false,string defAllText="全部") {
            string sql = @"select n.code, n.name,n.bz
                           from code_dict_main m
                           inner join code_dict_next n on m.code = n.maincode
                           where m.code = :maincode
                             and nvl(m.flag, '1') = '1'
                           order by n.code";

            DataTable dt = OracleDbHelper.ExecuteQuery(
                sql,
                new OracleParameter(":maincode", typeCode));
            if (isAddAllSel)
            {
                DataRow row = dt.NewRow();
                row["CODE"] = "ALL";
                row["NAME"] = defAllText;
                row["BZ"] = defAllText;
                dt.Rows.InsertAt(row, 0);
            }
            return dt;
        }
        #endregion
    }
}