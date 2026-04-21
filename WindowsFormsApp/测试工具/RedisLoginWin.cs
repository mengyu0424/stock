using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.主窗体;
using ServiceStack.Redis;

namespace WindowsFormsApp.测试工具
{
    public partial class RedisLoginWin : BasePopupForm
    {
        private static RedisClient redis = null;
        public RedisLoginWin()
        {
            InitializeComponent();
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            var code = txtCode.Text.ToString();
            var ip = txtIP.Text.ToString();
            int time= int.Parse(txt_time.Text.ToString());
            RedisLogin(code,ip, time);
            Query();
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count == 0)
                return;

            // 获取第一行选中行
            DataGridViewRow row = dgvList.SelectedRows[0];
            txtCode.Text = row.Cells["CODE"].Value.ToString();
            txtIP.Text = row.Cells["IP"].Value.ToString();
        }

        private void myButton2_Click(object sender, EventArgs e)
        {
            var code = txtCode.Text.ToString();
            var ip = txtIP.Text.ToString();
            int time = int.Parse(txt_time.Text.ToString());
            KeepLogin(code, ip, time);
            Query();
        }




        private void RedisLogin(string code,string ip,int time) {
            var redisInfo = redis.GetKeysByPattern("UserCode:" + code).ToDictionary(k => k.Replace("UserCode:", ""), k => redis.Get<string>(k));
            if (redisInfo.Count ==1)//如果有一条数据 判断IP是否相同 P：相同-续时长/不同-提示在别处登录
            {
                var firstItem = redisInfo.First();
                string firstValue = firstItem.Value;
                if (firstValue == ip)
                {
                    redis.Set("UserCode:" + code, ip, TimeSpan.FromMinutes(time));
                    MessageBox.Show("IP相同，续时长成功！");
                }
                else
                {
                    MessageBox.Show("IP不同，在别处登录了！");
                }
            }
            else if (redisInfo.Count == 0)//如果没有数据
            {
                redis.Set("UserCode:" + code, ip, TimeSpan.FromMinutes(time));
                MessageBox.Show("没有数据，登录成功！");
            } 
            else//多条数据 提示数据错误
            {
                MessageBox.Show("数据不正确！");
            }
        }

        private void Query() {
            dgvList.DataSource = null;
            var dict = redis.GetKeysByPattern("UserCode:*").ToDictionary(k => k.Replace("UserCode:", ""), k => redis.Get<string>(k));


            DataTable dt = new DataTable("RedisLog");
            dt.Columns.Add("CODE", typeof(string));  // 字段名（如 IP、Account）
            dt.Columns.Add("IP", typeof(string));  // 值
            dt.BeginLoadData();
            foreach (var kv in dict)
            {
                DataRow row = dt.NewRow();
                row["CODE"] = kv.Key;
                row["IP"] = kv.Value;
                dt.Rows.Add(row);
            }
            dt.EndLoadData();
            dgvList.DataSource = dt;
        }

        private void KeepLogin(string code,string ip,int time) {
            var redisInfo = redis.GetKeysByPattern("UserCode:" + code).ToDictionary(k => k.Replace("UserCode:", ""), k => redis.Get<string>(k));
            if (redisInfo.Count == 1)//如果有一条数据 判断IP是否相同 P：相同-续时长/不同-提示在别处登录
            {
                var firstItem = redisInfo.First();
                string firstValue = firstItem.Value;
                if (firstValue == ip)
                {
                    redis.Set("UserCode:" + code, ip, TimeSpan.FromMinutes(time));
                    MessageBox.Show("IP相同，续时长成功！");
                }
                else
                {
                    MessageBox.Show("IP不同，不再续时长了！并且会为你关闭程序！");
                }
            }
            else if (redisInfo.Count == 0)//如果没有数据
            {
                MessageBox.Show("没有数据，不能续时长！并且会关闭程序！");
            }
            else//多条数据 提示数据错误
            {
                MessageBox.Show("数据不正确！关闭程序！");
            }
        }

        private void myButton3_Click(object sender, EventArgs e)
        {
            var url = txt_url.Text.ToString().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            redis = new RedisClient(url[0], int.Parse(url[1]), url[2]);
            if (redis!=null)
            {
                myButton1.Enabled = true;
                myButton2.Enabled = true;
                btn_query.Enabled = true;
            }
            else
            {
                myButton1.Enabled = false;
                myButton2.Enabled = false;
                btn_query.Enabled = false;
            }
        }
    }
}
