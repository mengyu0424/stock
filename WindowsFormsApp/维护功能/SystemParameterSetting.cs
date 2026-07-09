using ClassHelper;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp.主窗体;

namespace WindowsFormsApp.维护功能
{
    public partial class SystemParameterSetting : BaseForm
    {
        private string _editMode = "Add";
        private string _originalXtmk = string.Empty;
        private string _originalCsmc = string.Empty;

        public SystemParameterSetting()
        {
            InitializeComponent();
            InitPage();
        }

        private void InitPage()
        {
            cmbFlag.SelectedIndex = 0;
            ClearEditor();
            LoadSystemParameterData();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            _editMode = "Add";
            ClearEditor();
            SetEnabled(true);
            dgvSystemParameterList.ClearSelection();
            txtXtmk.Focus();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgvSystemParameterList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请先选择要修改的数据！");
                return;
            }

            DataGridViewRow row = dgvSystemParameterList.SelectedRows[0];
            LoadEditorFromRow(row);
            _editMode = "Edit";
            _originalXtmk = txtXtmk.Text.Trim();
            _originalCsmc = txtCsmc.Text.Trim();
            cmbFlag.Enabled = true;
            txtCsz.Enabled = true;
            txtBz.Enabled = true;
            txtCsz.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string xtmk = txtXtmk.Text.Trim();
            string csmc = txtCsmc.Text.Trim();
            string csz = txtCsz.Text.Trim();
            string bz = txtBz.Text.Trim();
            string flag = cmbFlag.SelectedItem != null && cmbFlag.SelectedItem.ToString() == "启用" ? "1" : "0";

            if (string.IsNullOrWhiteSpace(xtmk))
            {
                MessageBox.Show("系统模块不能为空！");
                return;
            }

            if (string.IsNullOrWhiteSpace(csmc))
            {
                MessageBox.Show("参数名称不能为空！");
                return;
            }

            if (string.IsNullOrWhiteSpace(csz))
            {
                MessageBox.Show("参数值不能为空！");
                return;
            }

            try
            {
                bool saveResult = _editMode == "Edit"
                    ? UpdateSystemParameter(xtmk, csmc, csz, flag, bz)
                    : AddSystemParameter(xtmk, csmc, csz, flag, bz);

                if (!saveResult)
                {
                    MessageBox.Show("保存失败！");
                }

                MessageBox.Show("保存成功！");
                LoadSystemParameterData(txtQuery.Text.Trim());
                SelectRow(xtmk, csmc);
                _editMode = "Edit";
                _originalXtmk = xtmk;
                _originalCsmc = csmc;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存失败：{ex.Message}");
            }
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            LoadSystemParameterData(txtQuery.Text.Trim());
        }

