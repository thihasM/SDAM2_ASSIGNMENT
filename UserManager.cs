using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIN_SDAM_ASSIGNMENT
{
    public static class UserManager
    {
        private static User _currentUser;

        public static void SetCurrentUser(User user)
        {
            _currentUser = user;
        }
        public static User GetCurrentUser()
        {
            return _currentUser;
        }
        public static void ClearCurrentUser()
        {
            _currentUser = null;
        }
    }
}
