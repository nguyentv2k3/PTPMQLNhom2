using System.Data; // Quan trọng
using OfficeOpenXml; // Nếu bạn dùng EPPlus
using System.IO;

namespace MvcMovie.Models.Process
{
    public class ExcelProcess
    {
        public DataTable ExcelToDataTable(string path)
        {
           ExcelPackage.LicenseContext = LicenseContext.NonCommercial;



            using (var package = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                DataTable dt = new DataTable();

                foreach (var firstRowCell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
                {
                    dt.Columns.Add(firstRowCell.Text);
                }

                for (int rowNum = 2; rowNum <= worksheet.Dimension.End.Row; rowNum++)
                {
                    var wsRow = worksheet.Cells[rowNum, 1, rowNum, worksheet.Dimension.End.Column];
                    DataRow row = dt.NewRow();
                    for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                    {
                        row[col - 1] = worksheet.Cells[rowNum, col].Text;
                    }
                    dt.Rows.Add(row);
                }

                return dt;
            }
        }
    }
}