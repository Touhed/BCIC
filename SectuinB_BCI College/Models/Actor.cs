using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupB01_BCIC.Models
{
    public class Actor
    {
        [Key]
        public long UserId { get; set; }

        [Required(ErrorMessage = "Type is mendatory.")]
        public String UserType { get; set; }
    }
}
