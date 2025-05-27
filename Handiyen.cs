namespace LOGIN_SDAM_ASSIGNMENT
{
    public partial class Handiyen : Form
    {
        public Handiyen()
        {
            InitializeComponent();
        }

        private void Sign_up_btn_Click(object sender, EventArgs e)
        {
            Signupselector signupSelector = new Signupselector();
            signupSelector.Show();
            this.Hide();
        }

        private void Log_in_btn_Click(object sender, EventArgs e)
        {
            Loginform loginForm = new Loginform();
            loginForm.Show();
            this.Hide();
        }
    }
}
