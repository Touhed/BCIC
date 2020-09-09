using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupB01_BCIC.Models
{
    public class InstituteCost
    {
        [Key]
        public Int64 Id { get; set; }
        public Int64 StaffSalary { get; set; }
        public Int64 StaffBonus { get; set; }
        public Int64 Stationary { get; set; }
        public Int64 Entertainment { get; set; }
        public Int64 Convened { get; set; }
        public Int64 HouseRent { get; set; }
        public Int64 TelephoneBill { get; set; }
        public Int64 GasBill { get; set; }
        public Int64 ElectricityBill { get; set; }
        public Int64 WaterBill { get; set; }
        public Int64 InternetBill { get; set; }
        public Int64 GiveDonation { get; set; }
        public Int64 FuelCharge { get; set; }
        public Int64 CarRent { get; set; }
        public Int64 DirectorOwneram { get; set; }
        public Int64 TotalCost { get; set; }
    }
}
