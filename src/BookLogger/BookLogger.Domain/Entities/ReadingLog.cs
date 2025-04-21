namespace BookLogger.Domain.Entities
{
    public class ReadingLog
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Rating { get; set; }
        public string? Review { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }

        public int BookId { get; set; }
        public Book? Book { get; set; }
    }
}
