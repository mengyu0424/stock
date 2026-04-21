using System;
using System.Drawing;
using System.Windows.Forms;

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

        // 表头样式（改为统一深蓝色）
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
}