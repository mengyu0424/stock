using ClassHelper;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp.主窗体;

namespace WindowsFormsApp.维护功能
{
    public partial class DictListSetting : BaseForm
    {
        private const string ModeAdd = "Add";
        private const string ModeEditMain = "EditMain";
        private const string ModeEditDetail = "EditDetail";

        private string _editMode = ModeAdd;
        private string _originalCode = string.Empty;

        public DictListSetting()
        {
            InitializeComponent();
            InitPage();
        }

        private void InitPage()
        {
            cmbFlag.SelectedIndex = 0;
            ClearEditor();
            SetEditorState(false, false);
            LoadDictMainData();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            _editMode = ModeAdd;
            _originalCode = string.Empty;
            ClearEditor();
            SetEditorState(true, true);
            SetDetailEditorState(false);
            dgvDictMainList.ClearSelection();
            dgvDictNextList.DataSource = null;
            txtCode.Focus();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgvDictMainList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请先选择要修改的字典数据！");
                return;
            }

            DataGridViewRow row = dgvDictMainList.SelectedRows[0];
            LoadEditorFromRow(row);
            _editMode = ModeEditMain;
            _originalCode = txtCode.Text.Trim();
            SetEditorState(false, true);
            SetDetailEditorState(true);
            txtName.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            string name = txtName.Text.Trim();
            string flag = cmbFlag.SelectedItem != null && cmbFlag.SelectedItem.ToString() == "启用" ? "1" : "0";
            string bz = txtBz.Text.Trim();

            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("字典代码不能为空！");
                return;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("字典名称不能为空！");
                return;
            }

            try
            {
                bool result;
                if (_editMode == ModeAdd)
                {
                    result = AddDictMain(code, name, flag, bz);
                }
                else if (_editMode == ModeEditMain)
                {
                    result = SaveDictMainWithNext(name, flag, bz);
                }
                else
                {
                    result = SaveDictNextItems(code);
                }

                if (!result)
                {
                    return;
                }

                MessageBox.Show("保存成功！");
                LoadDictMainData(txtQuery.Text.Trim());
                SelectMainRow(code);
                _editMode = ModeEditDetail;
                _originalCode = code;
                SetEditorState(false, false);
                SetDetailEditorState(!string.IsNullOrWhiteSpace(code));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存失败：{ex.Message}");
            }
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            if (dgvDictMainList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请先选择要复制的字典数据！");
                return;
            }

            DataGridViewRow row = dgvDictMainList.SelectedRows[0];
            string sourceCode = row.Cells["CODE"].Value?.ToString() ?? string.Empty;
            string sourceFlag = row.Cells["FLAG"].Value?.ToString() ?? "1";
            string sourceBz = row.Cells["BZ"].Value?.ToString() ?? string.Empty;

