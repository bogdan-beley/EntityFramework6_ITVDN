using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_FluentAPIAndDataAnnotations_HW1.Configuration
{
    class BlogConfig : EntityTypeConfiguration<Blog>
    {
        public BlogConfig()
        {
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired().HasMaxLength(50);
        }
    }
}
