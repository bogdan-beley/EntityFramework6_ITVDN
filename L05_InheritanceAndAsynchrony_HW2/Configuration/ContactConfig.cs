using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_InheritanceAndAsynchrony_HW2.Configuration
{
    class ContactConfig : EntityTypeConfiguration<Contact>
    {
        public ContactConfig()
        {
            HasKey(p => p.Id);
            Property(p => p.FName).IsOptional().HasMaxLength(50);
            Property(p => p.LName).IsOptional().HasMaxLength(50);
            Property(p => p.PhoneNumber).IsOptional().HasMaxLength(13);
            Property(p => p.Email).IsOptional().HasMaxLength(50);
        }
    }
}
