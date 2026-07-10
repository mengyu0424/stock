using ClassHelper;
using ClassLibrary;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp.Other;
using WindowsFormsApp.主窗体;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace WindowsFormsApp.维护功能
{
    public partial class WpdmSetting : BaseForm
    {
        private bool _pageReady;

        public WpdmSetting()
        {
            InitializeComponent();
            InitPage();
        }

        private void InitPage()
        {
            LoadStatusFilter();
            LoadTypeFilter();
            _pageReady = true;
            LoadWpdmData();
        }

        private void LoadStatusFilter()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CODE");
            dt.Columns.Add("NAME");

            dt.Rows.Add(string.Empty, "全部");
            dt.Rows.Add("1", "启用");
            dt.Rows.Add("0", "禁用");

            cmbStatusFilter.DataSource = dt;
            cmbStatusFilter.DisplayMember = "NAME";
            cmbStatusFilter.ValueMember = "CODE";
        }

        private void LoadTypeFilter()
        {
            DataTable dt = PublicFun.GetDictDataList("WP_TYPE", true); 
            cmbTypeFilter.DataSource = dt;
            cmbTypeFilter.DisplayMember = "NAME";
            cmbTypeFilter.ValueMember = "CODE";
        }

        private void LoadWpdmData(string selectedCode = "")
        {
            string sql = @"select a.code,
                                   a.name,
                                   a.pym,
                                   a.flag,
                                   a.type,
                                   nvl(n.name, '') as type_name,
                                   a.gg,
                                   a.jhj,
                                   a.lsj,
                                   a.sxh,
                                   a.bz
                            from code_wpdm a
                            left join code_dict_next n
                                   on a.type = n.code
                                  and n.maincode = :maincode
                            left join code_dict_main m
                                   on n.maincode = m.code
                            where 1 = 1";

            List<OracleParameter> parameters = new List<OracleParameter>
            {
                new OracleParameter(":maincode", "WP_TYPE")
            };

            string flag = cmbStatusFilter.SelectedValue == null ? string.Empty : cmbStatusFilter.SelectedValue.ToString();
            if (!string.IsNullOrWhiteSpace(flag))
            {
                sql += " and a.flag = :flag";
                parameters.Add(new OracleParameter(":flag", flag));
            }

            string type = cmbTypeFilter.SelectedValue == null ? string.Empty : cmbTypeFilter.SelectedValue.ToString();
            if (!string.IsNullOrWhiteSpace(type))
            {
                sql += " and a.type = :type";
                parameters.Add(new OracleParameter(":type", type));
            }

            string keyword = txtKeyword.Text.Trim();
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                sql += @" and (
                                instr(upper(nvl(a.code, '')), upper(:keyword1)) > 0
                             or instr(upper(nvl(a.name, '')), upper(:keyword2)) > 0
                             or instr(upper(nvl(a.pym, '')), upper(:keyword3)) > 0
                             or instr(upper(nvl(a.gg, '')), upper(:keyword4)) > 0
                             or instr(upper(nvl(a.bz, '')), upper(:keyword5)) > 0
                           )";
                parameters.Add(new OracleParameter(":keyword1", keyword));
                parameters.Add(new OracleParameter(":keyword2", keyword));
                parameters.Add(new OracleParameter(":keyword3", keyword));
                parameters.Add(new OracleParameter(":keyword4", keyword));
                parameters.Add(new OracleParameter(":keyword5", keyword));
            }

            sql += " order by nvl(a.sxh, 0), a.code";

            dgvWpdmList.DataSource = OracleDbHelper.ExecuteQuery(sql, parameters.ToArray());

            if (dgvWpdmList.Rows.Count <= 0)
            {
                dgvWpdmList.ClearSelection();
                return;
            }

            if (!string.IsNullOrWhiteSpace(selectedCode) && SelectRow(selectedCode))
            {
                return;
            }

            dgvWpdmList.Rows[0].Selected = true;
            dgvWpdmList.CurrentCell = dgvWpdmList.Rows[0].Cells["CODE"];
        }

        private bool SelectRow(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                return false;
            }

            foreach (DataGridViewRow row in dgvWpdmList.Rows)
            {
                string rowCode = row.Cells["CODE"].Value == null ? string.Empty : row.Cells["CODE"].Value.ToString();
                if (!string.Equals(rowCode, code, StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                row.Selected = true;
                dgvWpdmList.CurrentCell = row.Cells["CODE"];
                return true;
            }

            return false;
        }

        private DataGridViewRow GetSelectedRow(bool showMessage = true)
        {
            if (dgvWpdmList.SelectedRows.Count > 0)
            {
                return dgvWpdmList.SelectedRows[0];
            }

            if (showMessage)
            {
                MessageBox.Show("请先选择需要操作的物品代码数据！");
            }

            return null;
        }

        private void OpenEditDialog(string mode)
        {
            string code = string.Empty;
            if (mode == "Edit")
            {
                DataGridViewRow row = GetSelectedRow();
                if (row == null)
                {
                    return;
                }

                code = row.Cells["CODE"].Value == null ? string.Empty : row.Cells["CODE"].Value.ToString();
            }

            using (WpdmInfoSetting dialog = new WpdmInfoSetting(mode, code))
            {
                if (dialog.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                LoadWpdmData(dialog.SavedCode);
            }
        }

        private void UpdateFlag(string targetFlag)
        {
            DataGridViewRow row = GetSelectedRow();
            if (row == null)
            {
                return;
            }

            string code = row.Cells["CODE"].Value == null ? string.Empty : row.Cells["CODE"].Value.ToString();
            string name = row.Cells["NAME"].Value == null ? string.Empty : row.Cells["NAME"].Value.ToString();
            string currentFlag = row.Cells["FLAG"].Value == null ? string.Empty : row.Cells["FLAG"].Value.ToString();
            string actionText = targetFlag == "1" ? "启用" : "禁用";

            if (currentFlag == targetFlag)
            {
                MessageBox.Show($"当前物品已是{actionText}状态，无需重复操作。");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"确认要{actionText}物品[{name}]吗？",
                "提示",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            string sql = @"update code_wpdm
                            set flag = :flag,
                                xgr = :xgr,
                                xgsj = sysdate
                            where code = :code";

            int count = OracleDbHelper.ExecuteNonQuery(
                sql,
                new OracleParameter(":flag", targetFlag),
                new OracleParameter(":xgr", GlobalInfo.userInfo.ID),
                new OracleParameter(":code", code));

            if (count <= 0)
            {
                MessageBox.Show($"{actionText}失败，请稍后重试。");
                return;
            }

            MessageBox.Show($"{actionText}成功！");
            LoadWpdmData(code);
        }

        private bool CopyWpdmToNew(string sourceCode, string newCode, string newName, int newSxh)
        {
            if (string.IsNullOrWhiteSpace(sourceCode))
            {
                MessageBox.Show("源物品代码不能为空！");
                return false;
            }

            if (string.IsNullOrWhiteSpace(newCode) || string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("新物品代码和名称不能为空！");
                return false;
            }

            string existsSql = @"select count(1)
                                 from code_wpdm
                                 where code = :code";

            int existsCount = int.Parse(OracleDbHelper.ExecuteScalar(
                existsSql,
                new OracleParameter(":code", newCode)).ToString());

            if (existsCount > 0)
            {
                MessageBox.Show("新物品代码已存在，请刷新后重试。");
                return false;
            }

            string insertSql = @"insert into code_wpdm
                                  (code, name, pym, flag, sxh, bz, type, gg, jhj, lsj, xgr, xgsj)
                                  select :newCode,
                                         :newName,
                                         :newPym,
                                         flag,
                                         :newSxh,
                                         bz,
                                         type,
                                         gg,
                                         jhj,
                                         lsj,
                                         :xgr,
                                         sysdate
                                    from code_wpdm
                                   where code = :sourceCode";

            int count = OracleDbHelper.ExecuteNonQuery(
                insertSql,
                new OracleParameter(":newCode", newCode),
                new OracleParameter(":newName", newName),
                new OracleParameter(":newPym", Other.PublicFun.GetPinyin(newName)),
                new OracleParameter(":newSxh", newSxh),
                new OracleParameter(":xgr", GlobalInfo.userInfo.ID),
                new OracleParameter(":sourceCode", sourceCode));

            if (count <= 0)
            {
                MessageBox.Show("复制新增失败，源数据可能已被删除。");
                return false;
            }

            return true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = GetSelectedRow(false);
            string currentCode = string.Empty;
            if (row != null && row.Cells["CODE"].Value != null)
            {
                currentCode = row.Cells["CODE"].Value.ToString();
            }
            LoadWpdmData(currentCode);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenEditDialog("Add");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OpenEditDialog("Edit");
        }

        private void btnCopyAdd_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = GetSelectedRow();
            if (row == null)
            {
                return;
            }

            string sourceCode = row.Cells["CODE"].Value == null ? string.Empty : row.Cells["CODE"].Value.ToString();
            string sourceName = row.Cells["NAME"].Value == null ? string.Empty : row.Cells["NAME"].Value.ToString();
            int seq = PublicFun.GetSeqBySeqName("CODE_WPDM_CODE");
            string newCode = "WP" + seq.ToString("D10");
            int newSxh = seq;

            using (WpdmSettingCopy dialog = new WpdmSettingCopy(newCode, newSxh, $"{sourceName}-复制"))
            {
                if (dialog.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                if (!CopyWpdmToNew(sourceCode, dialog.NewWpdmCode, dialog.NewWpdmName, dialog.NewSxh))
                {
                    return;
                }

                MessageBox.Show("复制新增成功！");
                LoadWpdmData(dialog.NewWpdmCode);
            }
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            UpdateFlag("1");
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            UpdateFlag("0");
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            LoadWpdmData();
        }

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_pageReady)
            {
                LoadWpdmData();
            }
        }

        private void cmbTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_pageReady)
            {
                LoadWpdmData();
            }
        }

        private void txtKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            e.Handled = true;
            e.SuppressKeyPress = true;
            LoadWpdmData();
        }

        private void dgvWpdmList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            OpenEditDialog("Edit");
        }
    }
}
