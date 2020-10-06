 using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace L05_InheritanceAndAsynchrony_HW2
{
    public class Phonebook
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Contact> Contacts { get; set; }
    }
}
