using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIN_SDAM_ASSIGNMENT
{
    public class Customer
    {
        public int CustomerId { get; set; }     // Maps to cus_id (Primary Key)
        public int UserId { get; set; }         // Maps to user_id (Foreign Key)
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }

        public Customer() { }

        public Customer(int customerId, int userId, string name, string email, string phoneNumber)
        {
            CustomerId = customerId;
            UserId = userId;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"{Name} - {Email}";
        }
    }
}
