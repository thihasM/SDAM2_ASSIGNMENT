using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIN_SDAM_ASSIGNMENT
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderTime { get; set; }
        public string DeliveryLocation { get; set; }
        public string PaymentMethod { get; set; }
        public int CartId { get; set; }

        public string Details
        {
            get
            {
                return $"Order #{OrderId} to {DeliveryLocation} | {PaymentMethod} | {OrderTime:hh:mm tt}";
            }
        }
    }
}
