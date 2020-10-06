using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_InheritanceAndAsynchrony_HW1
{
    public class Phone
    {
        public int Id { get; set; }

        [Required, MinLength(2), MaxLength(20)]
        public string Brand { get; set; }

        [Required, MinLength(2), MaxLength(20)]
        public string Model { get; set; }
    }
}
