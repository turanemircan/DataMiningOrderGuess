using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace veri_madenciligi
{
    public class Excel
    {
        public static DataTable ReadExcelToDataTable(string filePath, string sheetName)
        {
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[sheetName];

                // Excel sayfasının boş olup olmadığını kontrol et
                if (worksheet.Dimension == null)
                {
                    throw new Exception("Excel sayfası boş.");
                }

                DataTable dt = new DataTable(sheetName);

                // Excel sayfasındaki sütun başlıklarını DataTable'a ekle
                foreach (var firstRowCell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
                {
                    dt.Columns.Add(firstRowCell.Text);
                }

                // Excel sayfasındaki verileri DataTable'a ekle
                for (int rowNumber = 2; rowNumber <= worksheet.Dimension.End.Row; rowNumber++)
                {
                    var row = worksheet.Cells[rowNumber, 1, rowNumber, worksheet.Dimension.End.Column];
                    DataRow newRow = dt.Rows.Add();
                    foreach (var cell in row)
                    {
                        newRow[cell.Start.Column - 1] = cell.Text;
                    }
                }

                return dt;
            }
        }
        public static void UpdateExcelFile(string filePath, DataTable dataTable)
        {
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                // Excel dosyasındaki verileri temizle
                worksheet.Cells.Clear();

                // DataTable'daki verileri Excel'e aktar
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dataTable.Columns[i].ColumnName;
                }

                for (int rowNumber = 0; rowNumber < dataTable.Rows.Count; rowNumber++)
                {
                    for (int columnNumber = 0; columnNumber < dataTable.Columns.Count; columnNumber++)
                    {
                        worksheet.Cells[rowNumber + 2, columnNumber + 1].Value = dataTable.Rows[rowNumber][columnNumber];
                    }
                }

                // Excel dosyasını kaydet
                package.Save();
            }
        }
    }
}
            
        
    

