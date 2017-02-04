using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ISchool.Server.Configuration
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Setter" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Setter.svc or Setter.svc.cs at the Solution Explorer and start debugging.
    public class Setter : ISetter
    {
        public int ChangeStudentPhoneNumber(int StudentId, string PhoneNumber)
        {
            throw new NotImplementedException();
        }

        public int PutAbsence(int StudentId, int AbsenceType, DateTime Date, int Subject)
        {
            throw new NotImplementedException();
        }

        public int PutExcuse(int AbsenceId, int ByUserId, string Excuse, DateTime EnterDate)
        {
            throw new NotImplementedException();
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
