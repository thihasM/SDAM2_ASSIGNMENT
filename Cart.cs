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
        public string FoodName { get; set; } = "";
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int RestaurantId { get; set; }

        public override string ToString()
        {
            return $"{FoodName} - {Quantity} x {Price:C}";
        }
    }

    public static class Cart
    {
        public static List<CartItem> Items { get; } = new List<CartItem>();
        public static int CurrentRestaurantId { get; set; } = -1;

        public static void AddItem(string itemName, decimal price, int restaurantId, int quantity)
        {
            if (CurrentRestaurantId != restaurantId)
            {
                Items.Clear();
                CurrentRestaurantId = restaurantId;
            }

            var existingItem = Items.Find(item => item.FoodName == itemName);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                Items.Add(new CartItem
                {
                    FoodName = itemName,
                    Price = price,
                    Quantity = quantity,
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
