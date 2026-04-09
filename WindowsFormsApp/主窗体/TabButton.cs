using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp.主窗体
{
    public partial class TabButton : UserControl
    {
        private Label lblText;
        private Label btnClose;
        private bool isSelected;

        public event EventHandler<EventArgs> CloseClick;
        public event EventHandler<EventArgs> TabSelected;

        public string TabText
        {
            get => lblText.Text;
            set
            {
                lblText.Text = value;
                AdjustWidth();
            }
        }

        public bool IsSelected
        {
            get => isSelected;
            set
            {
                isSelected = value;
                this.BackColor = value ? Color.White : Color.LightGray;
                lblText.ForeColor = value ? Color.Black : Color.DimGray;
            }
        }

        public TabButton()
        {
            InitializeComponents();
            this.Height = 28;
            this.Margin = new Padding(0, 0, 1, 0);
            this.Cursor = Cursors.Default;
            // 点击文字区域触发选中
            lblText.Click += (s, e) => TabSelected?.Invoke(this, EventArgs.Empty);
        }

        private void InitializeComponents()
        {
            // 文字标签：不自动拉伸，手动定位
            lblText = new Label
            {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("微软雅黑", 9f),
                BackColor = Color.Transparent,
                Location = new Point(6, 0),
                Height = this.Height
            };

            // 关闭按钮
            btnClose = new Label
            {
                Text = "×",
                Font = new Font("Arial", 10f, FontStyle.Bold),
                ForeColor = Color.Red,
                TextAlign = ContentAlignment.MiddleCenter,
                Cursor = Cursors.Arrow,
                Size = new Size(18, 18),
                BackColor = Color.Transparent
            };
            btnClose.Click += BtnClose_Click;

            this.Controls.Add(lblText);
            this.Controls.Add(btnClose);

            this.Resize += (s, e) => LayoutControls();
            this.BorderStyle= BorderStyle.Fixed3D;
            LayoutControls();
        }

        private void LayoutControls()
        {
            if (lblText == null || btnClose == null) return;

            // 关闭按钮固定在右侧
            int btnX = this.Width - btnClose.Width - 4;
            int btnY = (this.Height - btnClose.Height) / 2;
            btnClose.Location = new Point(btnX, btnY);

            // 文字标签宽度 = 控件宽度 - 关闭按钮宽度 - 额外间距
            int textWidth = this.Width - btnClose.Width - 12;
            if (textWidth < 20) textWidth = 20;
            lblText.Size = new Size(textWidth, this.Height);
            lblText.Location = new Point(6, 0);
        }

        private void AdjustWidth()
        {
            using (Graphics g = this.CreateGraphics())
            {
                SizeF textSize = g.MeasureString(lblText.Text, lblText.Font);
                int textWidth = (int)Math.Ceiling(textSize.Width);
                int totalWidth = textWidth + btnClose.Width + 16; // 左右内边距 + 关闭按钮宽度
                this.Width = Math.Max(totalWidth, 60);
                LayoutControls();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            CloseClick?.Invoke(this, EventArgs.Empty);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            LayoutControls();
        }
    }
}