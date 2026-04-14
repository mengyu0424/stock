using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.主窗体
{
    public partial class BaseForm : Form
    {
        // 最小尺寸保护（低分屏不会挤变形）
        private const int MIN_FORM_WIDTH = 800;
        private const int MIN_FORM_HEIGHT = 450;

        public BaseForm()
        {
            InitializeBaseSettings();
            SetGlobalStyle();
        }

        private void InitializeBaseSettings()
        {
            // 核心：嵌入父窗体
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;

            // 👇 关键：关闭自动DPI缩放，解决设计器抖动问题
            this.AutoScaleMode = AutoScaleMode.None;

            // 最小尺寸保护
            this.MinimumSize = new Size(MIN_FORM_WIDTH, MIN_FORM_HEIGHT);

            // 防闪烁
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void SetGlobalStyle()
        {
            // 统一字体
            this.Font = new Font("微软雅黑", 9F);
            this.ForeColor = Color.FromArgb(51, 51, 51);

            // 统一背景（白色干净）
            this.BackColor = Color.White;

            // 无边距
            this.Padding = new Padding(0);
            this.Margin = new Padding(0);
        }

        // 关闭时安全释放（不冲突、不报错）
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            try
            {
                foreach (Control ctrl in Controls) ctrl.Dispose();
                Controls.Clear();
            }
            catch { }
        }
    }

    /// <summary>
    /// 小窗体继承基类（弹窗专用）
    /// </summary>
    public class BasePopupForm : Form
    {
        public BasePopupForm()
        {
            // 弹窗基础样式
            this.FormBorderStyle = FormBorderStyle.None;
            this.AutoScaleMode = AutoScaleMode.None;
            this.StartPosition = FormStartPosition.CenterParent; // 居中
            this.BackColor = Color.White;
            this.Font = new Font("微软雅黑", 9F);
            this.ForeColor = Color.FromArgb(51, 51, 51);

            // 防闪烁
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);

            // 弹窗默认小尺寸（可在子类自由改）
            this.Size = new Size(320, 180);
            this.MinimumSize = new Size(200, 100); // 最小弹窗尺寸
        }

        #region 小弹窗必备：可拖动（点哪里都能拖动）
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }
        #endregion

        #region 安全释放
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                foreach (Control c in Controls)
                {
                    c.Dispose();
                }
                Controls.Clear();
            }
            base.Dispose(disposing);
        }
        #endregion
    }
}
