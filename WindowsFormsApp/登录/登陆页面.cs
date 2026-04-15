using ClassHelper;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp.Other;

namespace WindowsFormsApp.登录
{
    public partial class 登录页面 : Form
    {
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
            if (csbz == "1")
            {
                cmbOrg.DataSource = new List<dynamic> { new { CODE = "000000", NAME = "梦屿库存管理测试" } };
                cmbOrg.DisplayMember = "NAME";
                cmbOrg.ValueMember = "CODE";
            }
            else
            {
                DataTable orgDt = LoadGetOrg();
                cmbOrg.DataSource = orgDt;
                cmbOrg.DisplayMember = "NAME";
                cmbOrg.ValueMember = "CODE";
            }
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
            string orgCode = cmbOrg.SelectedValue.ToString();
            string orgName = cmbOrg.Text;

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
                    GlobalInfo.userInfo.orgCode = orgCode;
                    GlobalInfo.userInfo.orgName = orgName;
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
                string sql = string.Format(" select t.code,t.name,t.pass,t.orgcode,t.flag from code_czydm t where t.code='{0}' and t.orgcode='{1}' ", user, orgCode);
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
                GlobalInfo.userInfo.orgCode = dr["ORGCODE"].ToString();
                GlobalInfo.userInfo.orgName = orgName;
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

        #region 数据访问

        private DataTable LoadGetOrg()
        {
            string sql = " select t.code,t.name,t.pym,t.flag from code_org t where t.flag='1' ";
            DataTable dt = OracleDbHelper.ExecuteQuery(sql);

            #region 登录将机构数据加载到全局变量，后续页面需要使用，避免重复查询数据库

            GlobalInfo.orgData = dt.AsEnumerable().Select(r => new OrgData
            {
                CODE = r["CODE"].ToString(),
                Name = r["NAME"].ToString(),
                PYM = r["PYM"].ToString(),
                FLAG = r["FLAG"].ToString()
            }).ToList();

            #endregion 登录将机构数据加载到全局变量，后续页面需要使用，避免重复查询数据库

            return dt;
        }

        #endregion 数据访问
    }
}