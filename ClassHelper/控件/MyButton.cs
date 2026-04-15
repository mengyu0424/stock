using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class MyButton : Button
{
    private Color _normal = Color.FromArgb(45, 139, 243);
    private Color _hover = Color.FromArgb(66, 158, 255);
    private Color _press = Color.FromArgb(33, 117, 210);

    public MyButton()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        Cursor = Cursors.Hand;
        ForeColor = Color.White;
        Font = new Font("微软雅黑", 12F);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.Clear(Parent.BackColor);

        Color c = MouseButtons == MouseButtons.Left ? _press
              : RectangleToScreen(ClientRectangle).Contains(MousePosition) ? _hover
              : _normal;

        using (Brush br = new SolidBrush(c))
            g.FillRoundedRectangle(br, 0, 0, Width - 1, Height - 1, 6);

        TextRenderer.DrawText(g, Text, Font, ClientRectangle, Color.White,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }
}