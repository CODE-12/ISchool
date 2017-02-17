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
        protected Excel.Workbook _book { get; set; }
        protected Excel.Worksheet _sheet { get; set; }
        protected string _path { get; set; }
        protected DataTable _result { get; set; }
        public IExcelAlgo(string path)
        {
            this._path = path;
            Excel.Application app = new Excel.Application();
            _book = app.Workbooks.Open(path, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            _result = new DataTable();
        }

        public abstract Task<DataTable> Load();
    }
}
