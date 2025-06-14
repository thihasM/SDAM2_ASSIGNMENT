using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LOGIN_SDAM_ASSIGNMENT.Cart;

namespace LOGIN_SDAM_ASSIGNMENT
{
    public class CartItem
    {
        public int RestaurantId { get; set; }
        public string FoodName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"{FoodName} - {Quantity} x {Price:C}";
        }
    }

    public static class Cart
    {
        public static List<CartItem> Items { get; } = new List<CartItem>();
        public static int CurrentRestaurantId { get; set; } = -1;

        public static void AddItem(string foodName, decimal price, int restaurantId)
        {
            // Reset cart if switching restaurants
            if (CurrentRestaurantId != restaurantId)
            {
                Items.Clear();
                CurrentRestaurantId = restaurantId;
            }

            var existingItem = Items.Find(item => item.FoodName == foodName);
            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                Items.Add(new CartItem
                {
                    FoodName = foodName,
                    Price = price,
                    Quantity = 1,
                    RestaurantId = restaurantId
                });
            }
        }

        public static void ClearCart()
        {
            Items.Clear();
            CurrentRestaurantId = -1;
        }

        public static decimal GetTotal()
        {
            decimal total = 0;
            foreach (var item in Items)
            {
                total += item.Price * item.Quantity;
            }
            return total;
        }
    }
}
