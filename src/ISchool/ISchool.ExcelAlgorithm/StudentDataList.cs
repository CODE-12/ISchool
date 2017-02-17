using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISchool.ExcelAlgorithm
{
    public class StudentDataList : IExcelAlgo
    {
        /*Start Vars*/
        private int _start { get; set; }
        private int _nameC { get; set; }
        private int _nationalC { get; set; }
        private int _specialC { get; set; }
        private int _enterDC { get; set; }
        private int _idTypeC { get; set; }
        private int _idNumC { get; set; }
        private int _brDC { get; set; }
        private int _statusC { get; set; }
        private int _gadeTypeC { get; set; }
        private DataTable _reault { get; set; }
        /*End Vars*/
        public StudentDataList(string path) : base(path)
        {

        }

        protected override void Load()
        {
            throw new NotImplementedException();
        }

        protected override DataTable GetDataShow()
        {
            return _reault;
        }
    }
}
