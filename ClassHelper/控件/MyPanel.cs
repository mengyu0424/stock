using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class MyPanel : Panel
{
    private Color _border = Color.FromArgb(200, 200, 200);
    private int _radius = 6;

    public MyPanel()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        BackColor = Color.White;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        using (Brush br = new SolidBrush(BackColor))
            g.FillRoundedRectangle(br, 0, 0, Width - 1, Height - 1, _radius);

        using (Pen p = new Pen(_border, 1))
            g.DrawRoundedRectangle(p, 0, 0, Width - 1, Height - 1, _radius);
    }
}