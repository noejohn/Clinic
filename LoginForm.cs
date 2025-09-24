using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clinic
{
    public partial class LoginForm : Form
    {
        private List<User> users;

        public LoginForm()
        {
            InitializeComponent();
            users = new List<User>
            {
                new User { Username = "admin", Password = "admin123", Role = UserRole.Admin },
                new User { Username = "doctor", Password = "doc123", Role = UserRole.Doctor },
                new User { Username = "staff", Password = "staff123", Role = UserRole.Staff }
            };
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            var user = users.Find(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                Hide();
                switch (user.Role)
                {
                    case UserRole.Admin:
                        new AdminDashboard().ShowDialog();
                        break;
                    case UserRole.Doctor:
                        new DoctorDashboard().ShowDialog();
                        break;
                    case UserRole.Staff:
                        new StaffDashboard().ShowDialog();
                        break;
                }
                Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials.");
            }
        }
    }
}
