using System;
using System.Windows.Forms;
using WindowsFormsApp.主窗体;

namespace WindowsFormsApp.维护功能
{
    public partial class WpdmSettingCopy : BasePopupForm
    {
        public string NewWpdmCode
        {
            get { return txtNewCode.Text.Trim(); }
        }

        public string NewWpdmName
        {
            get { return txtNewName.Text.Trim(); }
        }

        public int NewSxh { get; }

        public WpdmSettingCopy(string newCode, int newSxh, string defaultName)
        {
            NewSxh = newSxh;
            InitializeComponent();
            txtNewCode.Text = newCode;
            txtNewName.Text = defaultName ?? string.Empty;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NewWpdmCode))
            {
                MessageBox.Show("物品代码不能为空！");
                return;
            }

            if (string.IsNullOrWhiteSpace(NewWpdmName))
            {
                MessageBox.Show("物品名称不能为空！");
                txtNewName.Focus();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
