using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pro_ATM.Models;

namespace Pro_ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("salut");
            using( var ctx = new ProiectBazeContext() )
            {
                var first = from x in ctx.LogInns
                            select x;
                foreach (var f in first)
                    Console.WriteLine(f.id + "\t" + f.username);


            }
        }
    }
}
