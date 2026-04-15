using System.Drawing;
using System.Windows.Forms;

[ToolboxBitmap(typeof(DataGridView))]
public class MyDataGridView : DataGridView
{
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

        // 背景
        this.BackgroundColor = Color.White;
        this.DefaultCellStyle.BackColor = Color.White;
        this.DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40);
        this.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 139, 243);
        this.DefaultCellStyle.SelectionForeColor = Color.White;
        this.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        this.DefaultCellStyle.Padding = new Padding(4, 0, 4, 0);

        // 隔行变色
        this.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);

        // 表头样式
        this.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
        this.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
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

    // 鼠标悬浮高亮
    protected override void OnCellMouseEnter(DataGridViewCellEventArgs e)
    {
        base.OnCellMouseEnter(e);
        if (e.RowIndex >= 0)
        {
            Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(235, 243, 255);
        }
    }

    protected override void OnCellMouseLeave(DataGridViewCellEventArgs e)
    {
        base.OnCellMouseLeave(e);
        if (e.RowIndex >= 0)
        {
            Rows[e.RowIndex].DefaultCellStyle.BackColor =
                e.RowIndex % 2 == 0 ? Color.White : Color.FromArgb(248, 249, 250);
        }
    }
}