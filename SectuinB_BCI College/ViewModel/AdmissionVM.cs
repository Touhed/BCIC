using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupB01_BCIC.ViewModel
{
    public class AdmissionVM
    {
        [Key]
        public Int64 AdmissionId { get; set; }
        public Int64 AdmissionFees { get; set; }
        public Int64 LibraryFee { get; set; }
        public Int64 LaboratoryFee { get; set; }
        public Int64 FixedAmount { get; set; }
        public Int64 PayAmount { get; set; }
        public Int64 PaymentStatus { get; set; }
        public Int64 StudentId { get; set; }
    }
}
