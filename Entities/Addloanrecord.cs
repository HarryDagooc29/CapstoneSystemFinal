using System;
using System.Collections.Generic;

namespace HarryMidterm.Entities
{
    public partial class Addloanrecord
    {
        public int AddloanrecordId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string DateAllocated { get; set; }
        public string? PaymentStartDate { get; set; }
        public int PrincipalAmount { get; set; }
        public double AnnualInterestRate { get; set; }
        public string? LoanTermMonths { get; set; }
        public string? LoanTermDays { get; set; }
        public double? PaymentMonthsDays { get; set; }
        public double? TotalInterest { get; set; }
        public double? TotalAmount { get; set; }
    }
}
