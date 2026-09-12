using System;
using ClassHelper;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp.主窗体;

namespace WindowsFormsApp.库房业务
{
    public partial class InStorage : BaseForm
    {
        private DataTable _detailData;
        private DataTable _wpdmData;
        private bool _loading;

        public DataTable SavedInStorageDetailData { get; private set; }

        public InStorage()
        {
            InitializeComponent();
            txtPh.Leave += txtBatchOrLot_Leave;
            txtPc.Leave += txtBatchOrLot_Leave;
            txtJhj.Leave += txtNumber_Leave;
            txtLsj.Leave += txtNumber_Leave;
            txtSl.Leave += txtNumber_Leave;
            InitPage();
        }

        private void InitPage()
        {
            InitDetailData();
            LoadWpdmData();
            ClearEditInfo();
        }

        private void InitDetailData()
        {
            _detailData = new DataTable();
            _detailData.Columns.Add("CODE", typeof(string));
            _detailData.Columns.Add("NAME", typeof(string));
            _detailData.Columns.Add("GG", typeof(string));
            _detailData.Columns.Add("PH", typeof(string));
            _detailData.Columns.Add("PC", typeof(string));
            _detailData.Columns.Add("JHJ", typeof(decimal));
            _detailData.Columns.Add("LSJ", typeof(decimal));
            _detailData.Columns.Add("SL", typeof(decimal));
            _detailData.Columns.Add("JHJE", typeof(decimal));
            _detailData.Columns.Add("LSJE", typeof(decimal));

            dgvInStorageList.DataSource = _detailData;
        }

