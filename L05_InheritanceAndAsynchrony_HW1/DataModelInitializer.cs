using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_InheritanceAndAsynchrony_HW1
{
    class DataModelInitializer : DropCreateDatabaseIfModelChanges<DataModel>
    {
        protected override void Seed(DataModel db)
        {
            var phones = new List<Phone>()
            {
                new Phone { Brand = "Nokia", Model = "3100"},
                new Phone {Brand = "Sony Ericsson", Model = "K800i"}
            };

            db.Phones.AddRange(phones);
            db.SaveChanges();

            var s1 = new Smartphone { Brand = "Xiaomi", Model = "T9Pro", OS = "Android" };

            db.Smartphones.Add(s1);
            db.SaveChanges();
        }
    }
}
