using System;
using System.Data;
using System.IO;
using System.Reflection;

internal static class Program
{
    private static int Main()
    {
        try
        {
            ShouldAcceptPositiveIntegerBatchNumbers();
            ShouldRejectInvalidBatchNumbers();
            ShouldGenerateTheNextBatchNumberForTheSameItemAndLot();
            ShouldRejectDuplicateBatchNumbersForTheSameItemAndLot();
            ShouldValidatePricesWithAtMostFourDecimalPlaces();
            ShouldValidatePositiveIntegerQuantities();
            ShouldConfigureInstallerWithoutOverridingInstallLocation();
            Console.WriteLine("All InStorage validation tests passed.");
            return 0;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine(ex.Message);
            return 1;
        }
    }

    private static void ShouldAcceptPositiveIntegerBatchNumbers()
    {
        AssertTrue(IsPositiveInteger("1"), "Batch number 1 should be valid.");
        AssertTrue(IsPositiveInteger("12"), "Batch number 12 should be valid.");
    }

    private static void ShouldRejectInvalidBatchNumbers()
    {
        AssertFalse(IsPositiveInteger(""), "An empty batch number should be invalid.");
        AssertFalse(IsPositiveInteger("0"), "Batch number 0 should be invalid.");
        AssertFalse(IsPositiveInteger("1.5"), "A decimal batch number should be invalid.");
        AssertFalse(IsPositiveInteger("A1"), "An alphabetic batch number should be invalid.");
    }

    private static void ShouldGenerateTheNextBatchNumberForTheSameItemAndLot()
    {
        DataTable details = CreateDetails();
        details.Rows.Add("WP001", "LOT-A", "1");
        details.Rows.Add("WP001", "LOT-A", "2");
        details.Rows.Add("WP001", "LOT-B", "8");
        details.Rows.Add("WP002", "LOT-A", "9");

        AssertEqual("3", GetNextBatchNumber(details, "WP001", "LOT-A", null));
        AssertEqual("1", GetNextBatchNumber(details, "WP003", "LOT-A", null));
    }

    private static void ShouldRejectDuplicateBatchNumbersForTheSameItemAndLot()
    {
        DataTable details = CreateDetails();
        DataRow firstRow = details.Rows.Add("WP001", "LOT-A", "1");
        details.Rows.Add("WP001", "LOT-B", "1");

        AssertTrue(HasDuplicateBatchNumber(details, "WP001", "LOT-A", "1", null), "Duplicate batch number should be detected.");
        AssertFalse(HasDuplicateBatchNumber(details, "WP001", "LOT-A", "2", null), "A new batch number should not be detected as duplicate.");
        AssertFalse(HasDuplicateBatchNumber(details, "WP001", "LOT-A", "1", firstRow), "The row being edited should not conflict with itself.");
    }

    private static void ShouldValidatePricesWithAtMostFourDecimalPlaces()
    {
        AssertTrue(IsPositivePrice("0.0001"), "Price with four decimals should be valid.");
        AssertTrue(IsPositivePrice("12.3456"), "Price with four decimals should be valid.");
        AssertFalse(IsPositivePrice("0"), "Zero price should be invalid.");
        AssertFalse(IsPositivePrice("12.34567"), "Price with five decimals should be invalid.");
        AssertFalse(IsPositivePrice("abc"), "Non-numeric price should be invalid.");
    }

    private static void ShouldValidatePositiveIntegerQuantities()
    {
        AssertTrue(IsPositiveInteger("1"), "Quantity 1 should be valid.");
        AssertFalse(IsPositiveInteger("0"), "Quantity 0 should be invalid.");
        AssertFalse(IsPositiveInteger("1.0"), "Decimal quantity should be invalid.");
    }

