using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN_SDAM_ASSIGNMENT
{
    public partial class DispatchForm : Form
    {
        private Order _order;
        private List<Driver> drivers = new List<Driver>();

        public DispatchForm(Order order)
        {
            InitializeComponent();
            _order = order;
            LoadDrivers();
            LoadOrderDetails();
        }
        private void LoadDrivers()
        {
            drivers = new List<Driver>
        {
            new Driver { DriverId = 1, Name = "Kevin" },
            new Driver { DriverId = 2, Name = "Ryan" },
            new Driver { DriverId = 3, Name = "Ganidu" },
            new Driver { DriverId = 4, Name = "Suchiru" },
            new Driver { DriverId = 5, Name = "Thihas" }
        };

            driverslb.DataSource = drivers;
            driverslb.DisplayMember = "Name";
        }
        
        private void LoadOrderDetails()
        {
            if (_order != null)
            {
                txtOrderId.Text = _order.OrderId.ToString();
                txtLocation.Text = _order.DeliveryLocation;
                txtPayment.Text = _order.PaymentMethod;
                txtOrderTime.Text = _order.OrderTime.ToString("g"); // e.g. 6/15/2025 2:30 PM
            }
        }

        private void DispatchForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDispatchOrder_Click(object sender, EventArgs e)
        {
            if (driverslb.SelectedItem is Driver selectedDriver)
            {
                using (var db = new DatabaseHelper())
                {
                    db.UpdateOrderStatus(_order.OrderId, "Dispatched");
                }

                MessageBox.Show($"Driver {selectedDriver.Name} assigned to Order #{_order.OrderId}.");
                TrackOrderAsync();
            }
        }
        private async Task TrackOrderAsync()
        {
            int estimateMinutes = new Random().Next(5, 30);
            DateTime estimateTime = _order.OrderTime.AddMinutes(estimateMinutes);

            for (int i = 0; i <= 100; i += 10)
            {

                await Task.Delay(300); // Sim
            }

            MessageBox.Show($"Order #{_order.OrderId} delivered!\nEstimated Time: {estimateTime:HH:mm}");

            this.Close();
        }

        private void txtOrderDetails_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
