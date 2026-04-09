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
            FatherMenuLoad();
        }
        private void init() {
            //加载机构数据
            cmb_Org.DataSource = GlobalInfo.orgData;
            cmb_Org.DisplayMember = "NAME";
            cmb_Org.ValueMember = "CODE";
            cmb_Org.SelectedValue = GlobalInfo.userInfo.orgCode;
            cmb_Org.Enabled= false;//暂时机构就一个，不允许修改
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
            FatherMenuLoad();
        }


        private void Clear() {
            dgv_fatherMenu.DataSource = null;
            dgv_menu.DataSource = null;

            cmb_fatherMenu.Enabled = false;
            cmb_fatherMenu.SelectedText = "";
            menuCode.Enabled = false;
            menuCode.Text = "";
            menuName.Enabled = false;
            menuName.Text = "";
            menuPath.Enabled = false;
            menuPath.Text = "";
            menuSxh.Enabled = false;
            menuSxh.Text = "";
            menuFlag.Enabled = false;
            menuFlag.SelectedText = "";
        }
        private void FatherMenuLoad() {
            string sql = string.Format(@"select t.code,t.name,t.pym,t.sxh,t.flag from code_menu t 
                                                                where t.orgcode='{0}'
                                                                and t.menulevel=0 ", cmb_Org.SelectedValue.ToString());
            DataTable dt= OracleDbHelper.ExecuteQuery(sql);
            dgv_fatherMenu.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_fatherMenu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgv_fatherMenu.Rows[e.RowIndex];
                // 处理选中行
            }
        }
    }
}
