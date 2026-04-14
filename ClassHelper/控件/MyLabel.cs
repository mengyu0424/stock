using System.Drawing;
using System.Windows.Forms;

public class MyLabel : Label
{
    public MyLabel()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        Font = new Font("微软雅黑", 12F);
        ForeColor = Color.FromArgb(40, 40, 40);
        AutoSize = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
        TextRenderer.DrawText(e.Graphics, Text, Font, ClientRectangle, ForeColor,
            TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
    }
}