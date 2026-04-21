using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class MyGroupBox : GroupBox
{
    // 统一颜色定义（和之前控件保持一致）
    private Color _normal = Color.FromArgb(45, 139, 243);   // 深蓝（正常）
    private Color _hover = Color.FromArgb(66, 158, 255);     // 浅蓝（悬浮）
    private Color _disabled = Color.FromArgb(200, 200, 200); // 浅灰（禁用）
    private float _radius = 8;

    public MyGroupBox()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        Font = new Font("微软雅黑", 12F);
        ForeColor = _normal;
        Cursor = Cursors.Hand;
    }

    // 获取当前状态对应的颜色
    private Color GetCurrentColor()
    {
        if (!Enabled)
            return _disabled;               // 禁用：浅灰
        if (RectangleToScreen(ClientRectangle).Contains(MousePosition))
            return _hover;                 // 悬浮：浅蓝
        return _normal;                    // 正常：深蓝
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.Clear(Parent.BackColor);

        Color currentColor = GetCurrentColor();
        SizeF textSize = g.MeasureString(Text, Font);
        RectangleF border = new RectangleF(0, textSize.Height / 2, Width - 1, Height - textSize.Height / 2 - 1);

        // 绘制圆角边框
        using (Pen p = new Pen(currentColor, 1))
            g.DrawRoundedRectangle(p, border, _radius);

        // 绘制文字背景（覆盖边框）
        using (Brush bg = new SolidBrush(Parent.BackColor))
            g.FillRectangle(bg, 6, 0, textSize.Width + 4, textSize.Height);

        // 绘制标题文字
        using (Brush text = new SolidBrush(currentColor))
            g.DrawString(Text, Font, text, 8, 0);
    }

    // 状态变化时重绘
    protected override void OnEnabledChanged(EventArgs e)
    {
        base.OnEnabledChanged(e);
        Invalidate();
    }

    // 鼠标进入/离开时重绘
    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        Invalidate();
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        Invalidate();
    }
}