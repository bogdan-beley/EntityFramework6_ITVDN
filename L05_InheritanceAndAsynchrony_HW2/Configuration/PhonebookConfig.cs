using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_InheritanceAndAsynchrony_HW2.Configuration
{
    class PhonebookConfig : EntityTypeConfiguration<Phonebook>
    {
        public PhonebookConfig()
        {
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired().HasMaxLength(20);
        }
    }
}
