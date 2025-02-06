
namespace PortalLiterario.Entidad
{
    public class Library
    {
        public int LibraryId { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? Url { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
