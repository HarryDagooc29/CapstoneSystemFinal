using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarryMidterm.ViewModel
{
    public class orderInfo
    {
        public string productName { get; set; }
        public int OrderDetailsId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public float ProductTotal { get; set; }
    }
}