            using (DictListCopyDialog dialog = new DictListCopyDialog())
            {
                if (dialog.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                string newCode = dialog.NewDictCode;
                string newName = dialog.NewDictName;

                try
                {
                    if (!CopyDictToNewDict(sourceCode, newCode, newName, sourceFlag, sourceBz))
                    {
                        return;
                    }

                    MessageBox.Show("复制成功！");
                    LoadDictMainData(txtQuery.Text.Trim());
                    SelectMainRow(newCode);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"复制失败：{ex.Message}");
                }
            }
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            LoadDictMainData(txtQuery.Text.Trim());
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txtQuery.Text = string.Empty;
            LoadDictMainData();
        }

        private void dgvDictMainList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDictMainList.SelectedRows.Count <= 0)
            {
                return;
            }

            DataGridViewRow row = dgvDictMainList.SelectedRows[0];
            string code = row.Cells["CODE"].Value?.ToString() ?? string.Empty;
            LoadEditorFromRow(row);
            LoadDictNextData(code);
            _editMode = ModeEditDetail;
            _originalCode = code;
            SetEditorState(false, false);
            SetDetailEditorState(true);
        }

        private void ClearEditor()
        {
            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;
            txtBz.Text = string.Empty;
            cmbFlag.SelectedIndex = 0;
        }

        private void SetEditorState(bool codeEnabled, bool editorEnabled)
        {
            txtCode.Enabled = codeEnabled;
            txtName.Enabled = editorEnabled;
            cmbFlag.Enabled = editorEnabled;
            txtBz.Enabled = editorEnabled;
        }

        private void SetDetailEditorState(bool enabled)
        {
            dgvDictNextList.ReadOnly = !enabled;
            dgvDictNextList.AllowUserToAddRows = enabled;
            dgvDictNextList.AllowUserToDeleteRows = enabled;
        }

        private void LoadEditorFromRow(DataGridViewRow row)
        {
            txtCode.Text = row.Cells["CODE"].Value?.ToString() ?? string.Empty;
            txtName.Text = row.Cells["NAME"].Value?.ToString() ?? string.Empty;
            txtBz.Text = row.Cells["BZ"].Value?.ToString() ?? string.Empty;
            cmbFlag.SelectedIndex = row.Cells["FLAG"].Value?.ToString() == "0" ? 1 : 0;
        }

        private void LoadDictMainData(string keyword = "")
        {
            string sql;
            DataTable dt;

            if (string.IsNullOrWhiteSpace(keyword))
            {
                sql = $@"select code, name, flag, bz
                         from CODE_DICT_MAIN
                         order by code";
                dt = OracleDbHelper.ExecuteQuery(sql);
            }
            else
            {
                sql = $@"select code, name, flag, bz
                         from CODE_DICT_MAIN
                         where instr(upper(nvl(code, '')), upper(:keyword1)) > 0
                            or instr(upper(nvl(name, '')), upper(:keyword2)) > 0
                            or instr(upper(nvl(bz, '')), upper(:keyword3)) > 0
                         order by code";
                dt = OracleDbHelper.ExecuteQuery(
                    sql,
                    new OracleParameter(":keyword1", keyword),
                    new OracleParameter(":keyword2", keyword),
                    new OracleParameter(":keyword3", keyword));
            }

            dgvDictMainList.DataSource = dt;

            if (dgvDictMainList.Rows.Count > 0)
            {
                dgvDictMainList.Rows[0].Selected = true;
                dgvDictMainList.CurrentCell = dgvDictMainList.Rows[0].Cells["CODE"];
                LoadEditorFromRow(dgvDictMainList.Rows[0]);
                _originalCode = txtCode.Text.Trim();
                _editMode = ModeEditDetail;
                LoadDictNextData(_originalCode);
                SetEditorState(false, false);
                SetDetailEditorState(true);
            }
            else
            {
                ClearEditor();
                dgvDictNextList.DataSource = null;
                _originalCode = string.Empty;
                _editMode = ModeAdd;
                SetEditorState(false, false);
                SetDetailEditorState(false);
            }
        }

        private void LoadDictNextData(string mainCode)
        {
            if (string.IsNullOrWhiteSpace(mainCode))
            {
                dgvDictNextList.DataSource = null;
                return;
            }

            string sql = $@"select code, name, bz
                            from CODE_DICT_NEXT
                            where maincode = :maincode
                            order by code";

            dgvDictNextList.DataSource = OracleDbHelper.ExecuteQuery(
                sql,
                new OracleParameter(":maincode", mainCode));
        }

        private bool AddDictMain(string code, string name, string flag, string bz)
        {
            string existsSql = $@"select count(1)
                                  from CODE_DICT_MAIN
                                  where code = :code";

            int existsCount = ToInt(OracleDbHelper.ExecuteScalar(
                existsSql,
                new OracleParameter(":code", code)));

            if (existsCount > 0)
            {
                MessageBox.Show("字典代码已存在，请确认后再保存！");
                return false;
            }

            string insertSql = $@"insert into CODE_DICT_MAIN (code, name, flag, bz)
                                  values (:code, :name, :flag, :bz)";

            int result = OracleDbHelper.ExecuteNonQuery(
                insertSql,
                new OracleParameter(":code", code),
                new OracleParameter(":name", name),
                new OracleParameter(":flag", flag),
                new OracleParameter(":bz", string.IsNullOrWhiteSpace(bz) ? (object)DBNull.Value : bz));

            return result > 0;
        }

        private bool UpdateDictMain(string name, string flag, string bz)
        {
            if (string.IsNullOrWhiteSpace(_originalCode))
            {
                MessageBox.Show("请先选择要修改的字典数据！");
                return false;
            }

            string updateSql = $@"update CODE_DICT_MAIN
                                  set name = :name,
                                      flag = :flag,
                                      bz = :bz
                                  where code = :code";

            int result = OracleDbHelper.ExecuteNonQuery(
                updateSql,
                new OracleParameter(":name", name),
                new OracleParameter(":flag", flag),
                new OracleParameter(":bz", string.IsNullOrWhiteSpace(bz) ? (object)DBNull.Value : bz),
                new OracleParameter(":code", _originalCode));

            return result > 0;
        }

        private bool SaveDictMainWithNext(string name, string flag, string bz)
        {
            if (string.IsNullOrWhiteSpace(_originalCode))
            {
                MessageBox.Show("请先选择要修改的字典数据！");
                return false;
            }

            List<(string Sql, OracleParameter[] Params)> sqlList = new List<(string Sql, OracleParameter[] Params)>
            {
                (
                    $@"update CODE_DICT_MAIN
                       set name = :name,
                           flag = :flag,
                           bz = :bz
                       where code = :code",
                    new[]
                    {
                        new OracleParameter(":name", name),
                        new OracleParameter(":flag", flag),
                        new OracleParameter(":bz", string.IsNullOrWhiteSpace(bz) ? (object)DBNull.Value : bz),
                        new OracleParameter(":code", _originalCode)
                    }
                )
            };

            if (!AppendDictNextSqlList(sqlList, _originalCode))
            {
                return false;
            }

            OracleDbHelper.BatchExecuteNonQuery(sqlList);
            return true;
        }

        private bool SaveDictNextItems(string mainCode)
        {
            if (string.IsNullOrWhiteSpace(mainCode))
            {
                MessageBox.Show("请先选择字典分类后再保存子项！");
                return false;
            }

            List<(string Sql, OracleParameter[] Params)> sqlList = new List<(string Sql, OracleParameter[] Params)>();
            if (!AppendDictNextSqlList(sqlList, mainCode))
            {
                return false;
            }

            OracleDbHelper.BatchExecuteNonQuery(sqlList);
            return true;
        }

        private bool AppendDictNextSqlList(List<(string Sql, OracleParameter[] Params)> sqlList, string mainCode)
        {
            List<(string Code, string Name, string Bz)> items = GetDictNextItems();
            if (items == null)
            {
                return false;
            }

            sqlList.Add((
                $@"delete from CODE_DICT_NEXT
                   where maincode = :maincode",
                new[]
                {
                    new OracleParameter(":maincode", mainCode)
                }));

            foreach ((string Code, string Name, string Bz) item in items)
            {
                sqlList.Add((
                    $@"insert into CODE_DICT_NEXT (maincode, code, name, bz)
                       values (:maincode, :code, :name, :bz)",
                    new[]
                    {
                        new OracleParameter(":maincode", mainCode),
                        new OracleParameter(":code", item.Code),
                        new OracleParameter(":name", item.Name),
                        new OracleParameter(":bz", string.IsNullOrWhiteSpace(item.Bz) ? (object)DBNull.Value : item.Bz)
                    }));
            }

            return true;
        }

        private List<(string Code, string Name, string Bz)> GetDictNextItems()
        {
            Validate();
            dgvDictNextList.CommitEdit(DataGridViewDataErrorContexts.Commit);
            dgvDictNextList.EndEdit();

            List<(string Code, string Name, string Bz)> items = new List<(string Code, string Name, string Bz)>();
            HashSet<string> codes = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (DataGridViewRow row in dgvDictNextList.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                string code = row.Cells["NEXT_CODE"].Value?.ToString().Trim() ?? string.Empty;
                string name = row.Cells["NEXT_NAME"].Value?.ToString().Trim() ?? string.Empty;
                string bz = row.Cells["NEXT_BZ"].Value?.ToString().Trim() ?? string.Empty;

                if (string.IsNullOrWhiteSpace(code)
                    && string.IsNullOrWhiteSpace(name)
                    && string.IsNullOrWhiteSpace(bz))
                {
                    continue;
                }

                if (string.IsNullOrWhiteSpace(code))
                {
                    MessageBox.Show("字典子项值代码不能为空！");
                    return null;
                }

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("字典子项值名称不能为空！");
                    return null;
                }

                if (!codes.Add(code))
                {
                    MessageBox.Show($"字典子项值代码[{code}]重复，请检查！");
                    return null;
                }

                items.Add((code, name, bz));
            }

            return items;
        }

        private bool CopyDictToNewDict(string sourceCode, string newCode, string newName, string flag, string bz)
        {
            if (string.IsNullOrWhiteSpace(sourceCode))
            {
                MessageBox.Show("源字典代码不能为空！");
                return false;
            }

            if (string.IsNullOrWhiteSpace(newCode) || string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("新字典代码和新字典名称不能为空！");
                return false;
            }

            string existsSql = $@"select count(1)
                                  from CODE_DICT_MAIN
                                  where code = :code";

            int existsCount = ToInt(OracleDbHelper.ExecuteScalar(
                existsSql,
                new OracleParameter(":code", newCode)));

            if (existsCount > 0)
            {
                MessageBox.Show("新字典代码已存在，请重新输入！");
                return false;
            }

            List<(string Sql, OracleParameter[] Params)> sqlList = new List<(string Sql, OracleParameter[] Params)>
            {
                (
                    $@"insert into CODE_DICT_MAIN (code, name, flag, bz)
                       values (:code, :name, :flag, :bz)",
                    new[]
                    {
                        new OracleParameter(":code", newCode),
                        new OracleParameter(":name", newName),
                        new OracleParameter(":flag", flag),
                        new OracleParameter(":bz", string.IsNullOrWhiteSpace(bz) ? (object)DBNull.Value : bz)
                    }
                ),
                (
                    $@"insert into CODE_DICT_NEXT (maincode, code, name, bz)
                       select :newMainCode, code, name, bz
                       from CODE_DICT_NEXT
                       where maincode = :sourceCode",
                    new[]
                    {
                        new OracleParameter(":newMainCode", newCode),
                        new OracleParameter(":sourceCode", sourceCode)
                    }
                )
            };

            return OracleDbHelper.BatchExecuteNonQuery(sqlList) > 0;
        }

        private void SelectMainRow(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                return;
            }

            foreach (DataGridViewRow row in dgvDictMainList.Rows)
            {
                string rowCode = row.Cells["CODE"].Value?.ToString() ?? string.Empty;
                if (rowCode != code)
                {
                    continue;
                }

                row.Selected = true;
                dgvDictMainList.CurrentCell = row.Cells["CODE"];
                LoadEditorFromRow(row);
                LoadDictNextData(code);
                break;
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
