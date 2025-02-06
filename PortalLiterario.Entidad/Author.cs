
namespace PortalLiterario.Entidad
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string? Biography { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
