using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupB01_BCIC.Models
{
    public class TeacherAccount
    {
        [Key]
        public Int64 AccNo { get; set; }
        public Int64 TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherType { get; set; }
        public string TeacherGread { get; set; }
        public string BasicSalary { get; set; }
        public string Month { get; set; }
        public Int64 Year { get; set; }
    }
}
