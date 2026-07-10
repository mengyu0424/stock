using ClassHelper;
using ClassLibrary;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp.Other;
using WindowsFormsApp.主窗体;

namespace WindowsFormsApp.维护功能
{
    public partial class WpdmInfoSetting : BasePopupForm
    {
        private readonly string _mode;
        private readonly string _wpdmCode;
        private bool _allowPriceEdit = true;
        private bool _loading;

        public string SavedCode { get; private set; }

        public WpdmInfoSetting(string mode, string wpdmCode)
        {
            _mode = mode;
            _wpdmCode = wpdmCode ?? string.Empty;
            InitializeComponent();
            InitPage();
        }

        private void InitPage()
        {
            LoadTypeData();
            cmbFlag.SelectedIndex = 0;

            if (_mode == "Edit")
            {
                Text = "物品代码编辑";
                LoadEditData();
            }
            else
            {
                Text = "物品代码新增";
                LoadAddData();
            }
        }

        private void LoadTypeData()
        {
            DataTable dt = PublicFun.GetDictDataList("WP_TYPE"); 
            cmbType.DataSource = dt;
            cmbType.DisplayMember = "NAME";
            cmbType.ValueMember = "CODE";
        }

        private void LoadAddData()
        {
            _loading = true;
            try
            {
                int seq = PublicFun.GetSeqBySeqName("CODE_WPDM_CODE");
                txtCode.Text = "WP" + seq.ToString("D10");
                txtSxh.Text = seq.ToString();
                txtName.Text = string.Empty;
                txtPym.Text = string.Empty;
                txtGg.Text = string.Empty;
                txtJhj.Text = string.Empty;
                txtLsj.Text = string.Empty;
                txtBz.Text = string.Empty;
                cmbFlag.SelectedIndex = 0;
                if (cmbType.Items.Count > 0)
                {
                    cmbType.SelectedIndex = 0;
                }
            }
            finally
            {
                _loading = false;
            }
        }

