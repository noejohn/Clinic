using System.Windows.Forms;
using System;

namespace Clinic
{
    public partial class StaffDashboard : Form
    {
        public StaffDashboard()
        {
            InitializeComponent();
            btnRegisterPatient.Click += BtnRegisterPatient_Click;
            btnScheduleAppointment.Click += BtnScheduleAppointment_Click;
        }

        private void BtnRegisterPatient_Click(object sender, EventArgs e)
        {
            new PatientManagementForm().ShowDialog();
        }

        private void BtnScheduleAppointment_Click(object sender, EventArgs e)
        {
            // Open Appointment Management Form
            // new AppointmentManagementForm().ShowDialog();
            MessageBox.Show("Appointment Management Form not implemented.");
        }
    }
}
