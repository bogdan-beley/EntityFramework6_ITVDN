using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_LINQFeatures_HW
{
    public class Author
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
