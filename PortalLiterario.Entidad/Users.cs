
namespace PortalLiterario.Entidad

{
    public class Users
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public int Role { get; set; } // 1: Admin, 2: Client
        public DateTime CreationDate { get; set; }

        // Relationships with Loan, Reservation and Notifications.
        public ICollection<Loan> Loans { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<Notification> Notifications { get; set; }
    }
}
