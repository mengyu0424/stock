using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

[ToolboxBitmap(typeof(ComboBox))]
public class MyComboList : UserControl
{
    private readonly TextBox txtInput;
    private readonly Button btnDrop;
    private readonly ComboListPopupForm popupForm;
    private readonly List<ComboListColumn> comboColumns = new List<ComboListColumn>();
    private readonly HashSet<string> selectedKeys = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

    private DataTable sourceTable;
    private DataTable displayTable;
    private bool manyCheck;
    private string comboListCode = string.Empty;
    private string comboListTitle = string.Empty;
    private string displayMember = string.Empty;
    private string valueMember = string.Empty;
    private bool suppressTextChange;
    private bool popupCommitted;
    private string snapshotText = string.Empty;
    private HashSet<string> snapshotKeys = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

    public event EventHandler SelectedValueChanged;

    public MyComboList()
    {
        SetStyle(ControlStyles.UserPaint
                 | ControlStyles.AllPaintingInWmPaint
                 | ControlStyles.OptimizedDoubleBuffer
                 | ControlStyles.ResizeRedraw, true);

        BackColor = Color.White;
        ForeColor = Color.FromArgb(40, 40, 40);
        Height = 34;
        TabStop = false;

        txtInput = new TextBox();
        txtInput.BorderStyle = BorderStyle.None;
        txtInput.Location = new Point(8, 7);
        txtInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtInput.TextChanged += txtInput_TextChanged;
        txtInput.KeyDown += txtInput_KeyDown;
        txtInput.Leave += txtInput_Leave;
        txtInput.Enter += txtInput_Enter;

        btnDrop = new Button();
        btnDrop.FlatStyle = FlatStyle.Flat;
        btnDrop.FlatAppearance.BorderSize = 0;
        btnDrop.BackColor = Color.White;
        btnDrop.ForeColor = Color.FromArgb(45, 139, 243);
        btnDrop.Text = "▼";
        btnDrop.Font = new Font("微软雅黑", 8F);
        btnDrop.Cursor = Cursors.Hand;
        btnDrop.TabStop = false;
        btnDrop.Click += btnDrop_Click;
        btnDrop.MouseEnter += btnDrop_MouseEnter;
        btnDrop.MouseLeave += btnDrop_MouseLeave;

        popupForm = new ComboListPopupForm();
        popupForm.Grid.CellClick += Grid_CellClick;
        popupForm.Grid.CellDoubleClick += Grid_CellDoubleClick;
        popupForm.BtnOk.Click += BtnOk_Click;
        popupForm.BtnCancel.Click += BtnCancel_Click;

        Controls.Add(btnDrop);
        Controls.Add(txtInput);

        Font = new Font("微软雅黑", 12F);
        txtInput.Font = Font;
        btnDrop.Font = new Font("微软雅黑", 8F);
        LayoutInnerControls();
        ApplyMode();
    }

    [DefaultValue(false)]
    [Description("是否允许多选")]
    public bool ManyCheck
    {
        get { return manyCheck; }
        set
        {
            if (manyCheck == value)
            {
                return;
            }

            manyCheck = value;
            if (!manyCheck && selectedKeys.Count > 1)
            {
                string firstKey = string.Empty;
                foreach (string key in selectedKeys)
                {
                    firstKey = key;
                    break;
                }

                selectedKeys.Clear();
                if (!string.IsNullOrWhiteSpace(firstKey))
                {
                    selectedKeys.Add(firstKey);
                }
            }

            ApplyMode();
            RefreshDisplayData();
        }
    }

    [DefaultValue("")]
    [Description("下拉列表字段名，多个字段用英文逗号分隔，例如 code,name,type")]
    public string ComboListCode
    {
        get { return comboListCode; }
        set
        {
            comboListCode = value ?? string.Empty;
            BuildColumnDefinitions();
            RefreshDisplayData();
        }
    }

    [DefaultValue("")]
    [Description("下拉列表标题，多个标题用英文逗号分隔，例如 代码,名称,类型")]
    public string ComboListTitle
    {
        get { return comboListTitle; }
        set
        {
            comboListTitle = value ?? string.Empty;
            BuildColumnDefinitions();
            RefreshDisplayData();
        }
    }

