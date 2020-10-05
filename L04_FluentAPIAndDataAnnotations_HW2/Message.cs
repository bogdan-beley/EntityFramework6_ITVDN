using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_FluentAPIAndDataAnnotations_HW2
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(1)]
        public string Text { get; set; }

        [Required]
        public bool Status { get; set; }

        [Required]
        public int ForumId { get; set; }

        [Required]
        public Forum Forum { get; set; }
    }
}
