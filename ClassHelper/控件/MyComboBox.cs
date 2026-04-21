using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class MyComboBox : ComboBox
{
    // 正常边框
    private Color _border = Color.FromArgb(200, 200, 200);
    // 聚焦/选中（深蓝色）
    private Color _focus = Color.FromArgb(45, 139, 243);
    // 鼠标悬浮（浅蓝色）
    private Color _hover = Color.FromArgb(66, 158, 255);
    // 禁用状态（浅灰色）
    private Color _disabled = Color.FromArgb(200, 200, 200);

    public MyComboBox()
    {
        UpdateStyles();
        DrawMode = DrawMode.OwnerDrawFixed;
        Font = new Font("微软雅黑", 12F);
        ItemHeight = 28;
        FlatStyle = FlatStyle.Flat;
        Cursor = Cursors.Hand;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        DrawBorder(e.Graphics, GetCurrentColor());
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
        return _border;                    // 默认：灰色
    }

    private void DrawBorder(Graphics g, Color color)
    {
        g.SmoothingMode = SmoothingMode.AntiAlias;
        using (Pen p = new Pen(color, 1))
            g.DrawRoundedRectangle(p, 0, 0, Width - 1, Height - 1, 6);
    }

    protected override void OnDrawItem(DrawItemEventArgs e)
    {
        e.DrawBackground();
        if (e.Index < 0) return;

        bool sel = (e.State & DrawItemState.Selected) != 0;
        Color backColor, textColor;

        if (!Enabled)
        {
            // 禁用状态：灰色背景 + 灰色文字
            backColor = Color.White;
            textColor = Color.FromArgb(150, 150, 150);
        }
        else
        {
            // 启用状态：选中蓝色背景白字，未选中白色背景黑字
            backColor = sel ? Color.FromArgb(45, 139, 243) : Color.White;
            textColor = sel ? Color.White : ForeColor;
        }

        using (Brush br = new SolidBrush(backColor))
            e.Graphics.FillRectangle(br, e.Bounds);

        TextRenderer.DrawText(e.Graphics, Items[e.Index].ToString(), Font, e.Bounds,
            textColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
    }

    protected override void OnGotFocus(EventArgs e)
    { Invalidate(); base.OnGotFocus(e); }

    protected override void OnLostFocus(EventArgs e)
    { Invalidate(); base.OnLostFocus(e); }

    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);
        if (m.Msg == 0xF || m.Msg == 0x133)
            DrawBorder(CreateGraphics(), GetCurrentColor());
    }
}