 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace L05_InheritanceAndAsynchrony_HW1
{
    public class Smartphone : Phone
    {
        [MinLength(2), MaxLength(20)]
        public string OS { get; set; }
    }
}