    [DefaultValue("")]
    [Description("选择后在输入框中显示的字段名，例如 NAME")]
    public string DisplayMember
    {
        get { return displayMember; }
        set
        {
            displayMember = value ?? string.Empty;
            RefreshSelectedText();
            RefreshDisplayData();
        }
    }

    [DefaultValue("")]
    [Description("选择后获取值的字段名，例如 CODE")]
    public string ValueMember
    {
        get { return valueMember; }
        set
        {
            string member = value ?? string.Empty;
            if (string.Equals(valueMember, member, StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            valueMember = member;
            ClearSelection();
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new string Text
    {
        get { return txtInput.Text; }
        set { SetInputText(value, false); }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public object DataSource
    {
        get { return sourceTable; }
        set
        {
            if (value == null)
            {
                sourceTable = null;
                selectedKeys.Clear();
                SetInputText(string.Empty, true);
                RefreshDisplayData();
                return;
            }

            if (value is DataTable dt)
            {
                sourceTable = dt;
            }
            else if (value is DataView dv)
            {
                sourceTable = dv.ToTable();
            }
            else
            {
                throw new NotSupportedException("MyComboList 目前仅支持 DataTable 或 DataView 作为数据源。");
            }

            RefreshDisplayData();
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string SelectedValue
    {
        get
        {
            foreach (string key in selectedKeys)
            {
                return key;
            }

            return string.Empty;
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string SelectedValues
    {
        get { return string.Join(",", GetSelectedKeysInDisplayOrder()); }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string SelectedText
    {
        get { return txtInput.Text; }
    }

    public void ClearSelection()
    {
        selectedKeys.Clear();
        popupCommitted = true;
        snapshotText = string.Empty;
        snapshotKeys = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        SetInputText(string.Empty, true);
        RefreshDisplayData();
    }

    public void SetSelectedValue(string value)
    {
        if (sourceTable == null || comboColumns.Count <= 0)
        {
            ClearSelection();
            return;
        }

        string key = value ?? string.Empty;
        if (string.IsNullOrWhiteSpace(key))
        {
            ClearSelection();
            return;
        }

        DataRow sourceRow = FindSourceRow(key);
        if (sourceRow == null)
        {
            ClearSelection();
            return;
        }

        selectedKeys.Clear();
        selectedKeys.Add(GetRowKey(sourceRow));
        popupCommitted = true;
        SetInputText(BuildDisplayTextFromSourceRow(sourceRow), true);
        RefreshDisplayData();
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        if (txtInput == null || btnDrop == null || popupForm == null)
        {
            return;
        }

        LayoutInnerControls();
        UpdatePopupBounds();
    }

    protected override void OnFontChanged(EventArgs e)
    {
        base.OnFontChanged(e);
        if (txtInput == null || btnDrop == null)
        {
            return;
        }

        txtInput.Font = Font;
        btnDrop.Font = new Font("微软雅黑", 8F);
        LayoutInnerControls();
    }

    protected override void OnEnabledChanged(EventArgs e)
    {
        base.OnEnabledChanged(e);
        if (txtInput == null || btnDrop == null)
        {
            return;
        }

        txtInput.Enabled = Enabled;
        btnDrop.Enabled = Enabled;
        if (!Enabled)
        {
            HidePopup(true);
        }

        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        if (txtInput == null || btnDrop == null || popupForm == null)
        {
            return;
        }

        Color borderColor = GetBorderColor();
        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        using (Pen pen = new Pen(borderColor, 1))
        {
            e.Graphics.DrawRoundedRectangle(pen, 0, 0, Width - 1, Height - 1, 6);
        }
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (popupForm != null)
            {
                popupForm.Dispose();
            }
        }

        base.Dispose(disposing);
    }

    private void txtInput_Enter(object sender, EventArgs e)
    {
        if (Enabled)
        {
            ShowPopup();
        }
    }

    private void txtInput_Leave(object sender, EventArgs e)
    {
        if (popupForm.Visible)
        {
            HidePopup(true);
        }
    }

    private void txtInput_TextChanged(object sender, EventArgs e)
    {
        if (suppressTextChange)
        {
            return;
        }

        if (!Enabled)
        {
            return;
        }

        ShowPopup();
        RefreshDisplayData();
    }

    private void txtInput_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Down)
        {
            ShowPopup();
            FocusFirstVisibleRow();
            e.Handled = true;
            e.SuppressKeyPress = true;
            return;
        }

        if (e.KeyCode == Keys.Enter)
        {
            if (popupForm.Visible)
            {
                if (manyCheck)
                {
                    CommitCheckedRows();
                }
                else
                {
                    CommitCurrentRow();
                }
            }
            else if (!manyCheck && displayTable != null && displayTable.Rows.Count > 0)
            {
                CommitRowByIndex(0);
            }

            e.Handled = true;
            e.SuppressKeyPress = true;
            return;
        }

        if (e.KeyCode == Keys.Escape)
        {
            if (popupForm.Visible)
            {
                HidePopup(true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }

    private void btnDrop_Click(object sender, EventArgs e)
    {
        if (popupForm.Visible)
        {
            HidePopup(true);
            return;
        }

        ShowPopup();
    }

    private void btnDrop_MouseEnter(object sender, EventArgs e)
    {
        btnDrop.BackColor = Color.FromArgb(245, 245, 245);
    }

    private void btnDrop_MouseLeave(object sender, EventArgs e)
    {
        btnDrop.BackColor = Color.White;
    }

    private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || displayTable == null || e.RowIndex >= displayTable.Rows.Count)
        {
            return;
        }

        if (manyCheck)
        {
            ToggleRowCheck(e.RowIndex);
            return;
        }

        CommitRowByIndex(e.RowIndex);
    }

    private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || displayTable == null || e.RowIndex >= displayTable.Rows.Count)
        {
            return;
        }

        if (!manyCheck)
        {
            CommitRowByIndex(e.RowIndex);
        }
    }

    private void BtnOk_Click(object sender, EventArgs e)
    {
        CommitCheckedRows();
    }

    private void BtnCancel_Click(object sender, EventArgs e)
    {
        HidePopup(true);
    }

    private void LayoutInnerControls()
    {
        if (txtInput == null || btnDrop == null)
        {
            return;
        }

        int buttonWidth = 28;
        int padding = 6;
        int editorHeight = Math.Max(22, Height - 12);

        txtInput.Location = new Point(padding, (Height - editorHeight) / 2);
        txtInput.Size = new Size(Math.Max(10, Width - buttonWidth - padding * 2), editorHeight);

        btnDrop.Location = new Point(Math.Max(Width - buttonWidth - 1, padding), 1);
        btnDrop.Size = new Size(buttonWidth, Math.Max(Height - 2, 24));
    }

    private Color GetBorderColor()
    {
        if (txtInput == null || btnDrop == null || popupForm == null)
        {
            return Color.FromArgb(200, 200, 200);
        }

        if (!Enabled)
        {
            return Color.FromArgb(200, 200, 200);
        }

        if (popupForm.Visible || txtInput.Focused)
        {
            return Color.FromArgb(45, 139, 243);
        }

        if (RectangleToScreen(ClientRectangle).Contains(MousePosition))
        {
            return Color.FromArgb(66, 158, 255);
        }

        return Color.FromArgb(200, 200, 200);
    }

    private void ApplyMode()
    {
        if (popupForm == null)
        {
            return;
        }

        popupForm.SetManyCheck(manyCheck);
        if (comboColumns.Count > 0)
        {
            popupForm.BuildColumns(comboColumns, manyCheck);
        }
    }

    private void BuildColumnDefinitions()
    {
        if (popupForm == null)
        {
            return;
        }

        comboColumns.Clear();

        string[] codeParts = SplitList(comboListCode);
        string[] titleParts = SplitList(comboListTitle);
        int count = Math.Max(codeParts.Length, titleParts.Length);

        for (int i = 0; i < count; i++)
        {
            string fieldName = i < codeParts.Length ? codeParts[i] : string.Empty;
            string headerText = i < titleParts.Length ? titleParts[i] : string.Empty;

            if (string.IsNullOrWhiteSpace(fieldName))
            {
                continue;
            }

            if (string.IsNullOrWhiteSpace(headerText))
            {
                headerText = fieldName;
            }

            comboColumns.Add(new ComboListColumn
            {
                FieldName = fieldName.Trim(),
                HeaderText = headerText.Trim()
            });
        }

        popupForm.BuildColumns(comboColumns, manyCheck);
    }

    private static string[] SplitList(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return new string[0];
        }

        char[] separators = new char[] { ',', '，', ';', '；', '|', '、' };
        string[] items = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < items.Length; i++)
        {
            items[i] = items[i].Trim();
        }

        return items;
    }

    private void ShowPopup()
    {
        if (!Enabled || popupForm == null || txtInput == null)
        {
            return;
        }

        if (sourceTable == null || comboColumns.Count <= 0)
        {
            return;
        }

        if (!popupForm.Visible)
        {
            snapshotText = txtInput.Text;
            snapshotKeys = new HashSet<string>(selectedKeys, StringComparer.OrdinalIgnoreCase);
            popupCommitted = false;
        }

        RefreshDisplayData();
        UpdatePopupBounds();
        if (!popupForm.Visible)
        {
            popupForm.ShowPopup(this.FindForm());
        }
    }

    private void HidePopup(bool restoreSnapshot)
    {
        if (popupForm == null || !popupForm.Visible)
        {
            return;
        }

        popupForm.Hide();

        if (restoreSnapshot && !popupCommitted)
        {
            selectedKeys.Clear();
            foreach (string key in snapshotKeys)
            {
                selectedKeys.Add(key);
            }

            SetInputText(snapshotText, true);
            RefreshDisplayData();
        }
    }

    private void UpdatePopupBounds()
    {
        if (popupForm == null)
        {
            return;
        }

        int popupWidth = Math.Max(Width, 420);
        int visibleRows = displayTable == null ? 0 : displayTable.Rows.Count;
        int bodyRows = Math.Min(Math.Max(visibleRows, 5), 10);
        int popupHeight = 36 + bodyRows * 30 + 8;
        if (!manyCheck)
        {
            popupHeight -= 36;
        }

        Point screenPoint = PointToScreen(new Point(0, Height - 1));
        Rectangle workArea = Screen.FromControl(this).WorkingArea;
        int x = screenPoint.X;
        int y = screenPoint.Y;

        if (x + popupWidth > workArea.Right)
        {
            x = workArea.Right - popupWidth;
        }

        if (x < workArea.Left)
        {
            x = workArea.Left;
        }

        if (y + popupHeight > workArea.Bottom)
        {
            Point topPoint = PointToScreen(new Point(0, -popupHeight));
            y = topPoint.Y;
        }

        popupForm.Bounds = new Rectangle(x, y, popupWidth, popupHeight);
    }

    private void RefreshDisplayData()
    {
        if (popupForm == null || txtInput == null || sourceTable == null || comboColumns.Count <= 0)
        {
            displayTable = null;
            popupForm?.BindData(null);
            return;
        }

        DataTable table = BuildDisplayTableSchema();
        string keyword = txtInput.Text.Trim();

        for (int i = 0; i < sourceTable.Rows.Count; i++)
        {
            DataRow sourceRow = sourceTable.Rows[i];
            if (!MatchKeyword(sourceRow, keyword))
            {
                continue;
            }

            DataRow row = table.NewRow();
            row["_KEY"] = GetRowKey(sourceRow);
            row["_CHECK"] = selectedKeys.Contains(row["_KEY"].ToString());

            for (int j = 0; j < comboColumns.Count; j++)
            {
                string fieldName = comboColumns[j].FieldName;
                row[fieldName] = GetRowString(sourceRow, fieldName);
            }

            table.Rows.Add(row);
        }

        displayTable = table;
        popupForm.BindData(displayTable);
        popupForm.BuildColumns(comboColumns, manyCheck);
        UpdatePopupBounds();
        SelectFirstVisibleRow();
    }

    private DataTable BuildDisplayTableSchema()
    {
        DataTable table = new DataTable();
        table.Columns.Add("_CHECK", typeof(bool));
        table.Columns.Add("_KEY", typeof(string));

        for (int i = 0; i < comboColumns.Count; i++)
        {
            table.Columns.Add(comboColumns[i].FieldName, typeof(string));
        }

        return table;
    }

    private bool MatchKeyword(DataRow row, string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return true;
        }

        for (int i = 0; i < comboColumns.Count; i++)
        {
            string text = GetRowString(row, comboColumns[i].FieldName);
            if (text.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return true;
            }
        }

        return false;
    }

    private string GetRowKey(DataRow row)
    {
        string fieldName = GetValueMemberFieldName();
        if (string.IsNullOrWhiteSpace(fieldName))
        {
            return string.Empty;
        }

        return GetRowString(row, fieldName);
    }

    private static string GetRowString(DataRow row, string fieldName)
    {
        if (row == null || row.Table == null || !row.Table.Columns.Contains(fieldName))
        {
            return string.Empty;
        }

        object value = row[fieldName];
        return value == null || value == DBNull.Value ? string.Empty : value.ToString().Trim();
    }

    private DataRow FindSourceRow(string key)
    {
        if (sourceTable == null || comboColumns.Count <= 0)
        {
            return null;
        }

        string valueFieldName = GetValueMemberFieldName();
        if (string.IsNullOrWhiteSpace(valueFieldName) || !sourceTable.Columns.Contains(valueFieldName))
        {
            return null;
        }

        string filter = string.Format("[{0}] = '{1}'", valueFieldName.Replace("]", "]]"), key.Replace("'", "''"));
        DataRow[] rows = sourceTable.Select(filter);
        if (rows.Length > 0)
        {
            return rows[0];
        }

        for (int i = 0; i < sourceTable.Rows.Count; i++)
        {
            DataRow row = sourceTable.Rows[i];
            if (string.Equals(GetRowString(row, valueFieldName), key, StringComparison.OrdinalIgnoreCase))
            {
                return row;
            }
        }

        return null;
    }

    private void SelectFirstVisibleRow()
    {
        if (popupForm.Grid.Rows.Count <= 0)
        {
            return;
        }

        try
        {
            string columnName = manyCheck && popupForm.Grid.Columns.Contains("_CHECK") && popupForm.Grid.Columns["_CHECK"].Visible
                ? popupForm.Grid.Columns[popupForm.FirstDataColumnName].Name
                : popupForm.FirstDataColumnName;

            if (popupForm.Grid.Columns.Contains(columnName))
            {
                popupForm.Grid.CurrentCell = popupForm.Grid.Rows[0].Cells[columnName];
            }
        }
        catch
        {
        }
    }

    private void FocusFirstVisibleRow()
    {
        if (popupForm.Grid.Rows.Count <= 0)
        {
            return;
        }

        try
        {
            string columnName = popupForm.FirstDataColumnName;
            if (popupForm.Grid.Columns.Contains(columnName))
            {
                popupForm.Grid.CurrentCell = popupForm.Grid.Rows[0].Cells[columnName];
            }
        }
        catch
        {
        }
    }

    private void ToggleRowCheck(int rowIndex)
    {
        if (displayTable == null || rowIndex < 0 || rowIndex >= displayTable.Rows.Count)
        {
            return;
        }

        DataRow row = displayTable.Rows[rowIndex];
        bool current = false;
        if (row["_CHECK"] != DBNull.Value)
        {
            bool.TryParse(row["_CHECK"].ToString(), out current);
        }

        if (!manyCheck)
        {
            for (int i = 0; i < displayTable.Rows.Count; i++)
            {
                displayTable.Rows[i]["_CHECK"] = false;
            }
        }

        bool next = !current;
        row["_CHECK"] = next;

        if (!manyCheck)
        {
            CommitRowByIndex(rowIndex);
            return;
        }

        string key = row["_KEY"].ToString();
        if (next)
        {
            selectedKeys.Add(key);
        }
        else
        {
            selectedKeys.Remove(key);
        }

        popupForm.Grid.Refresh();
    }

    private void CommitCurrentRow()
    {
        if (popupForm.Grid.CurrentRow == null)
        {
            if (popupForm.Grid.Rows.Count > 0)
            {
                CommitRowByIndex(0);
            }

            return;
        }

        CommitRowByIndex(popupForm.Grid.CurrentRow.Index);
    }

    private void CommitRowByIndex(int rowIndex)
    {
        if (displayTable == null || rowIndex < 0 || rowIndex >= displayTable.Rows.Count)
        {
            return;
        }

        DataRow row = displayTable.Rows[rowIndex];
        string key = row["_KEY"].ToString();

        selectedKeys.Clear();
        if (!string.IsNullOrWhiteSpace(key))
        {
            selectedKeys.Add(key);
        }

        popupCommitted = true;
        SetInputText(BuildDisplayText(row), true);
        RaiseSelectedValueChanged();
        HidePopup(false);
    }

    private void CommitCheckedRows()
    {
        if (displayTable == null || displayTable.Rows.Count <= 0)
        {
            HidePopup(true);
            return;
        }

        List<string> keys = new List<string>();
        List<string> texts = new List<string>();

        for (int i = 0; i < displayTable.Rows.Count; i++)
        {
            DataRow row = displayTable.Rows[i];
            bool checkedValue = false;
            if (row["_CHECK"] != DBNull.Value)
            {
                bool.TryParse(row["_CHECK"].ToString(), out checkedValue);
            }

            if (!checkedValue)
            {
                continue;
            }

            string key = row["_KEY"].ToString();
            if (!string.IsNullOrWhiteSpace(key))
            {
                keys.Add(key);
            }

            texts.Add(BuildDisplayText(row));
        }

        selectedKeys.Clear();
        for (int i = 0; i < keys.Count; i++)
        {
            selectedKeys.Add(keys[i]);
        }

        popupCommitted = true;
        SetInputText(string.Join("；", texts.ToArray()), true);
        RaiseSelectedValueChanged();
        HidePopup(false);
    }

    private string BuildDisplayText(DataRow row)
    {
        string displayFieldName = GetDisplayMemberFieldName(row);
        if (!string.IsNullOrWhiteSpace(displayFieldName))
        {
            return GetRowString(row, displayFieldName);
        }

        List<string> parts = new List<string>();

        for (int i = 0; i < comboColumns.Count; i++)
        {
            string text = row[comboColumns[i].FieldName] == DBNull.Value
                ? string.Empty
                : row[comboColumns[i].FieldName].ToString().Trim();

            if (!string.IsNullOrWhiteSpace(text))
            {
                parts.Add(text);
            }
        }

        return string.Join(" ", parts.ToArray());
    }

    private string BuildDisplayTextFromSourceRow(DataRow row)
    {
        return BuildDisplayText(row);
    }

    private string GetValueMemberFieldName()
    {
        if (!string.IsNullOrWhiteSpace(valueMember))
        {
            return valueMember.Trim();
        }

        return comboColumns.Count > 0 ? comboColumns[0].FieldName : string.Empty;
    }

    private string GetDisplayMemberFieldName(DataRow row)
    {
        if (row == null || row.Table == null || string.IsNullOrWhiteSpace(displayMember))
        {
            return string.Empty;
        }

        string fieldName = displayMember.Trim();
        return row.Table.Columns.Contains(fieldName) ? fieldName : string.Empty;
    }

    private void RefreshSelectedText()
    {
        if (sourceTable == null || selectedKeys.Count <= 0)
        {
            return;
        }

        List<string> texts = new List<string>();
        for (int i = 0; i < sourceTable.Rows.Count; i++)
        {
            DataRow row = sourceTable.Rows[i];
            if (selectedKeys.Contains(GetRowKey(row)))
            {
                texts.Add(BuildDisplayTextFromSourceRow(row));
            }
        }

        SetInputText(string.Join("；", texts.ToArray()), true);
    }

    private void RaiseSelectedValueChanged()
    {
        if (SelectedValueChanged != null)
        {
            SelectedValueChanged(this, EventArgs.Empty);
        }
    }

    private void SetInputText(string text, bool suppressEvent)
    {
        suppressTextChange = suppressEvent;
        try
        {
            txtInput.Text = text ?? string.Empty;
            txtInput.SelectionStart = txtInput.TextLength;
        }
        finally
        {
            suppressTextChange = false;
        }
    }

    private List<string> GetSelectedKeysInDisplayOrder()
    {
        List<string> keys = new List<string>();
        if (displayTable == null)
        {
            return keys;
        }

        for (int i = 0; i < displayTable.Rows.Count; i++)
        {
            DataRow row = displayTable.Rows[i];
            bool checkedValue = false;
            if (row["_CHECK"] != DBNull.Value)
            {
                bool.TryParse(row["_CHECK"].ToString(), out checkedValue);
            }

            if (checkedValue)
            {
                string key = row["_KEY"].ToString();
                if (!string.IsNullOrWhiteSpace(key))
                {
                    keys.Add(key);
                }
            }
        }

        if (keys.Count == 0)
        {
            foreach (string key in selectedKeys)
            {
                keys.Add(key);
            }
        }

        return keys;
    }

    private sealed class ComboListColumn
    {
        public string FieldName { get; set; }
        public string HeaderText { get; set; }
    }

    private sealed class ComboListPopupForm : Form
    {
        private readonly Panel topPanel;
        public readonly Button BtnOk;
        public readonly Button BtnCancel;
        public readonly MyDataGridView Grid;
        private readonly DataGridViewCheckBoxColumn checkColumn;
        private readonly Dictionary<string, DataGridViewTextBoxColumn> dataColumns = new Dictionary<string, DataGridViewTextBoxColumn>(StringComparer.OrdinalIgnoreCase);
        private string firstDataColumnName = string.Empty;

        public string FirstDataColumnName
        {
            get
            {
                return firstDataColumnName;
            }
        }

        public ComboListPopupForm()
        {
            FormBorderStyle = FormBorderStyle.None;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            BackColor = Color.FromArgb(45, 139, 243);
            Padding = new Padding(1);
            TopMost = false;

            topPanel = new Panel();
            topPanel.Dock = DockStyle.Top;
            topPanel.Height = 34;
            topPanel.BackColor = Color.White;

            BtnOk = new Button();
            BtnOk.Text = "确定";
            BtnOk.FlatStyle = FlatStyle.Flat;
            BtnOk.FlatAppearance.BorderSize = 0;
            BtnOk.BackColor = Color.FromArgb(45, 139, 243);
            BtnOk.ForeColor = Color.White;
            BtnOk.Font = new Font("微软雅黑", 9F);
            BtnOk.Size = new Size(54, 24);
            BtnOk.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnOk.Cursor = Cursors.Hand;

            BtnCancel = new Button();
            BtnCancel.Text = "取消";
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnCancel.BackColor = Color.FromArgb(200, 200, 200);
            BtnCancel.ForeColor = Color.White;
            BtnCancel.Font = new Font("微软雅黑", 9F);
            BtnCancel.Size = new Size(54, 24);
            BtnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCancel.Cursor = Cursors.Hand;

            Grid = new MyDataGridView();
            Grid.Dock = DockStyle.Fill;
            Grid.AutoGenerateColumns = false;
            Grid.ReadOnly = true;
            Grid.AllowUserToResizeColumns = true;
            Grid.AllowUserToResizeRows = false;
            Grid.MultiSelect = false;
            Grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grid.EditMode = DataGridViewEditMode.EditProgrammatically;
            Grid.BorderStyle = BorderStyle.None;
            Grid.RowHeadersVisible = false;
            Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            Grid.BackgroundColor = Color.White;
            Grid.RowTemplate.Height = 28;
            Grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Grid.ColumnHeadersHeight = 30;
            Grid.ColumnHeadersDefaultCellStyle.Font = new Font("微软雅黑", 9F);
            Grid.DefaultCellStyle.Font = new Font("微软雅黑", 9F);
            Grid.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "_CHECK";
            checkColumn.DataPropertyName = "_CHECK";
            checkColumn.HeaderText = string.Empty;
            checkColumn.Width = 32;
            checkColumn.Visible = false;
            checkColumn.ReadOnly = true;
            checkColumn.FlatStyle = FlatStyle.Standard;
            checkColumn.TrueValue = true;
            checkColumn.FalseValue = false;
            checkColumn.ThreeState = false;

            Controls.Add(Grid);
            Controls.Add(topPanel);

            topPanel.Controls.Add(BtnCancel);
            topPanel.Controls.Add(BtnOk);

            BtnOk.Location = new Point(Width - 118, 5);
            BtnCancel.Location = new Point(Width - 59, 5);

            Grid.Columns.Clear();
            Grid.Columns.Add(checkColumn);

            Resize += ComboListPopupForm_Resize;
        }

        public bool ManyCheckEnabled { get; private set; }

        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_NOACTIVATE = 0x08000000;
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_NOACTIVATE;
                return cp;
            }
        }

        public void SetManyCheck(bool value)
        {
            ManyCheckEnabled = value;
            topPanel.Visible = value;
            BtnOk.Visible = value;
            BtnCancel.Visible = value;
            if (Grid.Columns.Contains("_CHECK"))
            {
                Grid.Columns["_CHECK"].Visible = value;
            }
        }

        public void BuildColumns(List<ComboListColumn> columns, bool manyCheck)
        {
            SetManyCheck(manyCheck);

            Grid.Columns.Clear();
            Grid.Columns.Add(checkColumn);
            checkColumn.Visible = manyCheck;

            dataColumns.Clear();
            firstDataColumnName = string.Empty;
            if (columns == null)
            {
                return;
            }

            for (int i = 0; i < columns.Count; i++)
            {
                ComboListColumn column = columns[i];
                if (string.IsNullOrWhiteSpace(firstDataColumnName))
                {
                    firstDataColumnName = column.FieldName;
                }

                DataGridViewTextBoxColumn gridColumn = new DataGridViewTextBoxColumn();
                gridColumn.Name = column.FieldName;
                gridColumn.DataPropertyName = column.FieldName;
                gridColumn.HeaderText = column.HeaderText;
                gridColumn.ReadOnly = true;
                gridColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
                gridColumn.Width = GetDefaultWidth(column.HeaderText, column.FieldName);
                gridColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                Grid.Columns.Add(gridColumn);
                dataColumns[column.FieldName] = gridColumn;
            }
        }

        public void BindData(DataTable table)
        {
            Grid.DataSource = table;

            if (Grid.Columns.Count <= 0)
            {
                return;
            }

            if (Grid.Columns.Contains("_CHECK"))
            {
                Grid.Columns["_CHECK"].Visible = ManyCheckEnabled;
            }

            foreach (DataGridViewColumn column in Grid.Columns)
            {
                if (column.Name == "_CHECK")
                {
                    continue;
                }

                column.Visible = true;
            }

            if (Grid.Rows.Count > 0)
            {
                string columnName = FirstDataColumnName;
                if (!string.IsNullOrWhiteSpace(columnName) && Grid.Columns.Contains(columnName))
                {
                    Grid.CurrentCell = Grid.Rows[0].Cells[columnName];
                }
            }
            else
            {
                Grid.ClearSelection();
            }
        }

        public void ShowPopup(Form owner)
        {
            if (Visible)
            {
                return;
            }

            if (owner != null)
            {
                Show(owner);
            }
            else
            {
                Show();
            }
        }

        private void ComboListPopupForm_Resize(object sender, EventArgs e)
        {
            BtnOk.Location = new Point(Math.Max(Width - 118, 4), 5);
            BtnCancel.Location = new Point(Math.Max(Width - 59, 60), 5);
        }

        private static int GetDefaultWidth(string titleText, string fieldName)
        {
            int titleLength = string.IsNullOrWhiteSpace(titleText) ? 0 : titleText.Length;
            int fieldLength = string.IsNullOrWhiteSpace(fieldName) ? 0 : fieldName.Length;
            int baseWidth = Math.Max(titleLength, fieldLength);
            if (baseWidth <= 2)
            {
                return 96;
            }

            if (baseWidth <= 4)
            {
                return 120;
            }

            if (baseWidth <= 6)
            {
                return 140;
            }

            return 160;
        }
    }
}
