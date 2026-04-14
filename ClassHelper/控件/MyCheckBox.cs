using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class MyCheckBox : CheckBox
{
    private Color _border = Color.FromArgb(180, 180, 180);
    private Color _check = Color.FromArgb(45, 139, 243);

    public MyCheckBox()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        TextAlign = ContentAlignment.MiddleLeft;
        Font = new Font("微软雅黑", 12F);
        AutoSize = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.Clear(Parent.BackColor);

        int sz = 18;
        Rectangle box = new Rectangle(0, Height / 2 - sz / 2, sz, sz);

        using (Brush br = new SolidBrush(Checked ? _check : Color.White))
            g.FillRoundedRectangle(br, box, 3);

        using (Pen p = new Pen(Checked ? _check : _border, 1))
            g.DrawRoundedRectangle(p, box, 3);

        if (Checked)
        {
            using (Pen p = new Pen(Color.White, 2))
            {
                g.DrawLine(p, sz / 3, sz / 2, sz * 5 / 12, sz * 3 / 4);
                g.DrawLine(p, sz * 5 / 12, sz * 3 / 4, sz * 2 / 3, sz / 3);
            }
        }

        TextRenderer.DrawText(g, Text, Font, new Point(sz + 6, Height / 2 - Font.Height / 2), ForeColor);
    }
}