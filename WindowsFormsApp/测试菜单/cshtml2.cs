using System.Windows.Forms;

namespace WindowsFormsApp.测试菜单
{
    public partial class cshtml2 : Form
    {
        public cshtml2()
        {
            InitializeComponent();
            this.Text = "菜单12";
            Label lbl = new Label
            {
                Text = "这是菜单2的内容",
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Font = new System.Drawing.Font("微软雅黑", 12f)
            };
            this.Controls.Add(lbl);
        }
    }
}