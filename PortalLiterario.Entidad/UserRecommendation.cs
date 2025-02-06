
namespace PortalLiterario.Entidad
{
    public class UserRecommendation
    {
        public int RecommendationId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime GeneratedTime { get; set; }
        public string Reason { get; set; }
        public Users User { get; set; }
        public Book Book { get; set; }
    }
}
