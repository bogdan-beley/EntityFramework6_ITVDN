using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_InheritanceAndAsynchrony_HW2
{
    public class Contact
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Phonebook Phonebook { get; set; }
        public int PhonebookId { get; set; }
    }
}
