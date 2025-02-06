
namespace PortalLiterario.Entidad

{
    public class Notification
    {
        public int NotificationId { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; }
        public string NotificationType { get; set; }
        public DateTime SentDate { get; set; }
        public bool IsRead { get; set; }

        public Users User { get; set; }
    }
}
