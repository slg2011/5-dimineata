using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer
{
    public class Data
    {
        

        public static List<LogInn> GetUsers()
        {
            List<LogInn>user= null;
            using(ProiectBazeContext ctx = new ProiectBazeContext())
            {
                user = (from x in ctx.LogInns
                        select x).ToList();
            }
            return user;
        }



    };

     

    
}
