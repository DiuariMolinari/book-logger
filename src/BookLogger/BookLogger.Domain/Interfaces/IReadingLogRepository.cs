using BookLogger.Domain.Entities;

namespace BookLogger.Domain.Interfaces
{
    public interface IReadingLogRepository
    {
        void Add(ReadingLog readingLog);
        void Remove(ReadingLog readingLog);
        void Update(ReadingLog readingLog);
        List<ReadingLog> GetAll();
        ReadingLog? GetById(int id);
        List<ReadingLog> GetByUser(int userId);
        List<ReadingLog> GetByBook(int bookId);
    }
}