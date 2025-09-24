using System.Windows.Forms;
using System;

namespace Clinic
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            btnManageUsers.Click += BtnManageUsers_Click;
            btnManageDoctors.Click += BtnManageDoctors_Click;
            btnManagePatients.Click += BtnManagePatients_Click;
            btnManageAppointments.Click += BtnManageAppointments_Click;
        }

        private void BtnManageUsers_Click(object sender, EventArgs e)
        {
            // Open User Management Form
            // new UserManagementForm().ShowDialog();
            MessageBox.Show("User Management Form not implemented.");
        }

        private void BtnManageDoctors_Click(object sender, EventArgs e)
        {
            // Open Doctor Management Form
            // new DoctorManagementForm().ShowDialog();
            MessageBox.Show("Doctor Management Form not implemented.");
        }

        private void BtnManagePatients_Click(object sender, EventArgs e)
        {
            new PatientManagementForm().ShowDialog();
        }

        private void BtnManageAppointments_Click(object sender, EventArgs e)
        {
            // Open Appointment Management Form
            // new AppointmentManagementForm().ShowDialog();
            MessageBox.Show("Appointment Management Form not implemented.");
        }
    }
}
