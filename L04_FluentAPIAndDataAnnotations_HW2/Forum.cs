using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace L04_FluentAPIAndDataAnnotations_HW2
{
    public class Forum
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(3), MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Message> Messages { get; set; }
    }
}
