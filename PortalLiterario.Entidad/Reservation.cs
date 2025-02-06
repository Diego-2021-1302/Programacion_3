
namespace PortalLiterario.Entidad

{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public DateTime ReservationDate { get; set; }
        public string ReservationStatus { get; set; }

        public Book Book { get; set; }
        public Users User { get; set; }
    }
}
