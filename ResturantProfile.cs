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
    public partial class ResturantProfile : Form
    {
        public ResturantProfile()
        {
            InitializeComponent();
        }

        private void ResturantProfile_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void res_edit_food_menu_btn_Click(object sender, EventArgs e)
        {
            menueditpage menuEditPage = new menueditpage();
            menuEditPage.Show();
            this.Close();
        }
    }
}
