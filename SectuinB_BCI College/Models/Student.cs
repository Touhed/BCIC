using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupB01_BCIC.Models
{
    public class Student
    {
        [Key]
        public Int64 StudentId { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Version { get; set; }
        public string Department { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }
        public string Scholarship { get; set; }
        public string Session { get; set; }
        public string Nationality { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public Int64 Contact { get; set; }
        public string Email { get; set; }
    }
}
