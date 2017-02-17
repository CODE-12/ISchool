using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace ISchool.ExcelAlgorithm
{
    public abstract class IExcelAlgo
    {
        protected string _path { get; set; }
        public IExcelAlgo(string path)
        {
            this._path = path;
            Task parralelWork = new Task(() => { this.Load(); });
            parralelWork.Start();
        }

        protected abstract void Load();

        protected abstract DataTable GetDataShow();
    }
}
