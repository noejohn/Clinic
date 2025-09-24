using System;

namespace Clinic
{
    public enum PatientStatus
    {
        Active,
        Archived
    }

    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public PatientStatus Status { get; set; } = PatientStatus.Active;
    }

    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum AppointmentStatus
    {
        Scheduled,
        Completed
    }

    public class Appointment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime Date { get; set; }
        public AppointmentStatus Status { get; set; } = AppointmentStatus.Scheduled;
    }
}
