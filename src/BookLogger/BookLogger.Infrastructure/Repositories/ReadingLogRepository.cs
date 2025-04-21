using BookLogger.Domain.Entities;
using BookLogger.Domain.Interfaces;

namespace BookLogger.Infrastructure.Repositories
{
    public class ReadingLogRepository : IReadingLogRepository
    {
        static readonly List<ReadingLog> _readingLogList = new List<ReadingLog>();

        public ReadingLogRepository()
        {

        }

        public void Add(ReadingLog readingLog)
        {
            _readingLogList.Add(readingLog);
        }

        public void Remove(ReadingLog readingLog)
        {
            _readingLogList.Remove(readingLog);
        }

        public void Update(ReadingLog readingLog)
        {
            var index = _readingLogList.IndexOf(readingLog);
            if (index != -1)
            {
                _readingLogList[index] = readingLog;
            }
        }
        public List<ReadingLog> GetAll()
        {
            return _readingLogList;
        }

        public ReadingLog? GetById(int id)
        {
            return _readingLogList.FirstOrDefault(b => b.Id == id);
        }

        public List<ReadingLog> GetByUser(int userId)
        {
            return _readingLogList.Where(b => b.UserId == userId).ToList();
        }

        public List<ReadingLog> GetByBook(int bookId)
        {
            return _readingLogList.Where(b => b.BookId == bookId).ToList();
        }
    }
}
