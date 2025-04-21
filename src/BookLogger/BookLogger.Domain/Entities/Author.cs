namespace BookLogger.Domain.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Country { get; set; } = default!;
    }
}
