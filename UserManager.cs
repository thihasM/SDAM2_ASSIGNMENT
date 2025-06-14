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
        private static Customer? _currentCustomer;
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
        public static void SetCurrentCustomer(Customer customer)
        {
            _currentCustomer = customer ?? throw new ArgumentNullException(nameof(customer));
        }


        public static int GetCurrentRestaurantId()
        {
            return _currentRestaurantId;
        }
        public static int GetCurrentCustomerId()
        {
            return _currentCustomer?.CustomerId ?? 0;
        }

        public static void ClearCurrentUser()
        {
            //currentUser = null;
            _currentRestaurantId = 0;
            _currentCustomer = null;
        }

        public static bool IsLoggedIn()
        {
            return _currentUser != null;
        }

        public static bool IsRestaurantOwner()
        {
            return _currentUser?.AccountType == "Restaurant";
        }
        public static bool IsCustomer()
        {
            return _currentUser?.AccountType == "Customer";
        }
    }
}
