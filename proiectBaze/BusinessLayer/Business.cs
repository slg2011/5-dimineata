using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Models;
namespace BusinessLayer
{
    public class Business
    {
        public static List<LogInn> GetUsers()
        {
            return Data.GetUsers();
        }
        public static List<Student> GetStudent()
        {
            return Data.GetStudent();
        }

        public static List<Grupe> GetGrupe()
        {
            return Data.GetGrupe();
        }

        public static void LogIn()
        {

        }


    }

    
}
