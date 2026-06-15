using ClassHelper;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp.主窗体;

namespace WindowsFormsApp.维护功能
{
    public partial class MenuAssignSetting : BaseForm
    {
        private string selectedRoleCode;

        public MenuAssignSetting()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {

            // 加载角色列表
            LoadRoleList();

            // 加载菜单列表
            LoadMenuList();
        }

        /// <summary>
        /// 加载角色列表
        /// </summary>
        private void LoadRoleList()
        {
            string sql = $@"select code, name, pym, flag from code_usertype 
                             where flag='1'
                             order by code";
            DataTable dt = OracleDbHelper.ExecuteQuery(sql);
            dgvAssignList.DataSource = dt;
        }

        /// <summary>
        /// 加载所有菜单列表（带复选框）
        /// </summary>
        private void LoadMenuList()
        {
            string sql = $@"select 'false' MenuCheck,m.code MenuCode, m.name MenuName, n.name MenuFatherName, m.pym, m.flag MenuFlag
                            from code_menu m
                            left join code_menu n on m.fathercode=n.code
                            where m.flag='1' and m.menulevel='1'
                            order by n.sxh,m.sxh,m.name";
            DataTable dt = OracleDbHelper.ExecuteQuery(sql);

            dgvMenuList.DataSource = dt;
        }

        /// <summary>
        /// 角色选择改变事件
        /// </summary>
        private void dgvMenuList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAssignList.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvAssignList.SelectedRows[0];
                selectedRoleCode = row.Cells["CODE"].Value.ToString();

                // 根据角色加载已分配的菜单
                LoadAssignedMenus(selectedRoleCode);
            }
        }

        /// <summary>
        /// 加载角色已分配的菜单，并自动勾选
        /// </summary>
        /// <param name="roleCode">角色代码</param>
        private void LoadAssignedMenus(string roleCode)
        {
            // 查询该角色已分配的菜单
            string sql = $@"select menucode from code_menu_assign 
                             where usertypecode='{roleCode}' and flag='1'";
            DataTable assignedMenus = OracleDbHelper.ExecuteQuery(sql);

            // 获取已分配菜单的代码集合
            HashSet<string> assignedMenuCodes = new HashSet<string>();
            if (assignedMenus != null && assignedMenus.Rows.Count > 0)
            {
                foreach (DataRow row in assignedMenus.Rows)
                {
                    assignedMenuCodes.Add(row["MENUCODE"].ToString());
                }
            }

            // 更新右侧菜单列表的勾选状态
            if (dgvMenuList.DataSource is DataTable dt)
            {
                // 先挂起绑定，避免频繁刷新
                dgvMenuList.SuspendLayout();
                
                foreach (DataRow row in dt.Rows)
                {
                    string menuCode = row["MENUCODE"].ToString();
                    
                    // 直接设置值，不使用 AcceptChanges
                    row.BeginEdit();
                    if (assignedMenuCodes.Contains(menuCode))
                    {
                        row["MENUCHECK"] = true;
                    }else
                    {
                        row["MENUCHECK"] = false;
                    }
                    row.EndEdit();
                }
                
                // 恢复绑定并刷新
                dgvMenuList.ResumeLayout();
                dgvMenuList.Refresh();
            }
        }

        /// <summary>
        /// 保存按钮点击事件
        /// </summary>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedRoleCode))
            {
                MessageBox.Show("请先选择一个角色！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 获取右侧所有勾选的菜单
            List<string> checkedMenuCodes = new List<string>();
            if (dgvMenuList.DataSource is DataTable dt)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["MENUCHECK"] != null && Convert.ToBoolean(row["MENUCHECK"]))
                    {
                        checkedMenuCodes.Add(row["MENUCODE"].ToString());
                    }
                }
            }

            if (checkedMenuCodes.Count == 0)
            {
                DialogResult result = MessageBox.Show(
                    "您没有勾选任何菜单，将清空该角色的所有菜单权限，是否继续？",
                    "确认",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    return;
                }
            }

            try
            {
                // 先删除该角色的所有菜单分配
                string deleteSql = $@"delete from code_menu_assign 
                                      where usertypecode='{selectedRoleCode}' ";
                OracleDbHelper.ExecuteNonQuery(deleteSql);

                // 批量插入新的菜单分配
                if (checkedMenuCodes.Count > 0)
                {
                    List<string> insertSqlList = new List<string>();
                    foreach (string menuCode in checkedMenuCodes)
                    {
                        string insertSql = $@"insert into code_menu_assign (code, usertypecode, menucode, flag) 
                                             values (sys_guid(), '{selectedRoleCode}', '{menuCode}', '1')";
                        insertSqlList.Add(insertSql);
                    }

                    if (insertSqlList.Count > 0)
                    {
                        OracleDbHelper.BatchExecuteNonQuery(insertSqlList);
                    }
                }

                MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 刷新按钮点击事件
        /// </summary>
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadRoleList();
            LoadMenuList();
            selectedRoleCode = null;
        }
    }
}
