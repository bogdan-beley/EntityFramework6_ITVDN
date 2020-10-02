using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_EntityFrameworkFundamentals_HW1
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatingDate { get; set; }
        public int? AuthorId { get; set; }
        public Author Author  { get; set; }
    }
}
