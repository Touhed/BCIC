using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupB01_BCIC.Models
{
    public class PartTimeTeacher
    {
        [Key]
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Designation { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