        private void dgvSystemParameterList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSystemParameterList.SelectedRows.Count <= 0)
            {
                return;
            }

            LoadEditorFromRow(dgvSystemParameterList.SelectedRows[0]);
            SetEnabled(false);
            _editMode = "Edit";
            _originalXtmk = txtXtmk.Text.Trim();
            _originalCsmc = txtCsmc.Text.Trim();
        }

        private void ClearEditor()
        {
            txtXtmk.Text = string.Empty;
            txtCsmc.Text = string.Empty;
            txtCsz.Text = string.Empty;
            txtBz.Text = string.Empty;
            cmbFlag.SelectedIndex = 0;
            _originalXtmk = string.Empty;
            _originalCsmc = string.Empty;
        }
        private void SetEnabled(bool state) {
            txtXtmk.Enabled = state;
            txtCsmc.Enabled = state;
            txtCsz.Enabled = state;
            txtBz.Enabled = state;
            cmbFlag.Enabled = state;
        }

        private void LoadEditorFromRow(DataGridViewRow row)
        {
            txtXtmk.Text = row.Cells["XTMK"].Value?.ToString() ?? string.Empty;
            txtCsmc.Text = row.Cells["CSMC"].Value?.ToString() ?? string.Empty;
            txtCsz.Text = row.Cells["CSZ"].Value?.ToString() ?? string.Empty;
            txtBz.Text = row.Cells["BZ"].Value?.ToString() ?? string.Empty;
            cmbFlag.SelectedIndex = row.Cells["FLAG"].Value?.ToString() == "1" ? 0 : 1;
        }

        private void LoadSystemParameterData(string keyword = "")
        {
            string sql;
            DataTable dt;

            if (string.IsNullOrWhiteSpace(keyword))
            {
                sql = $@"select xtmk, csmc, csz, flag, bz
                         from code_xtcs
                         order by xtmk, csmc";
                dt = OracleDbHelper.ExecuteQuery(sql);
            }
            else
            {
                sql = $@"select xtmk, csmc, csz, flag, bz
                         from code_xtcs
                         where instr(upper(nvl(xtmk, '')), upper(:keyword1)) > 0
                            or instr(upper(nvl(csmc, '')), upper(:keyword2)) > 0
                            or instr(upper(nvl(csz, '')), upper(:keyword3)) > 0
                            or instr(upper(nvl(bz, '')), upper(:keyword4)) > 0
                         order by xtmk, csmc";
                dt = OracleDbHelper.ExecuteQuery(
                    sql,
                    new OracleParameter(":keyword1", keyword),
                    new OracleParameter(":keyword2", keyword),
                    new OracleParameter(":keyword3", keyword),
                    new OracleParameter(":keyword4", keyword));
            }

            dgvSystemParameterList.DataSource = dt;

            if (dgvSystemParameterList.Rows.Count > 0)
            {
                dgvSystemParameterList.Rows[0].Selected = true;
                dgvSystemParameterList.CurrentCell = dgvSystemParameterList.Rows[0].Cells["XTMK"];
                LoadEditorFromRow(dgvSystemParameterList.Rows[0]);
                _editMode = "Edit";
                _originalXtmk = txtXtmk.Text.Trim();
                _originalCsmc = txtCsmc.Text.Trim();
            }
            else
            {
                ClearEditor();
                _editMode = "Add";
            }
        }

        private bool AddSystemParameter(string xtmk, string csmc, string csz, string flag, string bz)
        {
            string existsSql = $@"select count(1)
                                  from code_xtcs
                                  where xtmk = :xtmk and csmc = :csmc";

            int existsCount = ToInt(OracleDbHelper.ExecuteScalar(
                existsSql,
                new OracleParameter(":xtmk", xtmk),
                new OracleParameter(":csmc", csmc)));

            if (existsCount > 0)
            {
                MessageBox.Show("当前系统模块和参数名称的组合已存在，请确认后再保存！");
                return false;
            }

            string insertSql = $@"insert into code_xtcs (xtmk, csmc, csz, flag, bz)
                                  values (:xtmk, :csmc, :csz, :flag, :bz)";

            int result = OracleDbHelper.ExecuteNonQuery(
                insertSql,
                new OracleParameter(":xtmk", xtmk),
                new OracleParameter(":csmc", csmc),
                new OracleParameter(":csz", csz),
                new OracleParameter(":flag", flag),
                new OracleParameter(":bz", string.IsNullOrWhiteSpace(bz) ? (object)DBNull.Value : bz));

            return result > 0;
        }

        private bool UpdateSystemParameter(string xtmk, string csmc, string csz, string flag, string bz)
        {
            if (string.IsNullOrWhiteSpace(_originalXtmk) || string.IsNullOrWhiteSpace(_originalCsmc))
            {
                MessageBox.Show("请先选择要修改的数据！");
                return false;
            }

            string existsSql = $@"select count(1)
                                  from code_xtcs
                                  where xtmk = :xtmk
                                    and csmc = :csmc ";

            int existsCount = ToInt(OracleDbHelper.ExecuteScalar(
                existsSql,
                new OracleParameter(":xtmk", xtmk),
                new OracleParameter(":csmc", csmc)));

            if (existsCount > 0)
            {
                List<(string Sql, OracleParameter[] Params)> sqlList = new List<(string Sql, OracleParameter[] Params)>
                {
                    (
                        $@"delete from code_xtcs
                           where xtmk = :originalXtmk and csmc = :originalCsmc",
                        new[]
                        {
                            new OracleParameter(":originalXtmk", _originalXtmk),
                            new OracleParameter(":originalCsmc", _originalCsmc)
                        }
                    ),
                    (
                        $@"insert into code_xtcs (xtmk, csmc, csz, flag, bz)
                           values (:xtmk, :csmc, :csz, :flag, :bz)",
                        new[]
                        {
                            new OracleParameter(":xtmk", xtmk),
                            new OracleParameter(":csmc", csmc),
                            new OracleParameter(":csz", csz),
                            new OracleParameter(":flag", flag),
                            new OracleParameter(":bz", string.IsNullOrWhiteSpace(bz) ? (object)DBNull.Value : bz)
                        }
                    )
                };

                return OracleDbHelper.BatchExecuteNonQuery(sqlList) > 0;
            }
            else
            {
                return false;
            }
        }

        private void SelectRow(string xtmk, string csmc)
        {
            foreach (DataGridViewRow row in dgvSystemParameterList.Rows)
            {
                string rowXtmk = row.Cells["XTMK"].Value?.ToString() ?? string.Empty;
                string rowCsmc = row.Cells["CSMC"].Value?.ToString() ?? string.Empty;
                if (rowXtmk == xtmk && rowCsmc == csmc)
                {
                    row.Selected = true;
                    dgvSystemParameterList.CurrentCell = row.Cells["XTMK"];
                    LoadEditorFromRow(row);
                    break;
                }
            }
        }

        private int ToInt(object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return 0;
            }

            int result;
            return int.TryParse(value.ToString(), out result) ? result : 0;
        }
    }
}
