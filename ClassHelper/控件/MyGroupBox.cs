using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class MyGroupBox : GroupBox
{
    private Color _border = Color.FromArgb(45, 139, 243);
    private float _radius = 8;

    public MyGroupBox()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        Font = new Font("微软雅黑", 12F);
        ForeColor = Color.FromArgb(45, 139, 243);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.Clear(Parent.BackColor);

        SizeF textSize = g.MeasureString(Text, Font);
        RectangleF border = new RectangleF(0, textSize.Height / 2, Width - 1, Height - textSize.Height / 2 - 1);

        using (Pen p = new Pen(_border, 1))
            g.DrawRoundedRectangle(p, border, _radius);

        using (Brush bg = new SolidBrush(Parent.BackColor))
            g.FillRectangle(bg, 6, 0, textSize.Width + 4, textSize.Height);

        using (Brush text = new SolidBrush(ForeColor))
            g.DrawString(Text, Font, text, 8, 0);
    }
}