using System;
using System.Linq;
using System.Windows.Forms;
using MunicipalServicesApp.Models;

namespace MunicipalServicesApp.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ApplyDesign();
        }

        private void ApplyDesign()
        {
            this.BackgroundImage = Properties.Resources.gov;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Text = "Bayview Municipality Login";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            var user = UserStore.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user == null)
            {
                MessageBox.Show("Invalid username or password!", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserStore.CurrentUser = user; 

            if (user.Role == "Resident")
            {
                var mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else if (user.Role == "Employee")
            {
                var dashboard = new DashboardForm();
                dashboard.Show();
                this.Hide();
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            var signupForm = new SignupForm();
            signupForm.Show();
            this.Hide();
        }
    }
}
