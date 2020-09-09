using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupB01_BCIC.Models
{
    public class IncomeSource
    {
        [Key]
        public Int64 IncomeId { get; set; }
        public Int64 StudentAdmissionFee { get; set; }
        public Int64 StudentSessionFee { get; set; }
        public Int64 StudentTuitionFee { get; set; }
        public Int64 ExaminationFee { get; set; }
        public Int64 FormFillUp { get; set; }
        public Int64 StationarySell { get; set; }
        public Int64 Donation { get; set; }
        public Int64 TotalIncome { get; set; }
    }
}
