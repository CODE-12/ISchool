using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ISchool.Model;

namespace ISchool.Server.Configuration
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Setter" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Setter.svc or Setter.svc.cs at the Solution Explorer and start debugging.
    public class Setter : ISetter
    {
        public int ChangeStudentPhoneNumber(int StudentId, string PhoneNumber)
        {
            using (ISchoolData Data = new ISchoolData())
            {
                try
                {
                    var Student = Data.isch_Students.Where(stu => stu.st_id == StudentId);
                    if (Student.Count() != 1)
                        return 0;
                    Student.First().st_PhoneNumber = PhoneNumber;
                    Data.SaveChanges();
                    return 1;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }

        public int PutAbsence(int StudentId, int AbsenceType, DateTime Date, int Subject)
        {
            using (ISchoolData Data = new ISchoolData())
            {
                try
                {
                    Data.isch_Absences.Add(new isch_Absences() {
                        a_Date = DateTime.Now,
                        a_Student = StudentId,
                        a_Type = AbsenceType,
                        a_Subject = Subject
                    });
                    Data.SaveChanges();
                    return 1;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }

        public int PutExcuse(int AbsenceId, int ByUserId, string Excuse, DateTime EnterDate)
        {
            using (ISchoolData Data = new ISchoolData())
            {
                try
                {
                    DateTime Now = DateTime.Now;
                    Data.isch_Excuses.Add(new isch_Excuses() {
                        e_EnterDate = Now,
                        e_Text = Excuse,
                        e_User = ByUserId,
                    });
                    Data.SaveChanges();
                    var SelectedExcuse = Data.isch_Excuses.Where(Excu => (Excu.e_EnterDate == Now && Excu.e_Text == Excuse && Excu.e_User == ByUserId));
                    if (SelectedExcuse.Count() != 1)
                        return 0;
                    var Absence = Data.isch_Absences.Where(abs => abs.a_id == AbsenceId);
                    if (Absence.Count() != 1)
                        return 0;
                    Absence.First().a_Excuse = SelectedExcuse.First().e_id;
                    Data.SaveChanges();
                    return 1;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }

        public int PutNotification(int SenderId, string Title, string NotificationBody)
        {
            throw new NotImplementedException();
        }

        public int PutSchedualForStudent(int StudentId, int Sub1, int Sub2, int Sub3, int Sub4, int Sub5, int Sub6, int Sub7, int Sub8)
        {
            throw new NotImplementedException();
        }

        public int PutStudent(string StudentAcc, string Name, string Specialization, string Nationality, string NationalId, string EnterDate, int AcademicSupervisor)
        {
            throw new NotImplementedException();
        }

        public int PutSubject(int TeacherId, string Type, string Class, string Place)
        {
            throw new NotImplementedException();
        }

        public int PutTeacher(string UserName, string RealyName, string Password, bool IsAdmin = false)
        {
            throw new NotImplementedException();
        }
    }
}
