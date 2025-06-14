using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
    public partial class Payment : Form
    {
        private int _orderId;
        public Payment(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void back_home_btn_Click(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void placeorder_btn_Click(object sender, EventArgs e)
        {
            string paymentMethod = radioCash.Checked ? "Cash" : "Card";

            if (paymentMethod == "Card")
            {
                if (string.IsNullOrWhiteSpace(cardnum_tb.Text) || string.IsNullOrWhiteSpace(cvc_tb.Text))
                {
                    MessageBox.Show("Please fill in card details.");
                    return;
                }

            }

            SavePaymentMethod(_orderId, paymentMethod);
            MessageBox.Show("Order placed successfully!");
            this.Close();
            trackoder trackOrder = new trackoder(_orderId);
            trackOrder.Show();
            this.Close();
        }
        private void SavePaymentMethod(int orderId, string method)
        {
            using (var db = new DatabaseHelper())
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "UPDATE orders SET payment_method = @method WHERE order_id = @id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@method", method);
                    cmd.Parameters.AddWithValue("@id", orderId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void cash_radio_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCash.Checked)
            {
                cardname_tb.Enabled = false;
                cardnum_tb.Enabled = false;
                expdate_tb.Enabled = false;
                cvc_tb.Enabled = false;
            }
        }

        private void rdoCard_CheckedChanged(object sender, EventArgs e)
        {
            if (card_radio_btn.Checked)
            {
                cardname_tb.Enabled = true;
                cardnum_tb.Enabled = true;
                expdate_tb.Enabled = true;
                cvc_tb.Enabled = true;
            }
        }
    }
}
