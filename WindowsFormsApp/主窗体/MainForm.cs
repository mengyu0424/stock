using ClassHelper;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp.主窗体
{
    public partial class MainForm : Form
    {
        private string csbz = ConfigurationManager.AppSettings["csbz"];
        private DataTable menuDT;
        private Dictionary<string, Type> _menuFormTypeMap = new Dictionary<string, Type>();
        private Dictionary<string, TabButton> _openedTabMap = new Dictionary<string, TabButton>();
        private Dictionary<string, Form> _openedFormCache = new Dictionary<string, Form>();
        private Form _currentForm;
        private readonly string _loginUser;

        public MainForm(string userName)
        {
            InitializeComponent();
            _loginUser = userName;
            lblUserInfo.Text = $"当前登录用户: {_loginUser}";

            LoadMenuData();
            BuildTreeViewMenu();     // 构建 TreeView 菜单
            this.WindowState = FormWindowState.Maximized;
        }

        private void LoadMenuData()
        {
            if (csbz=="1")
            {
                menuDT = new DataTable();
                menuDT.Columns.Add("FATHERCODE", typeof(string));   // 对应FatherID
                menuDT.Columns.Add("FATHERNAME", typeof(string));  // 对应TypeName
                menuDT.Columns.Add("FATHERSXH", typeof(int));      // 父类排序号（示例用0，可自定义）
                menuDT.Columns.Add("CODE", typeof(string));        // 对应ID
                menuDT.Columns.Add("NAME", typeof(string));        // 对应Name
                menuDT.Columns.Add("PATH", typeof(string));       // 对应Url
                menuDT.Columns.Add("SXH", typeof(int));            // 菜单排序号（示例用0，可自定义）

                // 2. 插入第一张图的模拟数据，严格对应列
                // 分类一（FatherID=1，TypeName=分类一）
                menuDT.Rows.Add("1", "分类一", 1, "101", "菜单1", "WindowsFormsApp.测试菜单.cshtml1", 1);
                menuDT.Rows.Add("1", "分类一", 1, "102", "菜单2", "WindowsFormsApp.测试菜单.cshtml2", 3);
                // 分类二（FatherID=2，TypeName=分类二）
                menuDT.Rows.Add("2", "分类二", 2, "201", "菜单3", "WindowsFormsApp.测试菜单.cshtml3", 2);
                menuDT.Rows.Add("2", "分类二", 2, "202", "长名称测试菜单", "WindowsFormsApp测试菜单.cshtml1", 4);
            }
            else
            {
                string sql = string.Format(@" select e.code fathercode,e.name fathername,e.sxh fathersxh,d.code,d.name,d.path,d.sxh from code_czydm a
                                                                    left join code_czy_usertype b on a.code=b.czycode and a.orgcode=b.orgcode and b.flag=1
                                                                    left join code_menu_assign c on b.usertypecode=c.usertypecode and b.orgcode=c.orgcode and c.flag=1
                                                                    left join code_menu d on c.menucode=d.code and d.orgcode=c.orgcode and d.flag=1 and d.menulevel=1
                                                                    left join code_menu e on d.fathercode=e.code and d.orgcode=e.orgcode and e.menulevel=0
                                                                    where a.code='{0}'
                                                                    and e.flag=1/*此处是筛选分类菜单关闭 则全部不显示*/
                                                                    and a.orgcode='{1}' ", GlobalInfo.userInfo.ID,GlobalInfo.userInfo.orgCode);
                menuDT = OracleDbHelper.ExecuteQuery(sql);
            }
        }

        private void BuildTreeViewMenu()
        {
            tvMenu.Nodes.Clear();
            if (menuDT == null || menuDT.Rows.Count <= 0) return;

            var fatherDs = menuDT.AsEnumerable().Select(row => new
            {
                FatherCode = row.IsNull("FATHERCODE") ? string.Empty : row["FATHERCODE"].ToString(),
                FatherName = row.IsNull("FATHERNAME") ? string.Empty : row["FATHERNAME"].ToString(),
                FatherSxh = row.IsNull("FATHERSXH") ? 0 : Convert.ToInt32(row["FATHERSXH"])
            }).Distinct().OrderBy(x => x.FatherSxh).ToList();
            for (int i = 0; i < fatherDs.Count(); i++)
            {
                var fatherItem = fatherDs[i];

                var menuInfos = menuDT.AsEnumerable()
                    .Where(row => row.Field<string>("FATHERCODE") == fatherItem.FatherCode)
                    .Select(row => new
                    {
                        Code = row.IsNull("CODE") ? string.Empty : row["CODE"].ToString(),
                        Name = row.IsNull("NAME") ? string.Empty : row["NAME"].ToString(),
                        Path = row.IsNull("PATH") ? string.Empty : row["PATH"].ToString(),
                        Sxh = row.IsNull("SXH") ? 0 : Convert.ToInt32(row["SXH"])
                    })
                    .OrderBy(o => o.Sxh) 
                    .ToList();

                TreeNode categoryNode = new TreeNode(fatherItem.FatherName.ToString());
                categoryNode.Tag = null;
                for (int j = 0; j < menuInfos.Count(); j++)
                {
                    var menuInfo = menuInfos[j];
                    TreeNode menuNode = new TreeNode(menuInfo.Name);
                    menuNode.Tag = menuInfo.Name;  // 存储菜单名称，用于打开窗体
                    categoryNode.Nodes.Add(menuNode);

                    // 解析并缓存窗体类型
                    ResolveAndCacheFormType(menuInfo.Name, menuInfo.Path);
                }
                tvMenu.Nodes.Add(categoryNode);
                // 默认展开分类
                categoryNode.Expand();
            }
        }

        private void ResolveAndCacheFormType(string menuName, string url)
        {
            if (string.IsNullOrWhiteSpace(url)) return;
            try
            {
                string typeFullName = url;
                string assemblyName = null;

                if (url.Contains('^'))
                {
                    string[] parts = url.Split('^');
                    if (parts.Length != 2) throw new FormatException("URL格式错误");
                    assemblyName = parts[0];
                    typeFullName = parts[1];
                }

                Type formType = Type.GetType(typeFullName);
                if (formType == null && !string.IsNullOrEmpty(assemblyName))
                {
                    Assembly assembly = assemblyName.EndsWith(".dll", StringComparison.OrdinalIgnoreCase)
                        ? Assembly.LoadFrom(assemblyName)
                        : Assembly.Load(assemblyName);
                    formType = assembly.GetType(typeFullName);
                }

                if (formType == null || !typeof(Form).IsAssignableFrom(formType))
                    throw new Exception("未找到有效的窗体类型");

                _menuFormTypeMap[menuName] = formType;
            }
            catch (Exception ex)
            {
                _menuFormTypeMap[menuName] = null;
                System.Diagnostics.Debug.WriteLine($"解析菜单 [{menuName}] 失败: {ex.Message}");
            }
        }

        private void tvMenu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // 只有叶子节点（菜单）才处理，分类节点不处理
            if (e.Node.Nodes.Count == 0 && e.Node.Tag != null)
            {
                string menuName = e.Node.Tag.ToString();
                OpenMenu(menuName);
            }
        }

        private void OpenMenu(string menuName)
        {
            if (string.IsNullOrEmpty(menuName)) return;

            // 如果已打开，切换到该标签
            if (_openedTabMap.ContainsKey(menuName))
            {
                TabButton existingTab = _openedTabMap[menuName];
                SwitchToTab(existingTab);
                return;
            }

            // 创建窗体实例并缓存
            Form newForm = CreateFormByMenuName(menuName);
            if (newForm == null) return;
            _openedFormCache[menuName] = newForm;

            // 创建标签按钮
            TabButton tab = new TabButton
            {
                TabText = menuName,
                IsSelected = true
            };
            tab.CloseClick += Tab_CloseClick;
            tab.TabSelected += Tab_TabSelected;

            flpTabBar.Controls.Add(tab);
            _openedTabMap[menuName] = tab;

            // 显示窗体
            ShowFormInContent(newForm);

            // 清除其他标签的选中状态
            foreach (TabButton other in flpTabBar.Controls)
            {
                if (other != tab) other.IsSelected = false;
            }
        }

        private Form CreateFormByMenuName(string menuName)
        {
            if (_menuFormTypeMap.TryGetValue(menuName, out Type formType) && formType != null)
            {
                try
                {
                    return (Form)Activator.CreateInstance(formType);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"创建窗体失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            else
            {
                MessageBox.Show($"未找到菜单 [{menuName}] 对应的窗体配置。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void ShowFormInContent(Form form)
        {
            pnlContent.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(form);
            form.Show();
            _currentForm = form;
        }

        private void SwitchToTab(TabButton tab)
        {
            if (tab.IsSelected) return;

            foreach (TabButton other in flpTabBar.Controls)
                other.IsSelected = (other == tab);

            string menuName = tab.TabText;
            if (_openedFormCache.TryGetValue(menuName, out Form cachedForm))
            {
                ShowFormInContent(cachedForm);
            }
            else
            {
                Form newForm = CreateFormByMenuName(menuName);
                if (newForm != null)
                {
                    _openedFormCache[menuName] = newForm;
                    ShowFormInContent(newForm);
                }
            }
        }

        private void Tab_TabSelected(object sender, EventArgs e)
        {
            TabButton tab = sender as TabButton;
            if (tab != null && !tab.IsSelected)
            {
                SwitchToTab(tab);
            }
        }

        private void Tab_CloseClick(object sender, EventArgs e)
        {
            TabButton tab = sender as TabButton;
            if (tab == null) return;

            string menuName = tab.TabText;

            flpTabBar.Controls.Remove(tab);
            tab.Dispose();
            _openedTabMap.Remove(menuName);

            if (_openedFormCache.TryGetValue(menuName, out Form form))
            {
                form.Close();
                form.Dispose();
                _openedFormCache.Remove(menuName);
            }

            if (_currentForm == form && _openedTabMap.Count > 0)
            {
                TabButton firstTab = flpTabBar.Controls[0] as TabButton;
                if (firstTab != null)
                    SwitchToTab(firstTab);
            }
            else if (_openedTabMap.Count == 0)
            {
                pnlContent.Controls.Clear();
                _currentForm = null;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (var form in _openedFormCache.Values)
            {
                form.Close();
                form.Dispose();
            }
            _openedFormCache.Clear();
            _openedTabMap.Clear();
            flpTabBar.Controls.Clear();
        }
    }
}