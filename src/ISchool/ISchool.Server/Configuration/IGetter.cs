﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ISchool.Server.Configuration
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGetter" in both code and config file together.
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
    }
}