        private void LoadEditData()
        {
            if (string.IsNullOrWhiteSpace(_wpdmCode))
            {
                MessageBox.Show("缺少需要编辑的物品代码。");
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            string sql = @"select code, name, pym, flag, sxh, bz, type, gg, jhj, lsj
                           from code_wpdm
                           where code = :code";

            DataTable dt = OracleDbHelper.ExecuteQuery(
                sql,
                new OracleParameter(":code", _wpdmCode));

            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("未找到对应的物品代码数据，可能已被删除。");
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            _loading = true;
            try
            {
                DataRow row = dt.Rows[0];
                txtCode.Text = row["CODE"] == DBNull.Value ? string.Empty : row["CODE"].ToString();
                txtName.Text = row["NAME"] == DBNull.Value ? string.Empty : row["NAME"].ToString();
                txtPym.Text = row["PYM"] == DBNull.Value ? string.Empty : row["PYM"].ToString();
                txtSxh.Text = row["SXH"] == DBNull.Value ? string.Empty : row["SXH"].ToString();
                txtGg.Text = row["GG"] == DBNull.Value ? string.Empty : row["GG"].ToString();
                txtJhj.Text = row["JHJ"] == DBNull.Value ? string.Empty : Convert.ToDecimal(row["JHJ"]).ToString("0.####");
                txtLsj.Text = row["LSJ"] == DBNull.Value ? string.Empty : Convert.ToDecimal(row["LSJ"]).ToString("0.####");
                txtBz.Text = row["BZ"] == DBNull.Value ? string.Empty : row["BZ"].ToString();
                cmbFlag.SelectedIndex = row["FLAG"] != DBNull.Value && row["FLAG"].ToString() == "0" ? 1 : 0;

                string type = row["TYPE"] == DBNull.Value ? string.Empty : row["TYPE"].ToString();
                if (!string.IsNullOrWhiteSpace(type))
                {
                    cmbType.SelectedValue = type;
                }

                //_allowPriceEdit = WpdmSettingHelper.CanModifyPrice(txtCode.Text.Trim());留的口子 如果有业务数据 则不允许修改价格
                txtJhj.Enabled = _allowPriceEdit;
                txtLsj.Enabled = _allowPriceEdit;
            }
            finally
            {
                _loading = false;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (_loading)
            {
                return;
            }

            txtPym.Text = PublicFun.GetPinyin(txtName.Text.Trim());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            string name = txtName.Text.Trim();
            string pym = txtPym.Text.Trim();
            string flag = cmbFlag.SelectedItem != null && cmbFlag.SelectedItem.ToString() == "禁用" ? "0" : "1";
            string type = cmbType.SelectedValue == null ? string.Empty : cmbType.SelectedValue.ToString();
            string gg = txtGg.Text.Trim();
            string bz = txtBz.Text.Trim();

            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("物品代码不能为空！");
                txtCode.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("物品名称不能为空！");
                txtName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(type))
            {
                MessageBox.Show("请选择商品类别！");
                cmbType.Focus();
                return;
            }

            int sxh;
            if (!int.TryParse(txtSxh.Text.Trim(), out sxh))
            {
                MessageBox.Show("顺序号必须是整数！");
                txtSxh.Focus();
                return;
            }

            decimal jhj;
            decimal lsj;
            bool hasJhj = TryGetDecimal(txtJhj.Text.Trim(), out jhj, "默认进货价");
            if (txtJhj.Text.Trim().Length > 0 && !hasJhj)
            {
                txtJhj.Focus();
                return;
            }

            bool hasLsj = TryGetDecimal(txtLsj.Text.Trim(), out lsj, "默认零售价");
            if (txtLsj.Text.Trim().Length > 0 && !hasLsj)
            {
                txtLsj.Focus();
                return;
            }

            try
            {
                bool result = _mode == "Edit"
                    ? UpdateWpdm(code, name, pym, flag, type, gg, sxh, txtJhj.Text.Trim(), txtLsj.Text.Trim(), bz)
                    : AddWpdm(code, name, pym, flag, type, gg, sxh, txtJhj.Text.Trim(), txtLsj.Text.Trim(), bz);

                if (!result)
                {
                    return;
                }

                SavedCode = code;
                MessageBox.Show("保存成功！");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存失败：{ex.Message}");
            }
        }

        private bool AddWpdm(string code, string name, string pym, string flag, string type, string gg, int sxh, string jhjText, string lsjText, string bz)
        {
            string existsSql = @"select count(1)
                                 from code_wpdm
                                 where code = :code";

            int existsCount = int.Parse(OracleDbHelper.ExecuteScalar(
                existsSql,
                new OracleParameter(":code", code)).ToString());

            if (existsCount > 0)
            {
                MessageBox.Show("当前物品代码已存在，请刷新后重试。");
                return false;
            }

            string insertSql = @"insert into code_wpdm
                                 (code, name, pym, flag, sxh, bz, type, gg, jhj, lsj, xgr, xgsj)
                                 values
                                 (:code, :name, :pym, :flag, :sxh, :bz, :type, :gg, :jhj, :lsj, :xgr, sysdate)";

            int count = OracleDbHelper.ExecuteNonQuery(
                insertSql,
                new OracleParameter(":code", code),
                new OracleParameter(":name", name),
                new OracleParameter(":pym", string.IsNullOrWhiteSpace(pym) ? (object)DBNull.Value : pym),
                new OracleParameter(":flag", flag),
                new OracleParameter(":sxh", sxh),
                new OracleParameter(":bz", string.IsNullOrWhiteSpace(bz) ? (object)DBNull.Value : bz),
                new OracleParameter(":type", type),
                new OracleParameter(":gg", string.IsNullOrWhiteSpace(gg) ? (object)DBNull.Value : gg),
                new OracleParameter(":jhj", GetNullableDecimalValue(jhjText)),
                new OracleParameter(":lsj", GetNullableDecimalValue(lsjText)),
                new OracleParameter(":xgr", GlobalInfo.userInfo.ID));

            return count > 0;
        }

        private bool UpdateWpdm(string code, string name, string pym, string flag, string type, string gg, int sxh, string jhjText, string lsjText, string bz)
        {
            if (string.IsNullOrWhiteSpace(_wpdmCode))
            {
                MessageBox.Show("缺少需要修改的物品代码。");
                return false;
            }

            string sql = @"update code_wpdm
                           set name = :name,
                               pym = :pym,
                               flag = :flag,
                               sxh = :sxh,
                               bz = :bz,
                               type = :type,
                               gg = :gg,
                               xgr = :xgr,
                               xgsj = sysdate";

            if (_allowPriceEdit)
            {
                sql += ", jhj = :jhj, lsj = :lsj";
            }

            sql += " where code = :code";

            System.Collections.Generic.List<OracleParameter> parameters = new System.Collections.Generic.List<OracleParameter>
            {
                new OracleParameter(":name", name),
                new OracleParameter(":pym", string.IsNullOrWhiteSpace(pym) ? (object)DBNull.Value : pym),
                new OracleParameter(":flag", flag),
                new OracleParameter(":sxh", sxh),
                new OracleParameter(":bz", string.IsNullOrWhiteSpace(bz) ? (object)DBNull.Value : bz),
                new OracleParameter(":type", type),
                new OracleParameter(":gg", string.IsNullOrWhiteSpace(gg) ? (object)DBNull.Value : gg),
                new OracleParameter(":xgr", GlobalInfo.userInfo.ID)
            };

            if (_allowPriceEdit)
            {
                parameters.Add(new OracleParameter(":jhj", GetNullableDecimalValue(jhjText)));
                parameters.Add(new OracleParameter(":lsj", GetNullableDecimalValue(lsjText)));
            }

            parameters.Add(new OracleParameter(":code", code));

            int count = OracleDbHelper.ExecuteNonQuery(sql, parameters.ToArray());
            return count > 0;
        }

        private bool TryGetDecimal(string text, out decimal value, string fieldName)
        {
            value = 0;
            if (string.IsNullOrWhiteSpace(text))
            {
                return true;
            }

            if (decimal.TryParse(text, out value))
            {
                return true;
            }

            MessageBox.Show($"{fieldName}必须是有效数字！");
            return false;
        }

        private object GetNullableDecimalValue(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return DBNull.Value;
            }

            decimal value;
            return decimal.TryParse(text, out value) ? (object)value : DBNull.Value;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
