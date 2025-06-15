using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIN_SDAM_ASSIGNMENT
{
    public class DeliveryDriver
    {
        public int DriverId { get; set; }
        public string Name { get; set; }

        public DeliveryDriver(int id, string name)
        {
            DriverId = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
