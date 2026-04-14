using System.Drawing;
using System.Drawing.Drawing2D;

public static class GraphicsExtension
{
    public static void FillRoundedRectangle(this Graphics g, Brush brush, int x, int y, int w, int h, int radius)
    {
        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(x, y, radius, radius, 180, 90);
            path.AddArc(x + w - radius, y, radius, radius, 270, 90);
            path.AddArc(x + w - radius, y + h - radius, radius, radius, 0, 90);
            path.AddArc(x, y + h - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            g.FillPath(brush, path);
        }
    }

    public static void FillRoundedRectangle(this Graphics g, Brush brush, Rectangle rect, int radius)
    {
        FillRoundedRectangle(g, brush, rect.X, rect.Y, rect.Width, rect.Height, radius);
    }

    public static void FillRoundedRectangle(this Graphics g, Brush brush, RectangleF rect, float radius)
    {
        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            g.FillPath(brush, path);
        }
    }

    public static void DrawRoundedRectangle(this Graphics g, Pen pen, int x, int y, int w, int h, int radius)
    {
        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(x, y, radius, radius, 180, 90);
            path.AddArc(x + w - radius, y, radius, radius, 270, 90);
            path.AddArc(x + w - radius, y + h - radius, radius, radius, 0, 90);
            path.AddArc(x, y + h - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            g.DrawPath(pen, path);
        }
    }

    public static void DrawRoundedRectangle(this Graphics g, Pen pen, Rectangle rect, int radius)
    {
        DrawRoundedRectangle(g, pen, rect.X, rect.Y, rect.Width, rect.Height, radius);
    }

    public static void DrawRoundedRectangle(this Graphics g, Pen pen, RectangleF rect, float radius)
    {
        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            g.DrawPath(pen, path);
        }
    }
}