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
        private int Counter { get; set; }
        private int NameC { get; set; }
        private int NationalC { get; set; }
        private int SpecialC { get; set; }
        private int EnterDc { get; set; }
        private int IdTypeC { get; set; }
        private int IdNumC { get; set; }
        private int BrDc { get; set; }
        private int StatusC { get; set; }
        private int GadeTypeC { get; set; }
        /*End Vars*/
        public StudentDataList(string path) : base(path)
        { }

        public async override Task<DataTable> Load()
        {
            int pageNumber = 1;
            Sheet = (Microsoft.Office.Interop.Excel.Worksheet)Book.Worksheets.get_Item(1);
            Counter = 1;
            NameC = 1;
            NationalC = 1;
            SpecialC = 1;
            EnterDc = 1;
            IdTypeC = 1;
            IdNumC = 1;
            BrDc = 1;
            StatusC = 1;
            GadeTypeC = 1;
            for (int i = 1; i < 35; i++)//Rows
                for (int i2 = 1; i2 < 35; i2++)//Column
                {
                    if (Convert.ToString(Sheet.Cells[i, i2].Value) == "اسم الطالب")
                    {
                        NameC = i2;
                        Counter = i;
                    }
                    if (Convert.ToString(Sheet.Cells[i, i2].Value) == "الجنسية")
                        NationalC = i2;
                    if (Convert.ToString(Sheet.Cells[i, i2].Value) == "التخصص")
                        SpecialC = i2;
                    if (Convert.ToString(Sheet.Cells[i, i2].Value) == "سنة")
                        EnterDc = i2;
                    if (Convert.ToString(Sheet.Cells[i, i2].Value) == "نوعها")
                        IdTypeC = i2;
                    if (Convert.ToString(Sheet.Cells[i, i2].Value) == "رقمها")
                        IdNumC = i2;
                    if (Convert.ToString(Sheet.Cells[i, i2].Value) == "تاريخ الميلاد")
                        BrDc = i2;
                    if (Convert.ToString(Sheet.Cells[i, i2].Value) == "سجل الطالب")
                        StatusC = i2;
                    if (Convert.ToString(Sheet.Cells[i, i2].Value) == "حالة القيد")
                        GadeTypeC = i2;
                }
            List<Student> students = new List<Student>();
            try
            {
                while (true)
                {
                    Student s1 = GetStudentData((Microsoft.Office.Interop.Excel.Worksheet)Book.Worksheets.get_Item(pageNumber), Counter + 2);
                    Student s2 = GetStudentData((Microsoft.Office.Interop.Excel.Worksheet)Book.Worksheets.get_Item(pageNumber), Counter + 4);
                    Student s3 = GetStudentData((Microsoft.Office.Interop.Excel.Worksheet)Book.Worksheets.get_Item(pageNumber), Counter + 6);
                    Student s4 = GetStudentData((Microsoft.Office.Interop.Excel.Worksheet)Book.Worksheets.get_Item(pageNumber), Counter + 8);
                    Student s5 = GetStudentData((Microsoft.Office.Interop.Excel.Worksheet)Book.Worksheets.get_Item(pageNumber), Counter + 10);
                    Student s6 = GetStudentData((Microsoft.Office.Interop.Excel.Worksheet)Book.Worksheets.get_Item(pageNumber), Counter + 12);
                    Student s7 = GetStudentData((Microsoft.Office.Interop.Excel.Worksheet)Book.Worksheets.get_Item(pageNumber), Counter + 14);
                    Student s8 = GetStudentData((Microsoft.Office.Interop.Excel.Worksheet)Book.Worksheets.get_Item(pageNumber), Counter + 16);
                    Student s9 = GetStudentData((Microsoft.Office.Interop.Excel.Worksheet)Book.Worksheets.get_Item(pageNumber), Counter + 18);
                    Student s10 = GetStudentData((Microsoft.Office.Interop.Excel.Worksheet)Book.Worksheets.get_Item(pageNumber), Counter + 20);
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
            this.Result.Columns.AddRange(new DataColumn[] {
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
                this.Result.Rows.Add(item.Name, item.Specialize, item.Nationality, item.Enterdate, item.IdType, item.IdNumber, item.BrDate, item.StudentStatus, item.GadeStatus);
            }
            Sheet = null;
            Book = null;
            return Result;
        }

        private Student GetStudentData(Microsoft.Office.Interop.Excel.Worksheet Sheet, int Row)
        {
            if (Sheet.Cells[Row, NameC].Value == null)
                return null;
            Student stu = new Student()
            {
                Name = Sheet.Cells[Row, NameC].Value,
                Specialize = Sheet.Cells[Row, SpecialC].Value,
                Nationality = Sheet.Cells[Row, NationalC].Value,
                Enterdate = Sheet.Cells[Row, EnterDc].Value,
                IdType = Sheet.Cells[Row, IdTypeC].Value,
                IdNumber = Sheet.Cells[Row, IdNumC].Value,
                BrDate = Sheet.Cells[Row, BrDc].Value,
                StudentStatus = Sheet.Cells[Row, StatusC].Value,
                GadeStatus = Sheet.Cells[Row, GadeTypeC].Value
            };
            return stu;
        }
    }
}
