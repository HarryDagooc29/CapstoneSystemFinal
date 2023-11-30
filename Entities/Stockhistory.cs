using System;
using System.Collections.Generic;

namespace HarryMidterm.Entities
{
    public partial class Stockhistory
    {
        public int AStockId { get; set; }
        public int ProdId { get; set; }
        public int AddedStock { get; set; }
        public string Date { get; set; }
    }
}
