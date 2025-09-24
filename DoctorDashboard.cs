using System.Windows.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Clinic
{
    public partial class DoctorDashboard : Form
    {
        private static string connectionString = @"Server=ADMIN-PC-25\SQLEXPRESS01; Database=ClinicDB; Integrated Security=true;";
        private int doctorId = 1; // Replace with actual logged-in doctor ID

        public DoctorDashboard()
        {
            InitializeComponent();
            btnUpdateDiagnosis.Click += BtnUpdateDiagnosis_Click;
            btnMarkCompleted.Click += BtnMarkCompleted_Click;
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT a.AppointmentId, (p.FirstName + ' ' + p.LastName) AS PatientName, a.Date, a.Status FROM Appointments a INNER JOIN Patients p ON a.PatientId = p.PatientId WHERE a.DoctorId = @DoctorId";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@DoctorId", doctorId);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAppointments.DataSource = dt;
            }
        }

        private void BtnUpdateDiagnosis_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0 || dgvAppointments.SelectedRows[0].Cells["AppointmentId"].Value == null)
            {
                MessageBox.Show("Please select a valid appointment.");
                return;
            }
            int appointmentId = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells["AppointmentId"].Value);
            // Show a dialog to enter diagnosis, then update DB
            MessageBox.Show("Diagnosis update not implemented.");
        }

        private void BtnMarkCompleted_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0 || dgvAppointments.SelectedRows[0].Cells["AppointmentId"].Value == null)
            {
                MessageBox.Show("Please select a valid appointment.");
                return;
            }
            int appointmentId = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells["AppointmentId"].Value);
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Appointments SET Status=@Status WHERE AppointmentId=@AppointmentId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Status", "Completed");
                cmd.Parameters.AddWithValue("@AppointmentId", appointmentId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadAppointments();
        }
    }
}
