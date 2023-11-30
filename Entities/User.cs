using System;
using System.Collections.Generic;

namespace HarryMidterm.Entities
{
    public partial class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public bool LastName { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool DeleteStatus { get; set; }
    }
}