    private static void ShouldConfigureInstallerWithoutOverridingInstallLocation()
    {
        string projectRoot = FindProjectRoot();
        string installerPath = Directory.GetFiles(projectRoot, "*.vdproj", SearchOption.AllDirectories)[0];
        string installerProject = File.ReadAllText(installerPath);
        string solutionProject = File.ReadAllText(
            Path.Combine(projectRoot, "WindowsFormsApp", "WindowsFormsApp.sln"));
        string uninstallerPath = Path.Combine(
            projectRoot,
            "\u5378\u8f7d\u7a0b\u5e8f",
            "\u5378\u8f7d\u7a0b\u5e8f.csproj");
        string uninstallerProgramPath = Path.Combine(
            projectRoot,
            "\u5378\u8f7d\u7a0b\u5e8f",
            "Program.cs");
        string installerLauncherPath = Path.Combine(
            projectRoot,
            "\u5b89\u88c5\u542f\u52a8\u5668",
            "Program.cs");

        AssertTrue(File.Exists(uninstallerPath), "The uninstaller project should exist.");
        AssertTrue(File.Exists(uninstallerProgramPath), "The uninstaller program source should exist.");
        AssertTrue(File.Exists(installerLauncherPath), "The installer launcher source should exist.");
        AssertTrue(
            installerProject.Contains(
                "DefaultLocation\" = \"8:[ProgramFilesFolder][Manufacturer]\\\\[ProductName]"),
            "The installer should use its standard install location.");
        AssertTrue(
            installerProject.Contains("Name\" = \"8:#1925\""),
            "The installer should retain its standard target directory name.");
        AssertTrue(
            installerProject.Contains("<VsdDialogDir>\\\\VsdFolderDlg.wid"),
            "The installer should let users choose an install folder.");
        AssertTrue(
            installerProject.Contains(
                "SourcePath\" = \"8:..\\\\\u5378\u8f7d\u7a0b\u5e8f\\\\bin\\\\\u5378\u8f7d\u68a6\u5c7f\u8fdb\u9500\u5b58\u7a0b\u5e8f.exe"),
            "The installer should include the uninstall executable.");
        AssertTrue(
            installerProject.Contains(
                "TargetName\" = \"8:\u5378\u8f7d\u68a6\u5c7f\u8fdb\u9500\u5b58\u7a0b\u5e8f.exe"),
            "The installer should preserve the uninstall executable name.");
        AssertTrue(
            File.ReadAllText(uninstallerProgramPath).Contains(
                "ProductCode = \"{2AB199DB-01FE-4A39-8FF7-6DE42FA99497}\""),
            "The uninstall executable should target this MSI product.");
        string installerLauncher = File.ReadAllText(installerLauncherPath);
        AssertFalse(
            installerLauncher.Contains("ROOTDRIVE="),
            "The installer launcher should not override MSI's install drive.");
        AssertFalse(
            installerLauncher.Contains("DriveInfo"),
            "The installer launcher should not select an install drive.");
        AssertFalse(
            installerLauncher.Contains("TARGETDIR="),
            "The installer launcher should not override MSI's TARGETDIR directory tree.");
        AssertTrue(
            solutionProject.Contains(
                "ProjectSection(ProjectDependencies) = postProject\n\t\t{E8C4E7D8-4C2C-4D03-8B70-AF8137D5E7F4} = {E8C4E7D8-4C2C-4D03-8B70-AF8137D5E7F4}"),
            "The installer project should build the uninstaller first.");
    }

    private static string FindProjectRoot()
    {
        string directory = AppContext.BaseDirectory;
        while (!string.IsNullOrEmpty(directory))
        {
            if (File.Exists(Path.Combine(directory, "WindowsFormsApp", "WindowsFormsApp.sln")))
            {
                return directory;
            }

            directory = Directory.GetParent(directory)?.FullName;
        }

        throw new DirectoryNotFoundException("Could not locate the project root.");
    }

    private static DataTable CreateDetails()
    {
        DataTable details = new DataTable();
        details.Columns.Add("CODE", typeof(string));
        details.Columns.Add("PH", typeof(string));
        details.Columns.Add("PC", typeof(string));
        return details;
    }

    private static bool IsPositiveInteger(string value)
    {
        return (bool)InvokeValidationMethod("IsPositiveInteger", value);
    }

    private static bool IsPositivePrice(string value)
    {
        return (bool)InvokeValidationMethod("IsPositivePrice", value);
    }

    private static string GetNextBatchNumber(DataTable details, string code, string lotNumber, DataRow excludedRow)
    {
        return (string)InvokeValidationMethod("GetNextBatchNumber", details, code, lotNumber, excludedRow);
    }

    private static bool HasDuplicateBatchNumber(DataTable details, string code, string lotNumber, string batchNumber, DataRow excludedRow)
    {
        return (bool)InvokeValidationMethod("HasDuplicateBatchNumber", details, code, lotNumber, batchNumber, excludedRow);
    }

    private static object InvokeValidationMethod(string methodName, params object[] arguments)
    {
        Type validationType = Assembly.GetExecutingAssembly().GetType(
            "WindowsFormsApp.\u5e93\u623f\u4e1a\u52a1.InStorageValidation");
        if (validationType == null)
        {
            throw new InvalidOperationException("InStorageValidation is not implemented.");
        }

        MethodInfo method = validationType.GetMethod(methodName, BindingFlags.Public | BindingFlags.Static);
        if (method == null)
        {
            throw new InvalidOperationException(string.Format("InStorageValidation.{0} is not implemented.", methodName));
        }

        return method.Invoke(null, arguments);
    }

    private static void AssertTrue(bool condition, string message)
    {
        if (!condition)
        {
            throw new InvalidOperationException(message);
        }
    }

    private static void AssertFalse(bool condition, string message)
    {
        AssertTrue(!condition, message);
    }

    private static void AssertEqual(string expected, string actual)
    {
        if (!string.Equals(expected, actual, StringComparison.Ordinal))
        {
            throw new InvalidOperationException(string.Format("Expected [{0}], actual [{1}].", expected, actual));
        }
    }
}
