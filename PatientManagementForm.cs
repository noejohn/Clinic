using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Clinic
{
    public partial class PatientManagementForm : Form
    {
        private static string connectionString = @"Server=ADMIN-PC-25\SQLEXPRESS01; Database=ClinicDB; Integrated Security=true;";

        public PatientManagementForm()
        {
            InitializeComponent();
            LoadPatients();
        }

        private void LoadPatients(string nameFilter = "", PatientStatus? statusFilter = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Patients WHERE (@FirstName='' OR FirstName LIKE '%' + @FirstName + '%') AND (@Status IS NULL OR Status=@Status)";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@FirstName", nameFilter);
                da.SelectCommand.Parameters.AddWithValue("@Status", statusFilter.HasValue ? (object)statusFilter.Value.ToString() : DBNull.Value);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewPatients.AutoGenerateColumns = true; // Ensure columns are auto-generated
                dataGridViewPatients.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || dtpDOB.Value == null)
            {
                MessageBox.Show("Name and DOB are required.");
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Patients (FirstName, DOB, Status) VALUES (@FirstName, @DOB, @Status)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FirstName", txtName.Text);
                cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value);
                cmd.Parameters.AddWithValue("@Status", PatientStatus.Active.ToString());
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadPatients();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dataGridViewPatients.SelectedRows[0].Cells["PatientId"].Value);
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Patients SET FirstName=@FirstName, DOB=@DOB WHERE PatientId=@PatientId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FirstName", txtName.Text);
                cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value);
                cmd.Parameters.AddWithValue("@PatientId", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadPatients();
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dataGridViewPatients.SelectedRows[0].Cells["PatientId"].Value);
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Patients SET Status=@Status WHERE PatientId=@PatientId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Status", PatientStatus.Archived.ToString());
                cmd.Parameters.AddWithValue("@PatientId", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadPatients();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearchName.Text;
            PatientStatus? status = null;
            if (cmbStatus.SelectedItem != null)
                status = (PatientStatus)Enum.Parse(typeof(PatientStatus), cmbStatus.SelectedItem.ToString());
            LoadPatients(name, status);
        }

        private void btnShowArchived_Click(object sender, EventArgs e)
        {
            LoadPatients("", PatientStatus.Archived);
        }
    }
}
