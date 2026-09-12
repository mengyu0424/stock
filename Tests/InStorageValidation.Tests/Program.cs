using System;
using System.Data;
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
        Type validationType = Assembly.GetExecutingAssembly().GetType("WindowsFormsApp.库房业务.InStorageValidation");
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
