using ClassHelper;
using ClassLibrary;
using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp.主窗体;

namespace WindowsFormsApp.维护功能
{
    public partial class MenuSetting : BaseForm
    {
        public MenuSetting()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            //加载机构数据
            cmb_Org.DataSource = GlobalInfo.orgData;
            cmb_Org.DisplayMember = "NAME";
            cmb_Org.ValueMember = "CODE";
            cmb_Org.SelectedValue = GlobalInfo.userInfo.orgCode;
            cmb_Org.Enabled = false;//暂时机构就一个，不允许修改
            //页面加载菜单数据
            DataTable menuData = GetMenuData();
            dgvMenuList.DataSource = menuData;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            MenuEdit menuEdit = new MenuEdit("Add", null);
            menuEdit.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MenuEdit menuEdit = new MenuEdit("Edit", null);
            menuEdit.ShowDialog();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dgvMenuList.DataSource = null;
            DataTable menuData = GetMenuData();
            dgvMenuList.DataSource = menuData;
        }

        private DataTable GetMenuData()
        {
            string sql = string.Format(@"select m.fathercode,n.name fathername,m.code,m.name,m.pym,m.menulevel,m.flag,m.path,m.orgcode,o.name orgname,m.sxh,nvl(n.sxh,m.sxh) as fathersxh from code_menu m
                                                                left join code_menu n on m.fathercode=n.code and m.orgcode=n.orgcode
                                                                left join code_org o on m.orgcode=o.code
                                                                where m.orgcode='{0}'
                                                                order by nvl(n.sxh,m.sxh),m.menulevel,m.sxh ", cmb_Org.SelectedValue.ToString());
            return OracleDbHelper.ExecuteQuery(sql);
        }

        private DataTable FatherMenuLoad()
        {
            string sql = string.Format(@"select t.code,t.name,t.pym,t.sxh,case when t.flag=1 then '启用' else '禁用' end as flag from code_menu t
                                                                where t.orgcode='{0}'
                                                                and t.menulevel=0 order by t.sxh asc", cmb_Org.SelectedValue.ToString());
            return OracleDbHelper.ExecuteQuery(sql);
        }

        private string GetMenuCode()
        {
            string sql = string.Format(@" select max(code)+1 as code from code_menu where orgcode='{0}' ", cmb_Org.SelectedValue.ToString());
            return OracleDbHelper.ExecuteScalar(sql).ToString();
        }

        private void dgv_fatherMenu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
            }
        }
    }
}