using ClassLibrary;
using System;
using System.Data;
using WindowsFormsApp.主窗体;

namespace WindowsFormsApp.维护功能
{
    public partial class MenuEdit : BasePopupForm
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="winType">弹窗用途 Add-新增 Edit-修改 View-查看</param>
        /// <param name="dt"></param>
        public MenuEdit(string winType, string orgCode, DataTable dt)
        {
            InitializeComponent();
            if (winType == "Add")
            {
                MenuAddLoad(orgCode);
            }
            else if (winType == "Edit")
            {
            }
            else
            {
            }
        }

        private void MenuEdit_Load(object sender, EventArgs e)
        {
            cmbOrg.DataSource = GlobalInfo.orgData;
            cmbOrg.DisplayMember = "NAME";
            cmbOrg.ValueMember = "CODE";
            cmbOrg.SelectedValue = GlobalInfo.userInfo.orgCode;
            cmbOrg.Enabled = false;//暂时机构就一个，不允许修改
        }

        /// <summary>
        ///
        /// </summary>
        private void MenuAddLoad(string orgCode)
        {
        }

        private void MenuEditLoad(DataTable dt)
        {
        }

        private void myButton2_Click(object sender, EventArgs e)
        {
            base.Dispose();
            this.Close();
        }
    }
}