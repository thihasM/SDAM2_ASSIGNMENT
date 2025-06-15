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
    public partial class Restaurantinterface : Form
    {
        private bool _isLoadingOrders = false;
        private List<Order> pendingOrders;
        private int _userId;
        public Restaurantinterface()
        {
            InitializeComponent();
            var currentUser = UserManager.GetCurrentUser();
            if (currentUser != null)
            {
                _userId = currentUser.UserId;
                LoadRestaurantData();
            }
            else
            {
                MessageBox.Show("No user is logged in.");
                this.Close();
            }
        }
        private void LoadRestaurantData()
        {
            try
            {
                using (var db = new DatabaseHelper())
                {

                    var restaurant = db.GetRestaurantByUserId(_userId);

                        if (restaurant != null)
                        {;

                            lblRestaurantName.Text = restaurant.Name;

                            lblRestaurantName.Refresh();
                        }
                        else
                        {
                            Console.WriteLine("No restaurant found for this user");
                            lblRestaurantName.Text = "Restaurant not found";
                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading data: {ex.Message}");
                lblRestaurantName.Text = "Error loading data";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResturantProfile profile = new ResturantProfile(_userId);
            profile.Show();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoadingOrders) return;

            if (listBoxPendingOrders.SelectedItem != null)
            {
                Order selectedOrder = (Order)listBoxPendingOrders.SelectedItem;
                new DispatchForm(selectedOrder).ShowDialog();
                LoadPendingOrders();
            }
        }

        private void Restaurantinterface_Load(object sender, EventArgs e)
        {
            LoadPendingOrders();
        }
        private void LoadPendingOrders()
        {
            using (var db = new DatabaseHelper())
            {
                try
                {
                    _isLoadingOrders = true;

                    pendingOrders = db.GetPendingOrders();

                    if (pendingOrders != null)
                    {
                        listBoxPendingOrders.DataSource = null;
                        listBoxPendingOrders.DataSource = pendingOrders;
                        listBoxPendingOrders.DisplayMember = "Details";
                        listBoxPendingOrders.ValueMember = "OrderId";
                    }
                    else
                    {
                        listBoxPendingOrders.DataSource = null;
                        MessageBox.Show("No pending orders found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load orders: " + ex.Message);
                }
                finally
                {
                    _isLoadingOrders = false;
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void edit_menu_btn_Click(object sender, EventArgs e)
        {
            Handiyen handiyen = new Handiyen();
            handiyen.Show();
            this.Close();
        }
    }
}
