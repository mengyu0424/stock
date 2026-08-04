using ClassHelper;
using ClassLibrary;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;
using WindowsFormsApp.Other;
using WindowsFormsApp.主窗体;

namespace WindowsFormsApp.库房业务
{
    public partial class KcStates : BaseForm
    {

        private readonly bool _allowManage;

        public KcStates()
            : this(string.Empty)
        {
        }

        public KcStates(string menuParameter)
        {
            _allowManage = string.Equals(menuParameter?.Trim(), "Manage", StringComparison.OrdinalIgnoreCase);

            InitializeComponent();
            InitPage();
        }

        private void InitPage()
        {
            btnEnable.Visible = _allowManage;
            btnDisable.Visible = _allowManage;

            LoadStatusFilter();
            LoadTypeFilter();
            LoadInventoryData();
        }

        private void LoadStatusFilter()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CODE");
            dt.Columns.Add("NAME");
            dt.Rows.Add("1", "启用");
            dt.Rows.Add("0", "禁用");

            cmbStatusFilter.DataSource = dt;
            cmbStatusFilter.DisplayMember = "NAME";
            cmbStatusFilter.ValueMember = "CODE";
        }

        private void LoadTypeFilter()
        {
            cmbTypeFilter.DataSource = PublicFun.GetDictDataList("WP_TYPE", true);
            cmbTypeFilter.DisplayMember = "NAME";
            cmbTypeFilter.ValueMember = "CODE";
        }

        private void LoadInventoryData()
        {
            try
            {
                string sql = $@"select a.code as code,
                                       b.name as name,
                                       a.flag as flag,
                                       b.type as type,
                                       nvl(n.name, '') as type_name,
                                       b.gg as gg,
                                       a.ph as ph,
                                       a.pc as pc,
                                       a.jhj as jhj,
                                       a.lsj as lsj,
                                       nvl(a.sl, 0) as sysl,
                                       nvl(a.sl, 0) * nvl(a.jhj, 0) as jhje,
                                       nvl(a.sl, 0) * nvl(a.lsj, 0) as lsje
                                from ck_kc_states a
                                left join code_wpdm b
                                       on a.code = b.code
                                left join code_dict_next n
                                       on b.type = n.code
                                where 1 = 1";
                string itemType= cmbStatusFilter.SelectedValue.ToString();
                if (!string.IsNullOrWhiteSpace(itemType))
                {
                    sql += string.Format(" and n.maincode ='{0}' ", itemType);
                }
                string type = cmbTypeFilter.SelectedValue?.ToString();
                if (!string.IsNullOrWhiteSpace(type))
                {
                    sql += string.Format(" and b.type ='{0}' ",type);
                }


                string keyword = txtKeyword.Text.Trim();
                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    sql += string.Format(@" and ( a.code like '%{0}%' or b.name like '%{0}%' or upper(b.pym) like upper('%{0}%') )", keyword);
                }

                sql += $@" order by a.code ";

                dgvInventoryList.DataSource = OracleDbHelper.ExecuteQuery(sql);
            }
            catch (Exception ex)
            {
                dgvInventoryList.DataSource = null;
                MessageBox.Show(
                    $"库存数据加载失败：{ex.Message}",
                    "提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void UpdateFlag(string targetFlag)
        {
            if (!_allowManage)
            {
                return;
            }

            DataGridViewRow row = GetSelectedRow();
            if (row == null)
            {
                return;
            }

            string code = GetCellValue(row, "CODE");
            string batchNo = GetCellValue(row, "PH");
            string batch = GetCellValue(row, "PC");
            string name = GetCellValue(row, "NAME");
            string currentFlag = GetCellValue(row, "FLAG");
            string actionText = targetFlag == "1" ? "启用" : "停用";

            if (string.Equals(currentFlag, targetFlag, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show($"当前库存记录已经是{actionText}状态，无需重复操作。");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"确认要{actionText}物品[{name}]的库存记录吗？",
                "提示",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            string sql = string.Format(@"update ck_kc_states set flag='{0}' where code='{1}' and pc='{2}' and ph='{3}' ", targetFlag,code, batchNo, batch);

            int count = OracleDbHelper.ExecuteNonQuery(sql);

            if (count <= 0)
            {
                MessageBox.Show($"{actionText}失败，请稍后重试。");
                return;
            }

            MessageBox.Show($"{actionText}成功。");
            LoadInventoryData();
        }

        private DataGridViewRow GetSelectedRow()
        {
            if (dgvInventoryList.SelectedRows.Count > 0)
            {
                return dgvInventoryList.SelectedRows[0];
            }

            MessageBox.Show("请先选择需要操作的库存记录。");
            return null;
        }

        private static string GetCellValue(DataGridViewRow row, string columnName)
        {
            return row.Cells[columnName].Value == null || row.Cells[columnName].Value == DBNull.Value
                ? string.Empty
                : row.Cells[columnName].Value.ToString();
        }


        private void btnQuery_Click(object sender, EventArgs e)
        {
            LoadInventoryData();
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            UpdateFlag("1");
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            UpdateFlag("0");
        }


        private void txtKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            e.Handled = true;
            e.SuppressKeyPress = true;
            LoadInventoryData();
        }
    }
}
