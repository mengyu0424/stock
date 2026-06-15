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
            //页面加载菜单数据
            DataTable menuData = GetMenuData();
            dgvMenuList.DataSource = menuData;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            MenuEdit menuEdit = new MenuEdit("Add", null);
            menuEdit.Text = "新增菜单";
            menuEdit.ShowDialog();
            DataTable menuData = GetMenuData();
            dgvMenuList.DataSource = menuData;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var data = dgvMenuList.SelectedRows;
            DataTable dt=new DataTable();
            dt.Columns.Add("fatherCode", typeof(string));
            dt.Columns.Add("menuCode", typeof(string));
            dt.Columns.Add("menuName", typeof(string));
            dt.Columns.Add("pym", typeof(string));
            dt.Columns.Add("flag", typeof(string));
            dt.Columns.Add("sxh", typeof(string));
            dt.Columns.Add("path", typeof(string));
            dt.Columns.Add("menulevel", typeof(string));

            DataRow dr=dt.NewRow();
            dr["fatherCode"] = data[0].Cells["FATHERCODE"].Value.ToString();
            dr["menuCode"] = data[0].Cells["CODE"].Value.ToString();
            dr["menuName"] = data[0].Cells["NAME"].Value.ToString();
            dr["pym"] = data[0].Cells["PYM"].Value.ToString();
            dr["flag"] = data[0].Cells["FLAG"].Value.ToString();
            dr["sxh"] = data[0].Cells["SXH"].Value.ToString();
            dr["path"] = data[0].Cells["PATH"].Value.ToString();
            dr["menulevel"] = data[0].Cells["MENULEVEL"].Value.ToString(); 
            dt.Rows.Add(dr);

            MenuEdit menuEdit = new MenuEdit("Edit", dt);
            menuEdit.Text = "修改菜单";
            menuEdit.ShowDialog();
            DataTable menuData = GetMenuData();
            dgvMenuList.DataSource = menuData;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dgvMenuList.DataSource = null;
            DataTable menuData = GetMenuData();
            dgvMenuList.DataSource = menuData;
        }

        private DataTable GetMenuData()
        {
            string sql = string.Format(@"select m.fathercode,n.name fathername,m.code,m.name,m.pym,m.menulevel,m.flag,m.path,m.sxh,nvl(n.sxh,m.sxh) as fathersxh from code_menu m
                                                                left join code_menu n on m.fathercode=n.code
                                                                order by nvl(n.sxh,m.sxh),m.menulevel,m.sxh ");
            return OracleDbHelper.ExecuteQuery(sql);
        }
    }
}