using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarryMidterm.ViewModel
{
    public class ViewBalance
    {
 

      
        public int NewBorrowerId { get; set; }
        public int AddloanrecordId { get; set; }





        // new borrower

      
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string Sex { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public int ZipCode { get; set; }
        public string Nationality { get; set; }
        public string MaritalStatus { get; set; }
        public string Occupation { get; set; }
        public int Salary { get; set; }
        public double Capital { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }



       // schedule
        public int ScheduleId { get; set; }
        public string Date { get; set; }
        public double? Payment { get; set; }
        public double TotalAmount { get; set; }
        public double Balance { get; set; }
        public string Type { get; set; }



         
     
    }
}