using System.Windows.Forms;

namespace WindowsFormsApp.测试菜单
{
    public partial class cshtml3 : Form
    {
        public cshtml3()
        {
            InitializeComponent();
            this.Text = "菜单3";
            Label lbl = new Label
            {
                Text = "这是菜单3的内容",
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Font = new System.Drawing.Font("微软雅黑", 12f)
            };
            this.Controls.Add(lbl);
        }
    }
}