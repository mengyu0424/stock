using ClassHelper;
using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp.主窗体;

namespace WindowsFormsApp.测试工具
{
    public partial class MessageWin : BasePopupForm
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
                StartThread(sqlList[i], (int.Parse(timeNumber.Text) * 1000));
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
                while (flag == 1)
                {
                    this.Invoke(new Action(() =>
                    {
                        txtnum.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                    }));
                    // ✅ 必须用 Invoke 才能安全修改界面
                    this.Invoke(new Action(() =>
                    {
                        try
                        {
                            int result = int.Parse(OracleDbHelper.ExecuteScalar(sql).ToString());
                            if (result > 0)
                            {
                                flagPanel.BackColor = Color.Red;
                                ShowToTop(this);
                            }
                        }
                        catch (Exception)
                        {
                            flagPanel.BackColor = Color.Black;
                            ShowToTop(this);
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

        #region 窗体置顶

        // 调用 Windows API 实现窗体置顶
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_RESTORE = 9;

        public static void ShowToTop(Form form)
        {
            if (form == null || form.IsDisposed) return;

            // 如果窗体被最小化，先恢复
            if (form.WindowState == FormWindowState.Minimized)
            {
                ShowWindow(form.Handle, SW_RESTORE);
            }

            // 强制激活并置顶窗体
            form.Activate();
            form.TopMost = true;  // 临时置顶
            form.TopMost = false; // 取消永久置顶（只显示一次在最前）
            SetForegroundWindow(form.Handle);
        }

        #endregion 窗体置顶

        private void myButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}