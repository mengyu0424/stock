using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class MyTextBox : TextBox
{
    private Color _border = Color.FromArgb(200, 200, 200);
    private Color _focus = Color.FromArgb(45, 139, 243);

    public MyTextBox()
    {
        UpdateStyles();
        Font = new Font("微软雅黑", 12F);
        BorderStyle = BorderStyle.None;
        Padding = new Padding(12);
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

    protected override void OnGotFocus(EventArgs e) { Invalidate(); base.OnGotFocus(e); }
    protected override void OnLostFocus(EventArgs e) { Invalidate(); base.OnLostFocus(e); }

    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);
        // 修复：兼容C# 7.3的传统写法
        if (m.Msg == 0xF || m.Msg == 0x133)
            DrawBorder(CreateGraphics(), Focused ? _focus : _border);
    }
}