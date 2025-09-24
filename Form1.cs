using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class Form1 : Form
    {
        private User _currentUser;
        public Form1(User user)
        {
            InitializeComponent();
            _currentUser = user;
            ApplyRolePermissions();
        }

        private void ApplyRolePermissions()
        {
            // Example: Only Admin can enable delete button (if exists)
            // Only Staff can register patients and schedule appointments
            // You can add more controls and logic as needed
            if (_currentUser.Role == UserRole.Staff)
            {
                // Disable delete features, enable registration/scheduling
                // Example: buttonDelete.Enabled = false;
            }
            else if (_currentUser.Role == UserRole.Admin)
            {
                // Enable all features
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
