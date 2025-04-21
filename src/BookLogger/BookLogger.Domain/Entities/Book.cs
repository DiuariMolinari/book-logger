namespace BookLogger.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public int YearPublished { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; } = default!;

        public int GenreId { get; set; }
        public Genre Genre { get; set; } = default!;
    }
}
