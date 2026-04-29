using ClassHelper;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp.Other;
using WindowsFormsApp.主窗体;

namespace WindowsFormsApp.维护功能
{
    public partial class MenuEdit : BasePopupForm
    {
        private string winType = string.Empty;
        private DataTable priData = new DataTable();

        private string priOrgCode = string.Empty;
        private string priMenuCode = string.Empty;
        /// <summary>
        ///
        /// </summary>
        /// <param name="winType">弹窗用途 Add-新增 Edit-修改 View-查看</param>
        /// <param name="dt"></param>
        public MenuEdit(string Type, DataTable dt)
        {
            this.winType = Type;
            priData = dt;
            InitializeComponent();
            MenuEdit_Load();
            if (Type == "Add")
            {
                MenuAddLoad();
            }
            else if (Type == "Edit")
            {
                MenuEditLoad(dt);
            }
            else
            {
                MenuAddLoad();
            }
        }

        private void MenuEdit_Load()
        {
            //机构数据
            cmbOrg.DataSource = GlobalInfo.orgData;
            cmbOrg.DisplayMember = "NAME";
            cmbOrg.ValueMember = "CODE";
            cmbOrg.SelectedValue = GlobalInfo.userInfo.orgCode;
            cmbOrg.Enabled = false;//暂时机构就一个，不允许修改



            if (winType== "Add" || priData.Rows[0]["menulevel"].ToString()!="0")
            {
                //上级菜单数据
                string sql = string.Format(@" select code,name from code_menu where menulevel='0' and flag='1' and orgcode='{0}' ", GlobalInfo.userInfo.orgCode);
                if (winType == "Edit")
                {
                    sql += string.Format(" and code!='{0}' ", priData.Rows[0]["menuCode"].ToString());
                }
                DataTable menuDt = OracleDbHelper.ExecuteQuery(sql);
                cmbFatherMenu.DataSource = menuDt;
                cmbFatherMenu.DisplayMember = "NAME";
                cmbFatherMenu.ValueMember = "CODE";
            }

            cmbFatherMenu.Enabled = true;
            txtMenuCode.Enabled = false;
            txtMenuName.Enabled = true;
            txtPym.Enabled = true;
            cmbFlag.Enabled = true;
            txtSxh.Enabled = true;
            txt_url.Enabled = true;

        }

        /// <summary>
        ///
        /// </summary>
        private void MenuAddLoad()
        {
            txtMenuCode.Text = OracleDbHelper.ExecuteScalar(string.Format("select max(code)+1 code from code_menu where orgcode='{0}'", GlobalInfo.userInfo.orgCode)).ToString();
            priOrgCode = GlobalInfo.userInfo.orgCode;
            priMenuCode = txtMenuCode.Text;
        }

        private void MenuEditLoad(DataTable dt)
        {
            cmbOrg.SelectedValue = dt.Rows[0]["orgCode"].ToString();
            cmbFatherMenu.SelectedValue = dt.Rows[0]["fatherCode"].ToString();
            txtMenuCode.Text = dt.Rows[0]["menuCode"].ToString();
            txtMenuName.Text = dt.Rows[0]["menuName"].ToString();
            txtPym.Text = dt.Rows[0]["pym"].ToString();
            cmbFlag.SelectedItem = dt.Rows[0]["flag"].ToString()=="1"?"启用":"禁用";
            txtSxh.Text = dt.Rows[0]["sxh"].ToString();
            txt_url.Text = dt.Rows[0]["path"].ToString();

            priOrgCode = dt.Rows[0]["orgCode"].ToString();
            priMenuCode = dt.Rows[0]["menuCode"].ToString();
        }

        private void myButton2_Click(object sender, EventArgs e)
        {
            base.Dispose();
            this.Close();
        }

        private void txtMenuName_TextChanged(object sender, EventArgs e)
        {
            txtPym.Text=PublicFun.GetPinyin(txtMenuName.Text.Trim());
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var orgCode = cmbOrg.SelectedValue.ToString();
            var fatherCode = cmbFatherMenu.SelectedValue.ToString();
            var menuCode = txtMenuCode.Text.Trim();
            var menuName = txtMenuName.Text.Trim();
            var pym = txtPym.Text.Trim();
            var flag = cmbFlag.SelectedItem.ToString() == "启用" ? "1" : "0";
            var sxh = txtSxh.Text.Trim();
            var path = txt_url.Text.Trim();
            var menulevel = fatherCode == "" ? 0 : 1;

            List<string> sqlList = new List<string>();
            string delSql = string.Format(@" delete from code_menu where orgcode='{0}' and code='{1}' ", priOrgCode, priMenuCode);
            sqlList.Add(delSql);
            string addSql = string.Format(@"insert into code_menu (CODE, NAME, PYM, MENULEVEL, FATHERCODE, FLAG, PATH, ORGCODE, SXH)
                                                                        values ('{0}', '{1}', '{2}', {3}, '{4}', {5}, '{6}', '{7}', {8})", menuCode, menuName, pym, menulevel, fatherCode, flag, path, orgCode, sxh);
            sqlList.Add(addSql);
            int result = OracleDbHelper.BatchExecuteNonQuery(sqlList);
            if (result > 0)
            {
                MessageBox.Show("保存成功！");
                base.Dispose();
                this.Close();
            }
            else
            {
                MessageBox.Show("保存失败！");
            }
        }
    }
}