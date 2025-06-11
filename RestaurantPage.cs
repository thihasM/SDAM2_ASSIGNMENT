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
    public partial class RestaurantPage : Form
    {
        private Restaurant _restaurant;
        public RestaurantPage(Restaurant restaurant)
        {
            InitializeComponent();
            _restaurant = restaurant;
        }

        private void RestaurantPage_Load(object sender, EventArgs e)
        {
            lblName.Text = _restaurant.Name;
            lblAddress.Text = _restaurant.Address;
        }
    }
}
