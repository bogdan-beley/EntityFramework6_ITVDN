using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_InheritanceAndAsynchrony_HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact()
            {
                FName = "John",
                LName = "Smith",
                PhoneNumber = "+380671231212",
                Email = "johnsmith@mail.com",
                PhonebookId = 1
            };
            
            Task task = Infrastructure.SaveObjectAsync(contact);
            task.Wait();

            task = Infrastructure.GetObjectAsync();
            task.Wait();
        }
    }
}
