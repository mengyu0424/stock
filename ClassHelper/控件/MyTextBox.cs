using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class MyTextBox : TextBox
{
    // 统一颜色定义（和之前控件保持一致）
    private Color _border = Color.FromArgb(200, 200, 200);   // 正常边框
    private Color _hover = Color.FromArgb(66, 158, 255);     // 鼠标悬浮
    private Color _focus = Color.FromArgb(45, 139, 243);     // 聚焦输入
    private Color _disabled = Color.FromArgb(200, 200, 200); // 禁用状态

    public MyTextBox()
    {
        UpdateStyles();
        Font = new Font("微软雅黑", 12F);
        BorderStyle = BorderStyle.None;
        Padding = new Padding(12);
        Cursor = Cursors.Hand; // 和其他控件统一手型光标
    }

    // 获取当前状态对应的颜色
    private Color GetCurrentColor()
    {
        if (!Enabled)
            return _disabled;               // 禁用：浅灰
        if (Focused)
            return _focus;                 // 聚焦：深蓝
        if (RectangleToScreen(ClientRectangle).Contains(MousePosition))
            return _hover;                 // 悬浮：浅蓝
        return _border;                    // 正常：灰色
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        DrawBorder(e.Graphics, GetCurrentColor());
    }

    private void DrawBorder(Graphics g, Color color)
    {
        g.SmoothingMode = SmoothingMode.AntiAlias;
        using (Pen p = new Pen(color, 1))
            g.DrawRoundedRectangle(p, 0, 0, Width - 1, Height - 1, 6);
    }

    // 状态变化时重绘
    protected override void OnEnabledChanged(EventArgs e)
    {
        base.OnEnabledChanged(e);
        Invalidate();
    }

    protected override void OnGotFocus(EventArgs e)
    {
        Invalidate();
        base.OnGotFocus(e);
    }

    protected override void OnLostFocus(EventArgs e)
    {
        Invalidate();
        base.OnLostFocus(e);
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

    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);
        if (m.Msg == 0xF || m.Msg == 0x133)
            DrawBorder(CreateGraphics(), GetCurrentColor());
    }
}