namespace Clinic
{
    partial class StaffDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnRegisterPatient;
        private System.Windows.Forms.Button btnScheduleAppointment;

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
            this.btnRegisterPatient = new System.Windows.Forms.Button();
            this.btnScheduleAppointment = new System.Windows.Forms.Button();
            // 
            // btnRegisterPatient
            // 
            this.btnRegisterPatient.Location = new System.Drawing.Point(50, 50);
            this.btnRegisterPatient.Name = "btnRegisterPatient";
            this.btnRegisterPatient.Size = new System.Drawing.Size(200, 40);
            this.btnRegisterPatient.Text = "Register Patient";
            this.btnRegisterPatient.UseVisualStyleBackColor = true;
            // 
            // btnScheduleAppointment
            // 
            this.btnScheduleAppointment.Location = new System.Drawing.Point(50, 110);
            this.btnScheduleAppointment.Name = "btnScheduleAppointment";
            this.btnScheduleAppointment.Size = new System.Drawing.Size(200, 40);
            this.btnScheduleAppointment.Text = "Schedule Appointment";
            this.btnScheduleAppointment.UseVisualStyleBackColor = true;
            // 
            // StaffDashboard
            // 
            this.Text = "Staff Dashboard";
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegisterPatient);
            this.Controls.Add(this.btnScheduleAppointment);
        }
    }
}
