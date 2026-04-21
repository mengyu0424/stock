using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class MyCheckBox : CheckBox
{
    // 正常边框
    private Color _border = Color.FromArgb(180, 180, 180);
    // 勾选颜色（深蓝色）
    private Color _check = Color.FromArgb(45, 139, 243);
    // 鼠标悬浮边框/背景（浅蓝色）
    private Color _hover = Color.FromArgb(66, 158, 255);
    // 禁用状态（浅灰色）
    private Color _disabled = Color.FromArgb(200, 200, 200);

    public MyCheckBox()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        TextAlign = ContentAlignment.MiddleLeft;
        Font = new Font("微软雅黑", 12F);
        AutoSize = true;
        Cursor = Cursors.Hand;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.Clear(Parent.BackColor);

        int sz = 18;
        Rectangle box = new Rectangle(0, Height / 2 - sz / 2, sz, sz);

        // 判断鼠标是否在复选框上方
        bool isHover = RectangleToScreen(ClientRectangle).Contains(MousePosition);

        // 绘制背景
        if (!Enabled)
        {
            // 禁用：浅灰色背景
            using (Brush br = new SolidBrush(_disabled))
                g.FillRoundedRectangle(br, box, 3);
        }
        else if (Checked)
        {
            // 勾选：蓝色背景
            using (Brush br = new SolidBrush(_check))
                g.FillRoundedRectangle(br, box, 3);
        }
        else
        {
            // 未勾选：白色背景
            using (Brush br = new SolidBrush(Color.White))
                g.FillRoundedRectangle(br, box, 3);
        }

        // 绘制边框
        Color borderColor;
        if (!Enabled)
            borderColor = _disabled;       // 禁用灰色
        else if (isHover)
            borderColor = _hover;          // 悬浮浅蓝色
        else if (Checked)
            borderColor = _check;          // 勾选蓝色
        else
            borderColor = _border;         // 默认灰色

        using (Pen p = new Pen(borderColor, 1))
            g.DrawRoundedRectangle(p, box, 3);

        // 绘制勾选对号
        if (Checked && Enabled)
        {
            using (Pen p = new Pen(Color.White, 2))
            {
                g.DrawLine(p, sz / 3, sz / 2, sz * 5 / 12, sz * 3 / 4);
                g.DrawLine(p, sz * 5 / 12, sz * 3 / 4, sz * 2 / 3, sz / 3);
            }
        }

        // 绘制文字（禁用时文字变灰）
        Color textColor = Enabled ? ForeColor : Color.FromArgb(150, 150, 150);
        TextRenderer.DrawText(g, Text, Font, new Point(sz + 6, Height / 2 - Font.Height / 2), textColor);
    }
}