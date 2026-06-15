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
    public partial class UserSetting : BaseForm
    {
        public UserSetting()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            //页面加载操作员数据
            DataTable operatorData = GetOperatorData();
            dgvOperatorList.DataSource = operatorData;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string getCodeSql = string.Format(@"select lpad(max(code)+1,4,'0') code from code_czydm");
            object result = OracleDbHelper.ExecuteScalar(getCodeSql);
            txtCode.Text = result != null && result != DBNull.Value ? result.ToString() : "0001";
            txtName.Text = "";
            txtPym.Text = "";
            txtPassword.Text = "";
            cmbFlag.SelectedIndex = 0;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var code = txtCode.Text.Trim();
            var name = txtName.Text.Trim();
            var pym = txtPym.Text.Trim();
            var password = txtPassword.Text.Trim();
            var flag = cmbFlag.SelectedItem.ToString() == "启用" ? "1" : "0";

            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("操作员代码不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("操作员名称不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("密码不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(flag))
            {
                MessageBox.Show("操作员状态不能为空！");
                return;
            }
            //密码进行md5转译
            password = PublicFun.ToMD5(password);
            List<string> sqlList = new List<string>();
            string delSql = string.Format(@"delete from code_czydm where code='{0}' ", code);
            sqlList.Add(delSql);
            string addSql = string.Format(@"insert into code_czydm (CODE, NAME, PYM, PASS, FLAG) values ('{0}', '{1}', '{2}', '{3}', {4})", 
                code, name, pym, password, flag);
            sqlList.Add(addSql);

            int result = OracleDbHelper.BatchExecuteNonQuery(sqlList);
            if (result > 0)
            {
                MessageBox.Show("保存成功！");
                btn_Refresh_Click(null, null);
            }
            else
            {
                MessageBox.Show("保存失败！");
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dgvOperatorList.DataSource = null;
            DataTable operatorData = GetOperatorData();
            dgvOperatorList.DataSource = operatorData;
        }

        private DataTable GetOperatorData()
        {
            string sql = string.Format(@"select a.code, a.name, a.pym, a.flag
                                        from code_czydm a
                                        order by a.code, a.name asc");
            return OracleDbHelper.ExecuteQuery(sql);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtPym.Text = PublicFun.GetPinyin(txtName.Text.Trim());
        }

        private void dgvOperatorList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOperatorList.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvOperatorList.SelectedRows[0];

                txtCode.Text = row.Cells["CODE"].Value.ToString();
                txtName.Text = row.Cells["NAME"].Value.ToString();
                txtPym.Text = row.Cells["PYM"].Value.ToString();
                txtPassword.Text = ""; //安全考虑不显示密码
                cmbFlag.SelectedIndex = row.Cells["FLAG"].Value.ToString() == "1" ? 0 : 1;
            }
        }
    }
}
