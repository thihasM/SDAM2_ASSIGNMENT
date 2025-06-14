using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIN_SDAM_ASSIGNMENT
{
    public static class UserManager
    {
        private static User? _currentUser;
        private static int _currentRestaurantId = 0;

        public static void SetCurrentUser(User user)
        {
            _currentUser = user ?? throw new ArgumentNullException(nameof(user));
            if (user.AccountType == "Restaurant" && user.RestaurantId.HasValue)
            {
                _currentRestaurantId = user.RestaurantId.Value;
            }
        }

        public static User? GetCurrentUser()
        {
            return _currentUser;
        }

        public static int GetCurrentRestaurantId()
        {
            return _currentRestaurantId;
        }

        public static void ClearCurrentUser()
        {
            _currentUser = null;
            _currentRestaurantId = 0;
        }

        public static bool IsLoggedIn()
        {
            return _currentUser != null;
        }

        public static bool IsRestaurantOwner()
        {
            return _currentUser?.AccountType == "Restaurant";
        }
    }
}
