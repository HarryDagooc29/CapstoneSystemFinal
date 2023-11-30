using System;
using System.Collections.Generic;

namespace HarryMidterm.Entities
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public string SubTotal { get; set; }
        public string DiscountPercent { get; set; }
        public string Deduction { get; set; }
        public string TotalAmount { get; set; }
        public string PaidAmount { get; set; }
        public string Sukli { get; set; }
        public string Datepurchased { get; set; }
    }
}
