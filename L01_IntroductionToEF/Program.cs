using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01_IntroductionToEF
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDatabaseEntities context = new MyDatabaseEntities();

            var myTables = context.MyTables.ToList();

            foreach (var item in myTables)
            {
                Console.WriteLine(item);
            }
        }
    }
}
