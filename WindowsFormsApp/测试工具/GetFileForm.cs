using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp.测试工具
{
    public partial class GetFileForm : Form
    {
        public GetFileForm()
        {
            InitializeComponent();
        }

        #region 选择文件夹
        private void btnSelectSource_Click(object sender, EventArgs e)
        {
            SelectFolder(txtSourcePath, "请选择需要获取文件的源文件夹");
        }

        private void btnSelectTarget_Click(object sender, EventArgs e)
        {
            SelectFolder(txtTargetPath, "请选择文件存放的目标文件夹");
        }

        private void SelectFolder(TextBox targetTextBox, string description)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = description;
                folderBrowserDialog.ShowNewFolderButton = true;

                if (!string.IsNullOrWhiteSpace(targetTextBox.Text) &&
                    Directory.Exists(targetTextBox.Text.Trim()))
                {
                    folderBrowserDialog.SelectedPath = targetTextBox.Text.Trim();
                }

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    targetTextBox.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }
        #endregion

        #region 获取文件
        private void btnGetFiles_Click(object sender, EventArgs e)
        {
            string[] fileNameArray = txtFileName.Text.Split(
                new[] { '*' },
                StringSplitOptions.RemoveEmptyEntries);

            List<string> fileNames = new List<string>();
            HashSet<string> fileNameSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (string fileName in fileNameArray)
            {
                string cleanFileName = fileName.Trim();
                if (!string.IsNullOrEmpty(cleanFileName) && fileNameSet.Add(cleanFileName))
                {
                    fileNames.Add(cleanFileName);
                }
            }

            if (fileNames.Count == 0)
            {
                MessageBox.Show(
                    "请输入需要获取的文件名称，多个文件请使用*分隔！",
                    "提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string sourcePath = txtSourcePath.Text.Trim();
            string targetPath = txtTargetPath.Text.Trim();

            if (string.IsNullOrEmpty(sourcePath))
            {
                MessageBox.Show("请选择需要获取文件的源文件夹！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Directory.Exists(sourcePath))
            {
                MessageBox.Show("源文件夹不存在，请重新选择！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(targetPath))
            {
                MessageBox.Show("请选择文件存放的目标文件夹！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Directory.Exists(targetPath))
            {
                MessageBox.Show("目标文件夹不存在，请重新选择！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sourceFullPath;
            string targetFullPath;
            try
            {
                sourceFullPath = Path.GetFullPath(sourcePath)
                    .TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
                targetFullPath = Path.GetFullPath(targetPath)
                    .TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"文件夹路径无效：{ex.Message}",
                    "错误",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (string.Equals(sourceFullPath, targetFullPath, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "源文件夹和目标文件夹不能是同一个文件夹！",
                    "提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            List<string> copiedFiles = new List<string>();
            List<string> notFoundFiles = new List<string>();
            List<string> failedFiles = new List<string>();

            try
            {
                Dictionary<string, string> sourceFiles = new Dictionary<string, string>(
                    StringComparer.OrdinalIgnoreCase);

                foreach (string sourceFilePath in Directory.GetFiles(sourcePath, "*", SearchOption.TopDirectoryOnly))
                {
                    string sourceFileName = Path.GetFileName(sourceFilePath);
                    if (!sourceFiles.ContainsKey(sourceFileName))
                    {
                        sourceFiles.Add(sourceFileName, sourceFilePath);
                    }
                }

                foreach (string fileName in fileNames)
                {
                    string sourceFilePath;
                    if (!sourceFiles.TryGetValue(fileName, out sourceFilePath))
                    {
                        notFoundFiles.Add(fileName);
                        continue;
                    }

                    try
                    {
                        string targetFilePath = Path.Combine(targetPath, fileName);
                        File.Copy(sourceFilePath, targetFilePath, true);
                        copiedFiles.Add(fileName);
                    }
                    catch (Exception ex)
                    {
                        failedFiles.Add($"{fileName}：{ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"读取源文件夹失败：{ex.Message}",
                    "错误",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            StringBuilder resultMessage = new StringBuilder();
            resultMessage.AppendLine($"处理完成，成功获取 {copiedFiles.Count} 个文件。");

            if (notFoundFiles.Count > 0)
            {
                resultMessage.AppendLine();
                resultMessage.AppendLine("未找到的文件：");
                resultMessage.AppendLine(string.Join("、", notFoundFiles));
            }

            if (failedFiles.Count > 0)
            {
                resultMessage.AppendLine();
                resultMessage.AppendLine("获取失败的文件：");
                resultMessage.AppendLine(string.Join(Environment.NewLine, failedFiles));
            }

            MessageBox.Show(
                resultMessage.ToString(),
                "获取结果",
                MessageBoxButtons.OK,
                notFoundFiles.Count > 0 || failedFiles.Count > 0
                    ? MessageBoxIcon.Warning
                    : MessageBoxIcon.Information);
        }
        #endregion
    }
}
