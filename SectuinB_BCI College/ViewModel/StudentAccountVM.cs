using GroupB01_BCIC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupB01_BCIC.ViewModel
{
    public class StudentAccountVM
    {
        [Key]
        public Int64 StudentId { get; set; }
        public string StudentName { get; set; }
        public Int64 FixedAmount { get; set; }
        public Int64 PayAmount { get; set; }
        public Int64 TotalAmount { get; set; }
        public Int64 SPayAmount { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime PaymentDate { get; set; }
        public Int64 PaymentStatus { get; set; }
    }    
}

