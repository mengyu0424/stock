using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

internal static class Program
{
    private const string InstallerFileName = "库存进销存程序.msi";
    private const string ProductName = "梦屿进销存程序";

    [STAThread]
    private static void Main()
    {
        string installerPath = Path.Combine(AppContext.BaseDirectory, InstallerFileName);
        if (!File.Exists(installerPath))
        {
            MessageBox.Show(
                "未找到安装包：" + InstallerFileName,
                ProductName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "msiexec.exe",
                Arguments = string.Format("/i \"{0}\"", installerPath),
                UseShellExecute = true,
                Verb = "runas"
            });
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "启动安装程序失败：" + ex.Message,
                ProductName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

}
