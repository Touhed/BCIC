using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupB01_BCIC.Models
{
    public class EngSciStudent
    {
        [Key]
        public Int64 StudentId { get; set; }
        public string StudentName { get; set; }
        public string Department { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
    }
}
