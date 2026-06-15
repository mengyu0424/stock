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
        public static string GetXTCS(string xtmk,string csmc,string mrz="") { 
            string sql = string.Format(@"select csz from code_xtcs where xtmk='{0}' and csmc='{1}' and flag='1' ", xtmk, csmc);
            return OracleDbHelper.ExecuteScalar(sql)?.ToString() ?? "";
        }
    }
}
