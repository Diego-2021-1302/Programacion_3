
namespace PortalLiterario.Entidad
{
    public class BookPopularity
    {
        public int BookId { get; set; }
        public int LoanCount { get; set; } // Total de préstamos
        public int ReservationCount { get; set; } // Total de reservas
        public int TotalPopularityScore => LoanCount + ReservationCount; // Popularidad calculada

        // Relación con libro
        public Book Book { get; set; }
    }
}
