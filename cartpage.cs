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
    
    public partial class cartpage : Form
    {
        private int _userId;
        public cartpage(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void cartpage_Load(object sender, EventArgs e)
        {
            RefreshCartDisplay();
            var currentUser = UserManager.GetCurrentUser();
            if (currentUser != null)
            {
                lblWelcome.Text = $"{currentUser.Username}!";
            }
            else
            {
                lblWelcome.Text = "Welcome!";
            }
        }
        private void RefreshCartDisplay()
        {
            cart_lb.DataSource = null;
            cart_lb.DataSource = Cart.Items;
            cart_lb.DisplayMember = "ToString"; 

            lblTotal.Text = $"Total: Rs. {Cart.GetTotal():0.00}";
        }

        private void payment_btn_Click(object sender, EventArgs e)
        {

            string location = del_loc_tb.Text.Trim();
            if (string.IsNullOrWhiteSpace(location))
            {
                MessageBox.Show("Please enter delivery location.");
                return;
            }

            int customerId = UserManager.GetCurrentCustomerId();
            if (Cart.Items.Count == 0)
            {
                MessageBox.Show("Your cart is empty. Add items before placing an order.");
                return;
            }

            if (customerId <= 0)
            {
                MessageBox.Show("Invalid customer. Please log in again.");
                return;
            }
            try
            {
                int orderId = CartServices.PlaceOrder(customerId, location);
                MessageBox.Show("Order placed successfully!");

                Payment paymentForm = new Payment(orderId);
                paymentForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to place order: " + ex.Message);
            }

        }

        private void user_back_btn_Click(object sender, EventArgs e)
        {
            new Customerinterface().Show();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cart_lb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
