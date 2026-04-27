using ClassHelper;
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
        public MenuEdit(string winType, DataTable dt)
        {
            InitializeComponent();
            MenuEdit_Load();
            if (winType == "Add")
            {
                MenuAddLoad();
            }
            else if (winType == "Edit")
            {
                MenuEditLoad(dt);
            }
            else
            {
            }
        }

        private void MenuEdit_Load()
        {
            //机构数据
            cmbOrg.DataSource = GlobalInfo.orgData;
            cmbOrg.DisplayMember = "NAME";
            cmbOrg.ValueMember = "CODE";
            cmbOrg.SelectedValue = GlobalInfo.userInfo.orgCode;
            cmbOrg.Enabled = false;//暂时机构就一个，不允许修改

            //上级菜单数据
            string sql = string.Format(@" select code,name from code_menu where menulevel='0' and flag='1' and orgcode='{0}' ", GlobalInfo.userInfo.orgCode);
            DataTable menuDt=OracleDbHelper.ExecuteQuery(sql);
            cmbFatherMenu.DataSource = menuDt;
            cmbFatherMenu.DisplayMember = "NAME";
            cmbFatherMenu.ValueMember = "CODE";

        }

        /// <summary>
        ///
        /// </summary>
        private void MenuAddLoad()
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