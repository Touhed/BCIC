using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupB01_BCIC.Models
{
    public class Register
    {
        [Key]
        public Int64 RegisterId { get; set; }
        public string RegisterName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
    }
}
