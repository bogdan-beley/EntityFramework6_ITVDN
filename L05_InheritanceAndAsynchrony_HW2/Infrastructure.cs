using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_InheritanceAndAsynchrony_HW2
{
    public static class Infrastructure
    {
        public static async Task GetObjectAsync()
        {
           using (DataModel db = new DataModel())
            {
                await db.Contacts.ForEachAsync(c =>
                    Console.WriteLine("{0}. {1} {2} {3} {4}", c.Id, c.FName, c.LName, c.PhoneNumber, c.Email)
                );
            }
        }

        public static async Task SaveObjectAsync(Contact c)
        {
            using (DataModel db = new DataModel())
            {
                db.Contacts.Add(c);
                await db.SaveChangesAsync();
            }
        }
    }
}
