using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class MyComboBox : ComboBox
{
    private Color _border = Color.FromArgb(200, 200, 200);
    private Color _focus = Color.FromArgb(45, 139, 243);

    public MyComboBox()
    {
        UpdateStyles();
        DrawMode = DrawMode.OwnerDrawFixed;
        Font = new Font("微软雅黑", 12F);
        ItemHeight = 28;
        FlatStyle = FlatStyle.Flat;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        DrawBorder(e.Graphics, Focused ? _focus : _border);
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
        using (Brush br = new SolidBrush(sel ? Color.FromArgb(45, 139, 243) : Color.White))
            e.Graphics.FillRectangle(br, e.Bounds);

        TextRenderer.DrawText(e.Graphics, Items[e.Index].ToString(), Font, e.Bounds,
            sel ? Color.White : ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
    }

    protected override void OnGotFocus(EventArgs e)
    { Invalidate(); base.OnGotFocus(e); }

    protected override void OnLostFocus(EventArgs e)
    { Invalidate(); base.OnLostFocus(e); }

    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);
        // 修复：兼容C# 7.3的传统写法
        if (m.Msg == 0xF || m.Msg == 0x133)
            DrawBorder(CreateGraphics(), Focused ? _focus : _border);
    }
}