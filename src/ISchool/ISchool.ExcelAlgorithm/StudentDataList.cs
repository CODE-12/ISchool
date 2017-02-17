using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISchool.Model.ProjectModel;

namespace ISchool.ExcelAlgorithm
{
    public class StudentDataList : IExcelAlgo
    {
        /*Start Vars*/
        private int _counter { get; set; }
        private int _nameC { get; set; }
        private int _nationalC { get; set; }
        private int _specialC { get; set; }
        private int _enterDC { get; set; }
        private int _idTypeC { get; set; }
        private int _idNumC { get; set; }
        private int _brDC { get; set; }
        private int _statusC { get; set; }
        private int _gadeTypeC { get; set; }
        /*End Vars*/
        public StudentDataList(string path) : base(path)
        { }

        public async override Task<DataTable> Load()
        {
            int pageNumber = 1;
            _sheet = (Microsoft.Office.Interop.Excel.Worksheet)_book.Worksheets.get_Item(1);
            _counter = 1;
            _nameC = 1;
            _nationalC = 1;
            _specialC = 1;
            _enterDC = 1;
            _idTypeC = 1;
            _idNumC = 1;
            _brDC = 1;
            _statusC = 1;
            _gadeTypeC = 1;
            for (int i = 1; i < 35; i++)//Rows
                for (int i2 = 1; i2 < 35; i2++)//Column
                {
                    if (Convert.ToString(_sheet.Cells[i, i2].Value) == "اسم الطالب")
                    {
                        _nameC = i2;
                        _counter = i;
                    }
                    if (Convert.ToString(_sheet.Cells[i, i2].Value) == "الجنسية")
                        _nationalC = i2;
                    if (Convert.ToString(_sheet.Cells[i, i2].Value) == "التخصص")
                        _specialC = i2;
                    if (Convert.ToString(_sheet.Cells[i, i2].Value) == "سنة")
                        _enterDC = i2;
                    if (Convert.ToString(_sheet.Cells[i, i2].Value) == "نوعها")
                        _idTypeC = i2;
                    if (Convert.ToString(_sheet.Cells[i, i2].Value) == "رقمها")
                        _idNumC = i2;
                    if (Convert.ToString(_sheet.Cells[i, i2].Value) == "تاريخ الميلاد")
                        _brDC = i2;
                    if (Convert.ToString(_sheet.Cells[i, i2].Value) == "سجل الطالب")
                        _statusC = i2;
                    if (Convert.ToString(_sheet.Cells[i, i2].Value) == "حالة القيد")
                        _gadeTypeC = i2;
                }
            List<Student> students = new List<Student>();
            try
            {
                while (true)
                {
                    Student s1 = GetStudentData((Microsoft.Office.Interop.Excel.Worksheet)_book.Worksheets.get_Item(pageNumber), _counter + 2);
                    Student s2 = GetStudentData((Microsoft.Office.Interop.Excel.Worksheet)_book.Worksheets.get_Item(pageNumber), _counter + 4);
                    Student s3 = GetStudentData((Microsoft.Office.Interop.Excel.Worksheet)_book.Worksheets.get_Item(pageNumber), _counter + 6);
                    Student s4 = GetStudentData((Microsoft.Office.Interop.Excel.Worksheet)_book.Worksheets.get_Item(pageNumber), _counter + 8);
                    Student s5 = GetStudentData((Microsoft.Office.Interop.Excel.Worksheet)_book.Worksheets.get_Item(pageNumber), _counter + 10);
                    Student s6 = GetStudentData((Microsoft.Office.Interop.Excel.Worksheet)_book.Worksheets.get_Item(pageNumber), _counter + 12);
                    Student s7 = GetStudentData((Microsoft.Office.Interop.Excel.Worksheet)_book.Worksheets.get_Item(pageNumber), _counter + 14);
                    Student s8 = GetStudentData((Microsoft.Office.Interop.Excel.Worksheet)_book.Worksheets.get_Item(pageNumber), _counter + 16);
                    Student s9 = GetStudentData((Microsoft.Office.Interop.Excel.Worksheet)_book.Worksheets.get_Item(pageNumber), _counter + 18);
                    Student s10 = GetStudentData((Microsoft.Office.Interop.Excel.Worksheet)_book.Worksheets.get_Item(pageNumber), _counter + 20);
                    if (s1 == null)
                        throw new Exception();
                    students.Add(s1);
                    if (s2 == null)
                        throw new Exception();
                    students.Add(s2);
                    if (s3 == null)
                        throw new Exception();
                    students.Add(s3);
                    if (s4 == null)
                        throw new Exception();
                    students.Add(s4);
                    if (s5 == null)
                        throw new Exception();
                    students.Add(s5);
                    if (s6 == null)
                        throw new Exception();
                    students.Add(s6);
                    if (s7 == null)
                        throw new Exception();
                    students.Add(s7);
                    if (s8 == null)
                        throw new Exception();
                    students.Add(s8);
                    if (s9 == null)
                        throw new Exception();
                    students.Add(s9);
                    if (s10 == null)
                        throw new Exception();
                    students.Add(s10);
                    pageNumber++;
                }
            }
            catch (Exception)
            { }
            this._result.Columns.AddRange(new DataColumn[] {
                new DataColumn("اسم الطالب"),
                new DataColumn("التخصص"),
                new DataColumn("الجنسية"),
                new DataColumn("سنة الدخول"),
                new DataColumn("نوع الهوية"),
                new DataColumn("رقم الهوية"),
                new DataColumn("تاريخ الميلاد"),
                new DataColumn("سجل الطالب"),
                new DataColumn("حالة القيد")
            });
            foreach (Student item in students)
            {
                this._result.Rows.Add(item.Name, item.Specialize, item.Nationality, item.Enterdate, item.IdType, item.IdNumber, item.BrDate, item.StudentStatus, item.GadeStatus);
            }
            _sheet = null;
            _book = null;
            return _result;
        }

        private Student GetStudentData(Microsoft.Office.Interop.Excel.Worksheet Sheet, int Row)
        {
            if (Sheet.Cells[Row, _nameC].Value == null)
                return null;
            Student stu = new Student()
            {
                Name = Sheet.Cells[Row, _nameC].Value,
                Specialize = Sheet.Cells[Row, _specialC].Value,
                Nationality = Sheet.Cells[Row, _nationalC].Value,
                Enterdate = Sheet.Cells[Row, _enterDC].Value,
                IdType = Sheet.Cells[Row, _idTypeC].Value,
                IdNumber = Sheet.Cells[Row, _idNumC].Value,
                BrDate = Sheet.Cells[Row, _brDC].Value,
                StudentStatus = Sheet.Cells[Row, _statusC].Value,
                GadeStatus = Sheet.Cells[Row, _gadeTypeC].Value
            };
            return stu;
        }
    }
}
