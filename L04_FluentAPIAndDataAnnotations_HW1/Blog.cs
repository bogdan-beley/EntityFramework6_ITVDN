using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_FluentAPIAndDataAnnotations_HW1
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
