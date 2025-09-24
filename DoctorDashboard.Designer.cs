namespace Clinic
{
    partial class DoctorDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Button btnUpdateDiagnosis;
        private System.Windows.Forms.Button btnMarkCompleted;

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
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.btnUpdateDiagnosis = new System.Windows.Forms.Button();
            this.btnMarkCompleted = new System.Windows.Forms.Button();
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.Location = new System.Drawing.Point(30, 30);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.Size = new System.Drawing.Size(600, 200);
            this.dgvAppointments.TabIndex = 0;
            // 
            // btnUpdateDiagnosis
            // 
            this.btnUpdateDiagnosis.Location = new System.Drawing.Point(650, 30);
            this.btnUpdateDiagnosis.Name = "btnUpdateDiagnosis";
            this.btnUpdateDiagnosis.Size = new System.Drawing.Size(120, 40);
            this.btnUpdateDiagnosis.Text = "Update Diagnosis";
            this.btnUpdateDiagnosis.UseVisualStyleBackColor = true;
            // 
            // btnMarkCompleted
            // 
            this.btnMarkCompleted.Location = new System.Drawing.Point(650, 90);
            this.btnMarkCompleted.Name = "btnMarkCompleted";
            this.btnMarkCompleted.Size = new System.Drawing.Size(120, 40);
            this.btnMarkCompleted.Text = "Mark Completed";
            this.btnMarkCompleted.UseVisualStyleBackColor = true;
            // 
            // DoctorDashboard
            // 
            this.Text = "Doctor Dashboard";
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.btnUpdateDiagnosis);
            this.Controls.Add(this.btnMarkCompleted);
        }
    }
}
