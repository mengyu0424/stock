using ClassLibrary;
using System;
using System.Windows.Forms;
using WindowsFormsApp.主窗体;
using WindowsFormsApp.登录;

namespace WindowsFormsApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            登录页面 login = new 登录页面();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm(GlobalInfo.userInfo.Name));
            }
        }
    }
}
