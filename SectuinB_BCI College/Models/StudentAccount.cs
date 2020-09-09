using GroupB01_BCIC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupB01_BCIC.Models
{
    public class StudentAccount
    {
        [Key]
        public Int64 StudentId { get; set; }
        public string StudentName { get; set; }
        public Int64 PaymentStatus { get; set; }
    }    
}

