using System;
using System.Collections.Generic;

namespace HarryMidterm.Entities
{
    public partial class Newborrower
    {
        public int NewBorrowerId { get; set; }
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
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
