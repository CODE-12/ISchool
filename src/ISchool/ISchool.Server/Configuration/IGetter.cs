using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ISchool.Server.Configuration
{
    [ServiceContract]
    public interface IGetter
    {
        [OperationContract]
        string GetStudentPhoneNumber(int StudentId);
        [OperationContract]
        string GetStudentName(int StudentId);
        [OperationContract]
        int GetStudentAcademicSupervisor(int StudentId);
        [OperationContract]
        List<string> GetStudentSchudle(int StudnetId);
        [OperationContract]
        int GetStudentIdByName(string Name);
        [OperationContract]
        string GetStudentNameById(int StudnetId);
        [OperationContract]
        string GetStudentSpecialization(int StudentId);
        [OperationContract]
        string GetStudentNationality(int StudnetId);
        [OperationContract]
        string GetStudentNationalId(int studntId);
        [OperationContract]
        string GetStudentEnterTime(int studntId);
    }
}
