using ClassHelper;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
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
            dgv_fatherMenu.DataSource = FatherMenuLoad();
        }
        private void init() {
            //加载机构数据
            cmb_Org.DataSource = GlobalInfo.orgData;
            cmb_Org.DisplayMember = "NAME";
            cmb_Org.ValueMember = "CODE";
            cmb_Org.SelectedValue = GlobalInfo.userInfo.orgCode;
            cmb_Org.Enabled= false;//暂时机构就一个，不允许修改
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Clear();
            cmb_fatherMenu.DataSource= FatherMenuLoad();
            cmb_fatherMenu.DisplayMember = "NAME";
            cmb_fatherMenu.ValueMember = "CODE";
            cmb_fatherMenu.SelectedValue = "";
            cmb_fatherMenu.Enabled = true;
            menuCode.Text = GetMenuCode();
            menuName.Enabled = true;
            menuPath.Enabled = true;
            menuSxh.Enabled = true;
            menuFlag.Enabled = true;
            menuFlag.SelectedValue = "启用";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear();
            dgv_menu.DataSource = null;
            dgv_fatherMenu.DataSource = FatherMenuLoad();
        }


        private void Clear() 
        {
            cmb_fatherMenu.Enabled = false;
            cmb_fatherMenu.SelectedValue = "";
            menuCode.Enabled = false;
            menuCode.Text = "";
            menuName.Enabled = false;
            menuName.Text = "";
            menuPath.Enabled = false;
            menuPath.Text = "";
            menuSxh.Enabled = false;
            menuSxh.Text = "";
            menuFlag.Enabled = false;
            menuFlag.SelectedValue = "";
        }
        private DataTable FatherMenuLoad() {
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
                var row = dgv_fatherMenu.Rows[e.RowIndex];
                cmb_fatherMenu.DataSource = FatherMenuLoad();
                cmb_fatherMenu.DisplayMember = "NAME";
                cmb_fatherMenu.ValueMember = "CODE";
                if (!string.IsNullOrEmpty(row.Cells["CODE"].Value.ToString()))
                {
                    cmb_fatherMenu.SelectedValue = row.Cells["CODE"].Value.ToString();
                }
                else
                {
                    cmb_fatherMenu.SelectedValue = "";
                }
                cmb_fatherMenu.Enabled = true;
                menuCode.Text = GetMenuCode();
                menuName.Enabled = true;
                menuPath.Enabled = true;
                menuSxh.Enabled = true;
                menuFlag.Enabled = true;
                menuFlag.SelectedValue = "启用";
            }
        }

    }
}
