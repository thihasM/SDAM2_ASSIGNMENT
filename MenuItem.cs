using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIN_SDAM_ASSIGNMENT
{
    public class MenuItem
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public string ItemName { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{ItemName} - Rs. {Price}";
        }
        public string DisplayText => $"{ItemName} - Rs. {Price}";
    }
}
