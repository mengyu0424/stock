using ClassHelper;
using ClassLibrary;
using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp.Other;

namespace WindowsFormsApp.登录
{
    public partial class 登录页面 : Form
    {
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        private static extern bool EnableWindow(IntPtr hWnd, bool enable);

        private static RedisClient redisData = null;

        private bool _isRunning = true;

        private const int SW_RESTORE = 9;


        private string csbz = ConfigurationManager.AppSettings["csbz"];

        public 登录页面()
        {
            InitializeComponent();
            // 屏幕居中
            this.StartPosition = FormStartPosition.CenterScreen;
            //页面方法加载
            this.Init();
            // 绑定回车事件
            this.KeyPreview = true;
            this.KeyDown += 登录页面_KeyDown;
        }

        private void Init()
        {
        }

        /// <summary>
        /// 回车登录优化：自动判断光标位置
        /// </summary>
        private void 登录页面_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoLogin();
            }
        }

        /// <summary>
        /// 登录逻辑
        /// </summary>
        private void DoLogin()
        {
            string user = txtUsername.Text.Trim();
            string pwd = txtPassword.Text.Trim();

            // 优化判断
            if (string.IsNullOrWhiteSpace(user))
            {
                txtUsername.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(pwd))
            {
                txtPassword.Focus();
                return;
            }

            if (csbz == "1")
            {
                /*测试使用 账号0  密码1*/
                if (user == "0" && pwd == "1")
                {
                    //登陆成功 全局变量赋值
                    GlobalInfo.userInfo.ID = "0000";
                    GlobalInfo.userInfo.Name = "梦屿库存管理员";
                    //打开菜单页面 关闭登陆页面
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("账号密码错误!");
                }
            }
            else
            {
                string sql = string.Format(" select t.code,t.name,t.pass,t.flag from code_czydm t where t.code='{0}' ", user);
                DataTable dt = OracleDbHelper.ExecuteQuery(sql);
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("未查询到账号【" + user + "】，请确认后重新尝试！");
                    txtUsername.Clear();
                    txtUsername.Focus();
                    txtPassword.Clear();
                    return;
                }
                DataRow dr = dt.Rows[0];
                if (dr["FLAG"]?.ToString() != "1")
                {
                    MessageBox.Show("账号【" + user + "】已被禁用！");
                    txtUsername.Clear();
                    txtUsername.Focus();
                    txtPassword.Clear();
                    return;
                }
                string md5Pwd = PublicFun.ToMD5(pwd);
                if (dr["PASS"]?.ToString().ToLower() != md5Pwd.ToLower())
                {
                    MessageBox.Show("密码错误，请重新输入！");
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }
                //登陆成功 全局变量赋值
                GlobalInfo.userInfo.ID = dr["CODE"].ToString();
                GlobalInfo.userInfo.Name = dr["NAME"].ToString();
                #region 账号限制IP登录 
                try
                {
                    string OpenIpRestriction = Global.GetXTCS("00", "IpRestriction");
                    var csList = OpenIpRestriction.Split(new char[] { '*' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    //节点不全时 不会监控 0不监控 1监控
                    if (csList.Count == 4 && csList[0].ToString() == "1")
                    {
                        var ip = GetLocalIpv4Addresses().FirstOrDefault() ?? "127.0.0.1";
                        redisData = new RedisClient(csList[1], int.Parse(csList[2]), csList[3]);

                        var redisInfo = redisData.GetKeysByPattern("UserCode:" + user).ToDictionary(k => k.Replace("UserCode:", ""), k => redisData.Get<string>(k));

                        if (redisInfo.Count == 1)//如果有一条数据 判断IP是否相同 P：相同-续时长/不同-提示在别处登录
                        {
                            var firstItem = redisInfo.First();
                            string firstValue = firstItem.Value;
                            if (firstValue == ip)
                            {
                                redisData.Set("UserCode:" + user, ip, TimeSpan.FromMinutes(1));
                            }
                            else
                            {
                                MessageBox.Show("账号已在别处登录！请退出后再重新登录。", "提醒");
                                return;
                            }
                        }
                        else if (redisInfo.Count == 0)//如果没有数据
                        {
                            redisData.Set("UserCode:" + user, ip, TimeSpan.FromMinutes(1));
                        }
                        else//多条数据 提示数据错误
                        {
                            MessageBox.Show("当前帐号的登录数据验证存在问题，请联系工程师！", "提醒");
                            return;
                        }

                        //对登录信息进行续时长，直到用户退出登录  每次续航1分钟
                        Thread _workThread = new Thread(() => KeepLogin(user, ip, 1));
                        _workThread.IsBackground = true;
                        _workThread.Start();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                #endregion
                
                //打开菜单页面 关闭登陆页面
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DoLogin();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// 异步保持账号登录状态 方法
        /// </summary>
        /// <param name="code"></param>
        /// <param name="ip"></param>
        /// <param name="time"></param>
        private void KeepLogin(string code, string ip, int time)
        {
            while (_isRunning)
            {
                try
                {
                    string OpenIpRestriction = Global.GetXTCS("00", "IpRestriction");
                    var RedisParamter = OpenIpRestriction.Split(new char[] { '*' }, StringSplitOptions.RemoveEmptyEntries).ToList(); //这里需要配置参数，是否开启IP限制，默认不开启
                    var OpenIPCheck = RedisParamter[0].ToString();
                    if (RedisParamter.Count() != 4 || OpenIPCheck != "1")
                    {
                        _isRunning = false;
                    }
                    else
                    {
                        if (redisData == null)
                        {
                            redisData = new RedisClient(RedisParamter[1], int.Parse(RedisParamter[2]), RedisParamter[3]);
                        }
                        var redisInfo = redisData.GetKeysByPattern("UserCode:"+ code).ToDictionary(k => k.Replace("UserCode:", ""), k => redisData.Get<string>(k));

                        if (redisInfo.Count == 1)//如果有一条数据 判断IP是否相同 P：相同-续时长/不同-提示在别处登录
                        {
                            var firstItem = redisInfo.First();
                            string firstValue = firstItem.Value;
                            if (firstValue == ip)
                            {
                                redisData.Set("UserCode:" + code, ip, TimeSpan.FromMinutes(time));
                            }
                            else
                            {
                                BringProcessToTop(Process.GetCurrentProcess());
                                ShowTransparentMask("账号已在别处登录！请重新登录。");
                                //IP不同 此处要写关闭程序
                                Process.GetCurrentProcess().Kill();
                            }
                        }
                        else if (redisInfo.Count == 0)//如果没有数据
                        {
                            BringProcessToTop(Process.GetCurrentProcess());
                            ShowTransparentMask("账号登陆超时，请重新登录！");
                            //没有续上程序 要关闭程序
                            Process.GetCurrentProcess().Kill();
                        }
                        else//多条数据 提示数据错误
                        {
                            BringProcessToTop(Process.GetCurrentProcess());
                            ShowTransparentMask("账号登录数据错误，请重新登录。");
                            //数据不正确 要关闭程序
                            Process.GetCurrentProcess().Kill();
                        }

                    }
                }
                catch (Exception ex)
                {
                    //出错了 没有续上程序（？？？要不要关闭程序）
                }
                Thread.Sleep(30000);//每30秒 去续一次登录时长
            }
        }

        //获取电脑所有IPv4地址
        public string[] GetLocalIpv4Addresses()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            return host.AddressList
                .Where(ip => ip.AddressFamily == AddressFamily.InterNetwork) // IPv4
                .Where(ip => !IPAddress.IsLoopback(ip))                     // 排除127.0.0.1
                .Select(ip => ip.ToString())
                .ToArray();
        }

        /// <summary>
        /// 将指定进程窗口 置顶显示在最前面
        /// </summary>
        public static void BringProcessToTop(Process process)
        {
            if (process == null || process.MainWindowHandle == IntPtr.Zero)
                return;

            IntPtr hwnd = process.MainWindowHandle;

            // 还原窗口（防止最小化）
            ShowWindow(hwnd, SW_RESTORE);
            // 置顶到最前面
            SetForegroundWindow(hwnd);
        }

        #region 占线程弹框 start
        public static void ShowTransparentMask(string message, string caption = "系统提示")
        {
            // 确保在UI线程执行
            Form mainForm = Application.OpenForms.Count > 0 ? Application.OpenForms[0] : null;
            if (mainForm == null) return;

            if (mainForm.InvokeRequired)
            {
                mainForm.Invoke(new Action(() => ShowDialogInternal(message, caption)));
            }
            else
            {
                ShowDialogInternal(message, caption);
            }
        }

        private static void ShowDialogInternal(string message, string caption)
        {
            IntPtr mainHwnd = Process.GetCurrentProcess().MainWindowHandle;
            EnableWindow(mainHwnd, false);

            // 仿MessageBox样式的居中提示框
            Form dialogForm = new Form
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                Text = caption,
                MaximizeBox = false,
                MinimizeBox = false,
                ShowInTaskbar = false,
                TopMost = true,
                Size = new Size(380, 180)
            };

            // 提示文字（居中显示）
            Label lblMessage = new Label
            {
                Text = message,
                Font = new Font("微软雅黑", 10.5f),
                ForeColor = Color.Black,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(20, 30),
                Size = new Size(340, 60)
            };
            dialogForm.Controls.Add(lblMessage);

            // 关闭按钮（和MessageBox的OK按钮位置一致）
            Button btnOK = new Button
            {
                Text = "确定",
                Size = new Size(100, 30),
                Font = new Font("微软雅黑", 10f),
                DialogResult = DialogResult.OK
            };
            btnOK.Click += (s, e) => dialogForm.Close();

            // 按钮位置：底部居中偏右
            btnOK.Location = new Point((dialogForm.ClientSize.Width - btnOK.Width) / 2, 100);
            dialogForm.Controls.Add(btnOK);

            // 按Enter也能关闭
            dialogForm.AcceptButton = btnOK;

            // 显示对话框
            dialogForm.ShowDialog();

            // 恢复主窗口
            EnableWindow(mainHwnd, true);
        }
        #endregion

        #region 数据访问



        #endregion 数据访问
    }
}