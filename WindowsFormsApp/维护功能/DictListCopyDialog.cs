using System;
using System.Windows.Forms;
using WindowsFormsApp.主窗体;

namespace WindowsFormsApp.维护功能
{
    public partial class DictListCopyDialog : BasePopupForm
    {
        public string NewDictCode => txtNewCode.Text.Trim();

        public string NewDictName => txtNewName.Text.Trim();

        public DictListCopyDialog()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NewDictCode))
            {
                MessageBox.Show("字典代码不能为空！");
                txtNewCode.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(NewDictName))
            {
                MessageBox.Show("字典名称不能为空！");
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
