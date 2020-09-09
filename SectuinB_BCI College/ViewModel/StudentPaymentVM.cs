using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupB01_BCIC.ViewModel
{
    public class StudentPaymentVM
    {
        [Key]
        public Int64 PaymentId { get; set; }
        public Int64 StudentId { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public Int64 TuitionFee { get; set; }
        public string ExtraFeeCategory { get; set; }
        public Int64 ExtraFee { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime PaymentDate { get; set; }
        public Int64 TotalAmount { get; set; }
        public Int64 SPayAmount { get; set; }
        public Int64 PaymentStatus { get; set; }
    }
}
