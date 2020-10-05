using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_FluentAPIAndDataAnnotations_HW1.Configuration
{
    class ArticleConfig : EntityTypeConfiguration<Article>
    {
        public ArticleConfig()
        {
            HasKey(p => p.Id);
            Property(p => p.Title).IsRequired().HasMaxLength(100);
            Property(p => p.Text).IsOptional();
        }
    }
}
