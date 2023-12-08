using System;
using System.Collections.Generic;

namespace HarryMidterm.Entities
{
    public partial class Schedule
    {
        public int ScheduleId { get; set; }
        public string Date { get; set; }
        public int AddloanrecordId { get; set; }
        public double? Payment { get; set; }
        public double? Balance { get; set; }
        public string Type { get; set; }
    }
}
