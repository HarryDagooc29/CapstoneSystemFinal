using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarryMidterm.ViewModel
{
    public class PPayment
    {
        public int ScheduleID { get; set; }
        public string Date { get; set; }
        public int addloanrecordID { get; set; }
        public double? Payment { get; set; }
        public double? Balance { get; set; }
        public string Type { get; set; }
        public double PrincipalAmount { get; set; }
        public double AnnualInterestRate { get; set; }
        public string LoanTermDays { get; set; }

        public string LoanTermMonths { get; set; }

    }
}