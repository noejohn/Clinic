namespace Clinic
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnManageDoctors;
        private System.Windows.Forms.Button btnManagePatients;
        private System.Windows.Forms.Button btnManageAppointments;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnManageDoctors = new System.Windows.Forms.Button();
            this.btnManagePatients = new System.Windows.Forms.Button();
            this.btnManageAppointments = new System.Windows.Forms.Button();
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Location = new System.Drawing.Point(50, 50);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(200, 40);
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            // 
            // btnManageDoctors
            // 
            this.btnManageDoctors.Location = new System.Drawing.Point(50, 110);
            this.btnManageDoctors.Name = "btnManageDoctors";
            this.btnManageDoctors.Size = new System.Drawing.Size(200, 40);
            this.btnManageDoctors.Text = "Manage Doctors";
            this.btnManageDoctors.UseVisualStyleBackColor = true;
            // 
            // btnManagePatients
            // 
            this.btnManagePatients.Location = new System.Drawing.Point(50, 170);
            this.btnManagePatients.Name = "btnManagePatients";
            this.btnManagePatients.Size = new System.Drawing.Size(200, 40);
            this.btnManagePatients.Text = "Manage Patients";
            this.btnManagePatients.UseVisualStyleBackColor = true;
            // 
            // btnManageAppointments
            // 
            this.btnManageAppointments.Location = new System.Drawing.Point(50, 230);
            this.btnManageAppointments.Name = "btnManageAppointments";
            this.btnManageAppointments.Size = new System.Drawing.Size(200, 40);
            this.btnManageAppointments.Text = "Manage Appointments";
            this.btnManageAppointments.UseVisualStyleBackColor = true;
            // 
            // AdminDashboard
            // 
            this.Text = "Admin Dashboard";
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnManageDoctors);
            this.Controls.Add(this.btnManagePatients);
            this.Controls.Add(this.btnManageAppointments);
        }
    }
}
