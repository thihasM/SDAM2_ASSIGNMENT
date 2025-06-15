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
                            //Application.DoEvents();
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

        }

        private void Restaurantinterface_Load(object sender, EventArgs e)
        {

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
