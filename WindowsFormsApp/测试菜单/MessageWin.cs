using ClassHelper;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp.测试菜单
{
    public partial class MessageWin : Form
    {
        public MessageWin()
        {
            InitializeComponent();
        }

        private int flag = 0;
        // 用后台线程安全延时，不卡界面、不跨线程崩溃
        private void myButton1_Click(object sender, EventArgs e)
        {
            flag = 1;
            myButton1.Enabled = false;
            myButton2.Enabled = true;
            flagPanel.BackColor = Color.Green;
            var sql = txtSql.Text;
            var sqlList = sql.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < sqlList.Length; i++)
            {
                StartThread(sqlList[i],int.Parse(timeNumber.Text));
            }
        }

        private void myButton2_Click(object sender, EventArgs e)
        {
            flag = 0;
            txtnum.Text = "-";
            myButton1.Enabled = true;
            myButton2.Enabled = false;
            flagPanel.BackColor = Color.LightGray;
        }

        private void StartThread(string sql, int delayMs)
        {
            Thread thread = new Thread(() =>
            {
                // 死循环执行（后台）
                while (flag==1)
                {
                    this.Invoke(new Action(() =>
                    {
                        txtnum.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                    }));
                    // ✅ 必须用 Invoke 才能安全修改界面
                    this.Invoke(new Action(() =>
                    {
                        int result =int.Parse( OracleDbHelper.ExecuteScalar(sql).ToString());
                        if (result>0)
                        {
                            flagPanel.BackColor = Color.Red;
                        }
                    }));

                    // 延时
                    Thread.Sleep(delayMs);
                }
            })
            {
                IsBackground = true, // 后台线程（关闭窗口自动退出）
            };

            thread.Start();
        }
    }
}