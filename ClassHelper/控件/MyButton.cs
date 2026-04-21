using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class MyButton : Button
{
    // 正常状态 - 深蓝色
    private Color _normal = Color.FromArgb(45, 139, 243);
    // 鼠标悬浮 - 浅蓝色
    private Color _hover = Color.FromArgb(66, 158, 255);
    // 鼠标按下 - 更深的蓝色
    private Color _press = Color.FromArgb(33, 117, 210);
    // 控件禁用 - 浅灰色
    private Color _disabled = Color.FromArgb(200, 200, 200);

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

        Color backColor;

        // 优先判断：控件是否禁用 → 禁用直接用浅灰色
        if (!Enabled)
        {
            backColor = _disabled;
        }
        // 启用状态：判断鼠标按下/悬浮/正常
        else
        {
            backColor = MouseButtons == MouseButtons.Left ? _press
                  : RectangleToScreen(ClientRectangle).Contains(MousePosition) ? _hover
                  : _normal;
        }

        // 绘制圆角按钮背景
        using (Brush br = new SolidBrush(backColor))
            g.FillRoundedRectangle(br, 0, 0, Width - 1, Height - 1, 6);

        // 绘制居中文字
        TextRenderer.DrawText(g, Text, Font, ClientRectangle, Color.White,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }
}