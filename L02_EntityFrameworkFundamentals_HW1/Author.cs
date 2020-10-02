using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_EntityFrameworkFundamentals_HW1
{
    public class Author
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<Article> Articles { get; set; }
        public Author()
        {
            Articles = new List<Article>();
        }
    }
}
