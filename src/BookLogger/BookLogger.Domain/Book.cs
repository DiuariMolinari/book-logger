namespace BookLogger.Domain
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public int ReleaseYear { get; set; }

        public Author Author { get; set; } = default!;
        public Genre Genre { get; set; } = default!;
    }
}
