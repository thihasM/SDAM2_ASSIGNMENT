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
            int orderId = CartServices.SaveCartToDatabase(customerId, location);

            // Pass orderId to payment form
            Payment paymentForm = new Payment(orderId);
            paymentForm.Show();
            this.Close();
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
