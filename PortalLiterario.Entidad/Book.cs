
namespace PortalLiterario.Entidad
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public int PublicationYear { get; set; }
        public string ImageUrl { get; set; }
        public string BookStatus { get; set; } // Disponible, prestado o reservado
        public string PdfPath { get; set; }
        public int? PopularityScore { get; set; }
        public int LibraryId { get; set; }
        public Library Library { get; set; }

        public ICollection<BookGenre> BookGenres { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
