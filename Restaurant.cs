using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIN_SDAM_ASSIGNMENT
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }  
        public int UserId { get; set; }        
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
    }
}
