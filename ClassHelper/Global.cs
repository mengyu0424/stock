using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHelper
{
    public class Global
    {
        public static string GetXTCS(string xtmk,string csmc,string mrz="", string orgCode = "") { 
            if (string.IsNullOrEmpty(orgCode))
            {
                orgCode = GlobalInfo.userInfo.orgCode;
            }
            string sql = string.Format(@"select csz from code_xtcs where xtmk='{0}' and csmc='{1}' and orgCode='{2}' and flag='1' ", xtmk, csmc, orgCode);
            return OracleDbHelper.ExecuteScalar(sql)?.ToString() ?? "";
        }
    }
}
