using System;
using System.Diagnostics;
using System.Windows.Forms;

internal static class Program
{
    private const string ProductCode = "{2AB199DB-01FE-4A39-8FF7-6DE42FA99497}";

    [STAThread]
    private static void Main()
    {
        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "msiexec.exe",
                Arguments = "/x " + ProductCode,
                UseShellExecute = true,
                Verb = "runas"
            });
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "启动卸载程序失败：" + ex.Message,
                "梦屿进销存程序",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