        private void LoadWpdmData()
        {
            try
            {
                string sql = @"select a.code,
                                       a.name,
                                       nvl(a.gg, '') as gg,
                                       nvl(a.jhj, 0) as jhj,
                                       nvl(a.lsj, 0) as lsj
                                from code_wpdm a
                                where nvl(a.flag, '1') = '1'
                                order by nvl(a.sxh, 0), a.code";

                _loading = true;
                try
                {
                    _wpdmData = OracleDbHelper.ExecuteQuery(sql);
                    cmbWpdmCode.ComboListCode = "CODE,NAME,GG";
                    cmbWpdmCode.ComboListTitle = "物品代码,物品名称,规格";
                    cmbWpdmCode.DisplayMember = "NAME";
                    cmbWpdmCode.ValueMember = "CODE";
                    cmbWpdmCode.ManyCheck = false;
                    cmbWpdmCode.DataSource = _wpdmData;
                    cmbWpdmCode.ClearSelection();
                }
                finally
                {
                    _loading = false;
                }
            }
            catch (Exception ex)
            {
                _wpdmData = null;
                cmbWpdmCode.DataSource = null;
                MessageBox.Show(
                    $"物品代码加载失败：{ex.Message}",
                    "提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void AddOrUpdateCurrentItem(bool forceAdd)
        {
            DataRow wpdmRow = GetCurrentWpdmRow();
            if (wpdmRow == null)
            {
                MessageBox.Show("请先选择物品代码！");
                cmbWpdmCode.Focus();
                return;
            }

            string code = GetRowString(wpdmRow, "CODE");
            DataRow detailRow = GetSelectedDetailRow();
            bool previousLoading = _loading;
            _loading = true;
            try
            {
                if (forceAdd || detailRow == null || !string.Equals(GetRowString(detailRow, "CODE"), code, StringComparison.OrdinalIgnoreCase))
                {
                    detailRow = _detailData.NewRow();
                    _detailData.Rows.Add(detailRow);
                }

                FillDetailRowByWpdm(detailRow, wpdmRow);
                FillEditorByDetailRow(detailRow);
                SelectDetailRow(detailRow);
            }
            finally
            {
                _loading = previousLoading;
            }
        }

        private void FillDetailRowByWpdm(DataRow detailRow, DataRow wpdmRow)
        {
            string code = GetRowString(wpdmRow, "CODE");
            string lotNumber = txtPh.Text.Trim();

            detailRow["CODE"] = code;
            detailRow["NAME"] = GetRowString(wpdmRow, "NAME");
            detailRow["GG"] = GetRowString(wpdmRow, "GG");
            detailRow["PH"] = lotNumber;
            detailRow["PC"] = GetValidBatchNumber(detailRow, code, lotNumber, txtPc.Text);
            detailRow["JHJ"] = GetRowDecimal(wpdmRow, "JHJ");
            detailRow["LSJ"] = GetRowDecimal(wpdmRow, "LSJ");
            detailRow["SL"] = GetTextDecimal(txtSl.Text.Trim(), 0);
            RefreshAmount(detailRow);
        }

        private void FillEditorByDetailRow(DataRow detailRow)
        {
            bool previousLoading = _loading;
            _loading = true;
            try
            {
                cmbWpdmCode.SetSelectedValue(GetRowString(detailRow, "CODE"));
                txtGg.Text = GetRowString(detailRow, "GG");
                txtPh.Text = GetRowString(detailRow, "PH");
                txtPc.Text = GetRowString(detailRow, "PC");
                txtJhj.Text = GetRowDecimal(detailRow, "JHJ").ToString("0.####");
                txtLsj.Text = GetRowDecimal(detailRow, "LSJ").ToString("0.####");
                txtSl.Text = GetRowDecimal(detailRow, "SL").ToString("0.####");
            }
            finally
            {
                _loading = previousLoading;
            }
        }

        private void ClearEditInfo()
        {
            bool previousLoading = _loading;
            _loading = true;
            try
            {
                cmbWpdmCode.ClearSelection();
                txtGg.Text = string.Empty;
                txtPh.Text = string.Empty;
                txtPc.Text = string.Empty;
                txtJhj.Text = string.Empty;
                txtLsj.Text = string.Empty;
                txtSl.Text = string.Empty;
            }
            finally
            {
                _loading = previousLoading;
            }
        }

        private void ClearPage()
        {
            if (!CanClearPage())
            {
                return;
            }

            _detailData.Rows.Clear();
            ClearEditInfo();
            dgvInStorageList.ClearSelection();
            cmbWpdmCode.Focus();
        }

        private bool CanClearPage()
        {
            if (_detailData.Rows.Count <= 0
                && string.IsNullOrWhiteSpace(cmbWpdmCode.Text)
                && string.IsNullOrWhiteSpace(txtPh.Text)
                && string.IsNullOrWhiteSpace(txtPc.Text)
                && string.IsNullOrWhiteSpace(txtJhj.Text)
                && string.IsNullOrWhiteSpace(txtLsj.Text)
                && string.IsNullOrWhiteSpace(txtSl.Text))
            {
                return true;
            }

            DialogResult result = MessageBox.Show(
                "确认清空当前入库单据吗？",
                "提示",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return result == DialogResult.Yes;
        }

        private void DeleteSelectedItem()
        {
            DataRow row = GetSelectedDetailRow();
            if (row == null)
            {
                MessageBox.Show("请先选择需要删除的物品！");
                return;
            }

            row.Delete();
            ClearEditInfo();
            dgvInStorageList.ClearSelection();
        }

        private bool ValidateDetailData()
        {
            if (_detailData.Rows.Count <= 0)
            {
                MessageBox.Show("请先新增入库物品！");
                cmbWpdmCode.Focus();
                return false;
            }

            foreach (DataRow row in _detailData.Rows)
            {
                if (row.RowState == DataRowState.Deleted)
                {
                    continue;
                }

                string code = GetRowString(row, "CODE");
                if (string.IsNullOrWhiteSpace(code))
                {
                    MessageBox.Show("明细中存在物品代码为空的数据，请检查！");
                    return false;
                }

                string lotNumber = GetRowString(row, "PH");
                string batchNumber = GetRowString(row, "PC");
                if (!InStorageValidation.IsPositiveInteger(batchNumber))
                {
                    MessageBox.Show($"物品[{code}]的批次必须是正整数！");
                    return false;
                }

                if (InStorageValidation.HasDuplicateBatchNumber(_detailData, code, lotNumber, batchNumber, row))
                {
                    MessageBox.Show($"物品[{code}]、批号[{lotNumber}]的批次[{batchNumber}]重复！");
                    return false;
                }

                if (!IsRowPositivePrice(row, "JHJ"))
                {
                    MessageBox.Show($"物品[{code}]的进货价必须是大于0且最多4位小数！");
                    return false;
                }

                if (!IsRowPositivePrice(row, "LSJ"))
                {
                    MessageBox.Show($"物品[{code}]的零售价必须是大于0且最多4位小数！");
                    return false;
                }

                if (!InStorageValidation.IsPositiveInteger(GetRowString(row, "SL")))
                {
                    MessageBox.Show($"物品[{code}]的数量必须是正整数！");
                    return false;
                }
            }

            return true;
        }

        private DataTable GetInStorageDetailData()
        {
            DataTable dt = _detailData.Copy();
            dt.AcceptChanges();
            return dt;
        }

        private void SaveInStorageData(DataTable dt)
        {
            // 后续在这里补充入库主表、明细表、库存记录的数据库保存逻辑。
        }

        private bool RefreshCurrentDetailRow(bool showMessage)
        {
            if (_loading)
            {
                return true;
            }

            DataRow row = GetSelectedDetailRow();
            if (row == null)
            {
                return true;
            }

            if (showMessage && !NormalizeCurrentBatchNumber(true))
            {
                return false;
            }

            string lotNumber = txtPh.Text.Trim();
            string batchNumber = txtPc.Text.Trim();
            row["PH"] = lotNumber;
            row["PC"] = batchNumber;

            decimal jhj;
            if (!TryGetPositivePrice(txtJhj.Text.Trim(), out jhj, "进货价", showMessage))
            {
                return false;
            }

            decimal lsj;
            if (!TryGetPositivePrice(txtLsj.Text.Trim(), out lsj, "零售价", showMessage))
            {
                return false;
            }

            decimal sl;
            if (!TryGetPositiveInteger(txtSl.Text.Trim(), out sl, "数量", showMessage))
            {
                return false;
            }

            row["JHJ"] = jhj;
            row["LSJ"] = lsj;
            row["SL"] = sl;
            RefreshAmount(row);
            return true;
        }

        private void RefreshAmount(DataRow row)
        {
            decimal jhj = GetRowDecimal(row, "JHJ");
            decimal lsj = GetRowDecimal(row, "LSJ");
            decimal sl = GetRowDecimal(row, "SL");
            row["JHJE"] = jhj * sl;
            row["LSJE"] = lsj * sl;
        }

        private DataRow GetCurrentWpdmRow()
        {
            if (_wpdmData == null || _wpdmData.Rows.Count <= 0)
            {
                return null;
            }

            string code = cmbWpdmCode.SelectedValue;
            if (string.IsNullOrWhiteSpace(code))
            {
                return null;
            }

            DataRow[] rows = _wpdmData.Select($"CODE = '{code.Replace("'", "''")}'");
            return rows.Length > 0 ? rows[0] : null;
        }

        private DataRow GetSelectedDetailRow()
        {
            if (dgvInStorageList.SelectedRows.Count <= 0)
            {
                return null;
            }

            DataRowView rowView = dgvInStorageList.SelectedRows[0].DataBoundItem as DataRowView;
            return rowView == null ? null : rowView.Row;
        }

        private void SelectDetailRow(DataRow detailRow)
        {
            foreach (DataGridViewRow row in dgvInStorageList.Rows)
            {
                DataRowView rowView = row.DataBoundItem as DataRowView;
                if (rowView == null || rowView.Row != detailRow)
                {
                    continue;
                }

                row.Selected = true;
                dgvInStorageList.CurrentCell = row.Cells["CODE"];
                return;
            }
        }

        private static string GetRowString(DataRow row, string columnName)
        {
            return row.Table.Columns.Contains(columnName) && row[columnName] != DBNull.Value
                ? row[columnName].ToString()
                : string.Empty;
        }

        private static decimal GetRowDecimal(DataRow row, string columnName)
        {
            if (!row.Table.Columns.Contains(columnName) || row[columnName] == DBNull.Value)
            {
                return 0;
            }

            decimal value;
            return decimal.TryParse(row[columnName].ToString(), out value) ? value : 0;
        }

        private static decimal GetTextDecimal(string text, decimal defaultValue)
        {
            decimal value;
            return decimal.TryParse(text, out value) ? value : defaultValue;
        }

        private string GetValidBatchNumber(DataRow row, string code, string lotNumber, string batchNumber)
        {
            string text = (batchNumber ?? string.Empty).Trim();
            string nextBatchNumber = InStorageValidation.GetNextBatchNumber(_detailData, code, lotNumber, row);
            int currentBatchNumber;
            int minimumBatchNumber;

            if (string.IsNullOrEmpty(nextBatchNumber)
                || !InStorageValidation.IsPositiveInteger(text)
                || InStorageValidation.HasDuplicateBatchNumber(_detailData, code, lotNumber, text, row)
                || !int.TryParse(text, out currentBatchNumber)
                || !int.TryParse(nextBatchNumber, out minimumBatchNumber)
                || currentBatchNumber < minimumBatchNumber)
            {
                return nextBatchNumber;
            }

            return text;
        }

        private bool NormalizeCurrentBatchNumber(bool showMessage)
        {
            DataRow row = GetSelectedDetailRow();
            if (row == null)
            {
                return true;
            }

            string code = GetRowString(row, "CODE");
            if (string.IsNullOrWhiteSpace(code))
            {
                return false;
            }

            string batchNumber = txtPc.Text.Trim();
            string validBatchNumber = GetValidBatchNumber(row, code, txtPh.Text.Trim(), batchNumber);
            if (string.IsNullOrEmpty(validBatchNumber))
            {
                if (showMessage)
                {
                    MessageBox.Show($"物品[{code}]的批次已达到最大值，无法自动生成下一批次！");
                }
                return false;
            }

            if (!string.Equals(batchNumber, validBatchNumber, StringComparison.Ordinal))
            {
                bool previousLoading = _loading;
                _loading = true;
                try
                {
                    txtPc.Text = validBatchNumber;
                }
                finally
                {
                    _loading = previousLoading;
                }

                if (showMessage && !string.IsNullOrWhiteSpace(batchNumber))
                {
                    MessageBox.Show($"物品[{code}]、批号[{txtPh.Text.Trim()}]的批次必须唯一且递增，已自动调整为[{validBatchNumber}]！");
                }
            }

            row["PH"] = txtPh.Text.Trim();
            row["PC"] = validBatchNumber;
            return true;
        }

        private static bool TryGetPositivePrice(string text, out decimal value, string fieldName, bool showMessage)
        {
            if (InStorageValidation.IsPositivePrice(text)
                && decimal.TryParse(text, out value))
            {
                return true;
            }

            value = 0;
            if (showMessage)
            {
                MessageBox.Show($"{fieldName}必须是大于0且最多4位小数！");
            }
            return false;
        }

        private static bool TryGetPositiveInteger(string text, out decimal value, string fieldName, bool showMessage)
        {
            int integerValue;
            if (InStorageValidation.IsPositiveInteger(text)
                && int.TryParse(text, out integerValue))
            {
                value = integerValue;
                return true;
            }

            value = 0;
            if (showMessage)
            {
                MessageBox.Show($"{fieldName}必须是正整数！");
            }
            return false;
        }

        private static bool IsRowPositivePrice(DataRow row, string columnName)
        {
            decimal value = GetRowDecimal(row, columnName);
            int scale = (decimal.GetBits(value)[3] >> 16) & 0x7f;
            return value > 0 && scale <= 4;
        }

        private void btnNewBill_Click(object sender, EventArgs e)
        {
            ClearPage();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (GetSelectedDetailRow() != null && !RefreshCurrentDetailRow(true))
            {
                return;
            }

            AddOrUpdateCurrentItem(true);
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedItem();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearPage();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!RefreshCurrentDetailRow(true))
            {
                return;
            }

            if (!ValidateDetailData())
            {
                return;
            }

            SavedInStorageDetailData = GetInStorageDetailData();
            SaveInStorageData(SavedInStorageDetailData);
            MessageBox.Show("入库单据数据已整理完成，请继续补充数据库保存逻辑。");
        }

        private void cmbWpdmCode_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_loading)
            {
                return;
            }

            AddOrUpdateCurrentItem(false);
        }

        private void dgvInStorageList_SelectionChanged(object sender, EventArgs e)
        {
            if (_loading)
            {
                return;
            }

            DataRow row = GetSelectedDetailRow();
            if (row == null)
            {
                return;
            }

            FillEditorByDetailRow(row);
        }

        private void txtDetail_TextChanged(object sender, EventArgs e)
        {
            RefreshCurrentDetailRow(false);
        }

        private void txtBatchOrLot_Leave(object sender, EventArgs e)
        {
            NormalizeCurrentBatchNumber(true);
        }

        private void txtNumber_Leave(object sender, EventArgs e)
        {
            RefreshCurrentDetailRow(true);
        }
    }
}
