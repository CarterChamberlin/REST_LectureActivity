using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTLectureActivity
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string password(string firstName, string lastName, int age)
        {
            //password = first 2 letters of LASTname + last 2 letters of FIRSTname + age%5
            string password = String.Empty;
            password = lastName[lastName.Length - 2].ToString() + lastName[lastName.Length - 1].ToString() + firstName[0].ToString() + firstName[1].ToString() + (age % 5).ToString();
            return password;
        }


        public int loginID(int age)
        {
            Random rnd = new Random();
            return (age * rnd.Next(100, 200));
        }
    }
}
