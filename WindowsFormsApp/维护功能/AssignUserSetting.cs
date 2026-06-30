using ClassHelper;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp.主窗体;

namespace WindowsFormsApp.维护功能
{
    public partial class AssignUserSetting : BaseForm
    {
        private string selectedUserCode;

        public AssignUserSetting()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            LoadUserList();
            LoadRoleList();
        }

        private void LoadUserList()
        {
            string sql = @"select code, name, flag
                           from code_czydm
                           where flag='1'
                           order by code, name";
            dgvAssignList.DataSource = OracleDbHelper.ExecuteQuery(sql);
        }

        private void LoadRoleList()
        {
            string sql = @"select 'false' RoleCheck, code RoleCode, name RoleName, flag RoleFlag
                           from code_usertype
                           where flag='1'
                           order by code, name";
            dgvRoleList.DataSource = OracleDbHelper.ExecuteQuery(sql);
        }

        private void dgvAssignList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAssignList.SelectedRows.Count <= 0)
            {
                return;
            }

            DataGridViewRow row = dgvAssignList.SelectedRows[0];
            selectedUserCode = row.Cells["CODE"].Value?.ToString();
            if (string.IsNullOrWhiteSpace(selectedUserCode))
            {
                return;
            }

            LoadAssignedRoles(selectedUserCode);
        }

        private void LoadAssignedRoles(string userCode)
        {
            string sql = $@"select usertypecode
                            from code_czy_usertype
                            where czycode='{userCode}' and flag='1'";
            DataTable assignedRoles = OracleDbHelper.ExecuteQuery(sql);

            HashSet<string> assignedRoleCodes = new HashSet<string>();
            if (assignedRoles != null)
            {
                foreach (DataRow row in assignedRoles.Rows)
                {
                    assignedRoleCodes.Add(row["USERTYPECODE"].ToString());
                }
            }

            if (!(dgvRoleList.DataSource is DataTable dt))
            {
                return;
            }

            dgvRoleList.SuspendLayout();
            foreach (DataRow row in dt.Rows)
            {
                string roleCode = row["ROLECODE"].ToString();
                row.BeginEdit();
                row["ROLECHECK"] = assignedRoleCodes.Contains(roleCode);
                row.EndEdit();
            }
            dgvRoleList.ResumeLayout();
            dgvRoleList.Refresh();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedUserCode))
            {
                MessageBox.Show("Please select an operator first.", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> checkedRoleCodes = new List<string>();
            if (dgvRoleList.DataSource is DataTable dt)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["ROLECHECK"] != null && Convert.ToBoolean(row["ROLECHECK"]))
                    {
                        checkedRoleCodes.Add(row["ROLECODE"].ToString());
                    }
                }
            }

            if (checkedRoleCodes.Count == 0)
            {
                DialogResult confirmResult = MessageBox.Show(
                    "No roles are selected. Saving will clear all role assignments for this operator. Continue?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult != DialogResult.Yes)
                {
                    return;
                }
            }

            try
            {
                List<string> sqlList = new List<string>
                {
                    $@"delete from code_czy_usertype
                       where czycode='{selectedUserCode}'"
                };

                foreach (string roleCode in checkedRoleCodes)
                {
                    sqlList.Add($@"insert into code_czy_usertype (code, czycode, usertypecode, flag)
                                   values (sys_guid(), '{selectedUserCode}', '{roleCode}', '1')");
                }

                OracleDbHelper.BatchExecuteNonQuery(sqlList);
                MessageBox.Show("Save succeeded.", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAssignedRoles(selectedUserCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Save failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            selectedUserCode = null;
            LoadUserList();
            LoadRoleList();
        }
    }
}
