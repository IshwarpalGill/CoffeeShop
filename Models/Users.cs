using System;
using System.Collections.Generic;

namespace CoffeeShop.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? Birthday { get; set; }
        public string Gender { get; set; }
        public bool? RecieveEmails { get; set; }
    }
}
