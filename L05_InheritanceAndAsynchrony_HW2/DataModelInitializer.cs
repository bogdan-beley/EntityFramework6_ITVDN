using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_InheritanceAndAsynchrony_HW2
{
    class DataModelInitializer : DropCreateDatabaseAlways<DataModel>
    {
        protected override void Seed(DataModel db)
        {
            var phonebook1 = new Phonebook { Name = "MyPhones" };

            db.Phonebooks.Add(phonebook1);
            db.SaveChanges();

            var contacts = new List<Contact>()
            {
                new Contact
                {
                    FName = "David", LName = "Oliver", Email = "davidoliver@mail.com",
                    PhoneNumber = "+380971111111", Phonebook = phonebook1
                },
                new Contact
                {
                    FName = "Diana", LName = "Ronald", Email = "dianaronald@mail.com",
                    PhoneNumber = "+380972222222", Phonebook = phonebook1
                }
            };

            db.Contacts.AddRange(contacts);
            db.SaveChanges();
        }
    }
}
