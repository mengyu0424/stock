using ClassHelper;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Other;
using WindowsFormsApp.主窗体;

namespace WindowsFormsApp.维护功能
{
    public partial class UserTypeSetting : BaseForm
    {
        public UserTypeSetting()
        {
            InitializeComponent();
            init();
        }
        private void init()
        {
            //加载机构数据
            cmb_Org.DataSource = GlobalInfo.orgData;
            cmb_Org.DisplayMember = "NAME";
            cmb_Org.ValueMember = "CODE";
            cmb_Org.Enabled = false;//暂时机构就一个，不允许修改
            cmb_Org.SelectedValue = GlobalInfo.userInfo.orgCode;

            //页面加载菜单数据
            DataTable menuData = GetUserTypeData();
            dgvUserTypeList.DataSource = menuData;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string getCodeSql = string.Format(@"select lpad(max(code)+1,4,'0') code from code_usertype");
            txtCode.Text= OracleDbHelper.ExecuteScalar(getCodeSql).ToString();
            txtName.Text = "";
            txtPym.Text = "";
            cmbFlag.SelectedIndex = 0;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var orgCode = cmb_Org.SelectedValue.ToString();
            var code = txtCode.Text.Trim();
            var name = txtName.Text.Trim();
            var pym = txtPym.Text.Trim();
            var flag = cmbFlag.SelectedItem.ToString() == "启用" ? "1" : "0";
            if (string.IsNullOrEmpty(orgCode))
            {
                MessageBox.Show("机构不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("角色代码不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("角色名称不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(flag))
            {
                MessageBox.Show("角色状态不能为空！");
                return;
            }
            List<string> sqlList = new List<string>();
            string delSql = string.Format(@" delete from code_usertype where code='{0}' and orgcode='{1}' ", code, orgCode);
            sqlList.Add(delSql);
            string addSql = string.Format(@"insert into code_usertype (CODE, NAME, PYM, FLAG, ORGCODE) values ('{0}', '{1}', '{2}', {3}, '{4}')", code, name, pym, flag, orgCode);
            sqlList.Add(addSql);
            int result = OracleDbHelper.BatchExecuteNonQuery(sqlList);
            if (result > 0)
            {
                MessageBox.Show("保存成功！");
                btn_Refresh_Click(null,null);
            }
            else
            {
                MessageBox.Show("保存失败！");
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dgvUserTypeList.DataSource = null;
            //页面加载菜单数据
            DataTable menuData = GetUserTypeData();
            dgvUserTypeList.DataSource = menuData;
        }

        private DataTable GetUserTypeData()
        {
            string sql = string.Format(@"select a.code,a.name,a.pym,a.flag,a.orgcode,b.name orgname from code_usertype a
left join code_org b on a.orgcode=b.code
where a.orgcode='{0}'
order by a.code,a.name asc ", cmb_Org.SelectedValue.ToString());
            return OracleDbHelper.ExecuteQuery(sql);
        }


        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtPym.Text = PublicFun.GetPinyin(txtName.Text.Trim());
        }

        private void dgvUserTypeList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUserTypeList.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvUserTypeList.SelectedRows[0];

                cmb_Org.SelectedIndex = 0;
                txtCode.Text = row.Cells["Code"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtPym.Text = row.Cells["Pym"].Value.ToString();
                cmbFlag.SelectedIndex = int.Parse(row.Cells["Flag"].Value.ToString()=="1"?"0":"1");
            }
        }
    }
}
