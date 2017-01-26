using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ISchool.Server.Configuration
{
    // NOTE: Use This For Import School Data :)
    //Eltayeb Kamal
    [ServiceContract]
    public interface IConfigData
    {
        [OperationContract]
        bool AddStudent(string Acc, string Name,string Specialize,string BirthDate,string Registry,string StateType, string Nationality, string IdType, string IdNumber, string AcadmyMan, string School);
    }
}
