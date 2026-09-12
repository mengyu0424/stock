using System;
using System.Data;
using System.Globalization;

namespace WindowsFormsApp.库房业务
{
    public static class InStorageValidation
    {
        public static bool IsPositiveInteger(string value)
        {
            string text = (value ?? string.Empty).Trim();
            if (text.Length == 0)
            {
                return false;
            }

            for (int index = 0; index < text.Length; index++)
            {
                if (text[index] < '0' || text[index] > '9')
                {
                    return false;
                }
            }

            int number;
            return int.TryParse(text, NumberStyles.None, CultureInfo.InvariantCulture, out number)
                   && number > 0;
        }

        public static bool IsPositivePrice(string value)
        {
            string text = (value ?? string.Empty).Trim();
            decimal price;
            if (text.Length == 0
                || !TryParseDecimal(text, out price)
                || price <= 0)
            {
                return false;
            }

            int scale = (decimal.GetBits(price)[3] >> 16) & 0x7f;
            return scale <= 4;
        }

        public static string GetNextBatchNumber(
            DataTable details,
            string code,
            string lotNumber,
            DataRow excludedRow)
        {
            int maximum = 0;
            if (details == null)
            {
                return "1";
            }

            foreach (DataRow row in details.Rows)
            {
                if (row.RowState == DataRowState.Deleted
                    || row == excludedRow
                    || !IsSameScope(row, code, lotNumber))
                {
                    continue;
                }

                string batchNumber = GetRowString(row, "PC");
                if (!IsPositiveInteger(batchNumber))
                {
                    continue;
                }

                int batchValue;
                if (int.TryParse(batchNumber.Trim(), NumberStyles.None, CultureInfo.InvariantCulture, out batchValue)
                    && batchValue > maximum)
                {
                    maximum = batchValue;
                }
            }

            return maximum == int.MaxValue
                ? string.Empty
                : (maximum + 1).ToString(CultureInfo.InvariantCulture);
        }

        public static bool HasDuplicateBatchNumber(
            DataTable details,
            string code,
            string lotNumber,
            string batchNumber,
            DataRow excludedRow)
        {
            if (details == null || !IsPositiveInteger(batchNumber))
            {
                return false;
            }

            int expectedBatchNumber;
            int.TryParse(batchNumber.Trim(), NumberStyles.None, CultureInfo.InvariantCulture, out expectedBatchNumber);

            foreach (DataRow row in details.Rows)
            {
                if (row.RowState == DataRowState.Deleted
                    || row == excludedRow
                    || !IsSameScope(row, code, lotNumber))
                {
                    continue;
                }

                string currentBatchNumber = GetRowString(row, "PC");
                int currentBatchValue;
                if (IsPositiveInteger(currentBatchNumber)
                    && int.TryParse(currentBatchNumber.Trim(), NumberStyles.None, CultureInfo.InvariantCulture, out currentBatchValue)
                    && currentBatchValue == expectedBatchNumber)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool TryParseDecimal(string text, out decimal value)
        {
            const NumberStyles styles = NumberStyles.AllowDecimalPoint;
            return decimal.TryParse(text, styles, CultureInfo.CurrentCulture, out value)
                   || decimal.TryParse(text, styles, CultureInfo.InvariantCulture, out value);
        }

        private static bool IsSameScope(DataRow row, string code, string lotNumber)
        {
            return string.Equals(GetRowString(row, "CODE").Trim(), (code ?? string.Empty).Trim(), StringComparison.OrdinalIgnoreCase)
                   && string.Equals(GetRowString(row, "PH").Trim(), (lotNumber ?? string.Empty).Trim(), StringComparison.OrdinalIgnoreCase);
        }

        private static string GetRowString(DataRow row, string columnName)
        {
            return row != null
                   && row.Table != null
                   && row.Table.Columns.Contains(columnName)
                   && row[columnName] != DBNull.Value
                ? row[columnName].ToString()
                : string.Empty;
        }
    }
}
