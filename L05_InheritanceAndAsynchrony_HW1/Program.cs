using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_InheritanceAndAsynchrony_HW1
{
    // TPH (Table Per Hierarchy)
    class Program
    {
        static void Main(string[] args)
        {
            using (DataModel db = new DataModel())
            {
                var phones = db.Phones;
                foreach (var phone in phones)
                {
                    Console.WriteLine($"{phone.Id}. {phone.Brand} {phone.Model}");
                }

                var smartphones = db.Smartphones;
                foreach (var smartphone in smartphones)
                {
                    Console.WriteLine($"{smartphone.Id}. {smartphone.Brand} {smartphone.Model} - OS: {smartphone.OS}");
                }
            }
        }
    }
}
