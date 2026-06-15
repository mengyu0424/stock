using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

[ToolboxBitmap(typeof(DataGridView))]
public class MyDataGridView : DataGridView
{
    // 统一颜色定义（和之前控件保持一致）
    private Color _normal = Color.FromArgb(45, 139, 243);   // 深蓝（表头/选中）
    private Color _hover = Color.FromArgb(230, 244, 255);   // 浅蓝（悬浮行）
    private Color _disabled = Color.FromArgb(200, 200, 200); // 浅灰（禁用）
    private Color _alternateRow = Color.FromArgb(248, 249, 250); // 隔行色

    public MyDataGridView()
    {
        CellFormatting += MyDataGridView_CellFormatting;

        // 核心：手动列不会被清空
        this.AutoGenerateColumns = false;

        // 基础样式
        this.BorderStyle = BorderStyle.None;
        this.RowHeadersVisible = false;
        this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.ColumnHeadersHeight = 36;
        this.RowTemplate.Height = 32;
        this.AllowUserToResizeRows = false;

        // 网格线
        this.GridColor = Color.FromArgb(230, 230, 230);
        this.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

        // 背景 & 单元格样式
        this.BackgroundColor = Color.White;
        this.DefaultCellStyle.BackColor = Color.White;
        this.DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40);
        this.DefaultCellStyle.SelectionBackColor = _normal;
        this.DefaultCellStyle.SelectionForeColor = Color.White;
        this.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        this.DefaultCellStyle.Padding = new Padding(4, 0, 4, 0);

        // 隔行变色
        this.AlternatingRowsDefaultCellStyle.BackColor = _alternateRow;

        // 表头样式
        this.ColumnHeadersDefaultCellStyle.BackColor = _normal;
        this.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        this.ColumnHeadersDefaultCellStyle.Font = new Font("微软雅黑", 9F);
        this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        this.EnableHeadersVisualStyles = false;

        // 选择行为
        this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.MultiSelect = false;
        this.EditMode = DataGridViewEditMode.EditProgrammatically;

        // 禁止空白行
        this.AllowUserToAddRows = false;

        // 双缓冲防闪烁
        SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        
        // 订阅 DataSourceChanged 事件，在数据绑定后清除选中
        this.DataSourceChanged += MyDataGridView_DataSourceChanged;
    }

    // 重写启用/禁用事件，应用对应样式
    protected override void OnEnabledChanged(EventArgs e)
    {
        base.OnEnabledChanged(e);
        ApplyEnabledStyle();
    }

    // 应用启用/禁用样式
    private void ApplyEnabledStyle()
    {
        if (!Enabled)
        {
            // 禁用：整体变灰
            this.BackgroundColor = Color.FromArgb(245, 245, 245);
            this.DefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            this.DefaultCellStyle.ForeColor = _disabled;
            this.DefaultCellStyle.SelectionBackColor = _disabled;
            this.DefaultCellStyle.SelectionForeColor = Color.White;
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            this.ColumnHeadersDefaultCellStyle.BackColor = _disabled;
            this.GridColor = Color.FromArgb(220, 220, 220);
        }
        else
        {
            // 启用：恢复正常样式
            this.BackgroundColor = Color.White;
            this.DefaultCellStyle.BackColor = Color.White;
            this.DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40);
            this.DefaultCellStyle.SelectionBackColor = _normal;
            this.DefaultCellStyle.SelectionForeColor = Color.White;
            this.AlternatingRowsDefaultCellStyle.BackColor = _alternateRow;
            this.ColumnHeadersDefaultCellStyle.BackColor = _normal;
            this.GridColor = Color.FromArgb(230, 230, 230);
        }
        Invalidate();
    }

    // 鼠标悬浮高亮（禁用时不生效）
    protected override void OnCellMouseEnter(DataGridViewCellEventArgs e)
    {
        base.OnCellMouseEnter(e);
        if (Enabled && e.RowIndex >= 0)
        {
            Rows[e.RowIndex].DefaultCellStyle.BackColor = _hover;
        }
    }

    protected override void OnCellMouseLeave(DataGridViewCellEventArgs e)
    {
        base.OnCellMouseLeave(e);
        if (Enabled && e.RowIndex >= 0)
        {
            Rows[e.RowIndex].DefaultCellStyle.BackColor =
                e.RowIndex % 2 == 0 ? Color.White : _alternateRow;
        }
    }

    #region 自动选中控制
    
    private bool _autoSelectFirstRow = false;

    [DefaultValue(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Description("加载数据后是否自动选中第一行（默认false）")]
    public bool AutoSelectFirstRow
    {
        get => _autoSelectFirstRow;
        set => _autoSelectFirstRow = value;
    }

    /// <summary>
    /// 数据源改变时触发
    /// </summary>
    private void MyDataGridView_DataSourceChanged(object sender, EventArgs e)
    {
        // 如果设置为不自动选中第一行，则清除选中状态
        if (!_autoSelectFirstRow && this.Rows.Count > 0)
        {
            this.ClearSelection();
        }
    }

    #endregion

    #region 单元格值转换属性（支持设计器保存）
    private bool _convertValueFlag = false;

    [DefaultValue(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Description("开启后自动根据规则转换单元格显示文本")]
    public bool ConvertValueFlag
    {
        get => _convertValueFlag;
        set => _convertValueFlag = value;
    }

    private string _convertValueData = string.Empty;

    [DefaultValue("")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Description("格式：列名:1-启用*0-停用;列名2:1-开启*0-关闭")]
    public string ConvertValueData
    {
        get => _convertValueData;
        set
        {
            _convertValueData = value;
            ParseConvertRule();
        }
    }

    private readonly Dictionary<string, Dictionary<string, string>> _colMapping = new Dictionary<string, Dictionary<string, string>>();

    private void ParseConvertRule()
    {
        _colMapping.Clear();
        if (string.IsNullOrWhiteSpace(ConvertValueData))
            return;

        string[] colRules = ConvertValueData.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var colRuleItem in colRules)
        {
            string[] colKv = colRuleItem.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            if (colKv.Length != 2) continue;

            string colName = colKv[0].Trim().ToLower();
            string mapStr = colKv[1].Trim();
            var dic = new Dictionary<string, string>();

            string[] itemArr = mapStr.Split(new char[] { '*' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in itemArr)
            {
                string[] kv = item.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                if (kv.Length >= 2)
                {
                    string key = kv[0].Trim();
                    string text = kv[1].Trim();
                    dic[key] = text;
                }
            }
            _colMapping[colName] = dic;
        }
    }

    private void MyDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
        if (!ConvertValueFlag) return;
        if (e.Value == null || e.Value == DBNull.Value) return;

        string curColName = this.Columns[e.ColumnIndex].Name.Trim().ToLower();
        if (_colMapping.TryGetValue(curColName, out var mapDic))
        {
            string valKey = e.Value.ToString().Trim();
            if (mapDic.TryGetValue(valKey, out string showTxt))
            {
                e.Value = showTxt;
                e.FormattingApplied = true;
            }
        }
    }
    #endregion
}