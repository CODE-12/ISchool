using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ISchool.ExcelAlgorithm
{
    public abstract class IExcelAlgo
    {
        protected Excel.Workbook Book { get; set; }
        protected Excel.Worksheet Sheet { get; set; }
        protected string Path { get; set; }
        protected DataTable Result { get; set; }
        public IExcelAlgo(string path)
        {
            this.Path = path;
            Excel.Application app = new Excel.Application();
            Book = app.Workbooks.Open(path, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            Result = new DataTable();
        }

        public abstract Task<DataTable> Load();
    }
}
