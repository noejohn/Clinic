namespace Clinic
{
    public enum UserRole
    {
        Admin,
        Doctor,
        Staff
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
    }
}
