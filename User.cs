using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIN_SDAM_ASSIGNMENT
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string AccountType { get; set; }

        public User(int userId, string username, string accountType)
        {
            UserId = userId;
            Username = username;
            AccountType = accountType;
        }
    }
}
