using BookLogger.Domain.Entities;
using BookLogger.Domain.Interfaces;

namespace BookLogger.Application.Services
{
    public class ReadingLogService
    {
        private readonly IReadingLogRepository _readingLogRepository;
        public ReadingLogService(IReadingLogRepository readingLogRepository) 
        {
            _readingLogRepository = readingLogRepository;
        }

        public void AddReadingLog(int bookId, int rating, DateTime startDate, DateTime endDate, int userId, string review)
        {
            var readingLog = new ReadingLog
            {
                UserId = userId,
                BookId = bookId,
                Rating = rating,
                Review = review,
                StartDate = startDate,
                EndDate = endDate,
            };
            _readingLogRepository.Add(readingLog);
        }

        public void RemoveReadingLog(int id)
        {
            var readingLog = _readingLogRepository.GetById(id);
            if (readingLog != null)
            {
                _readingLogRepository.Remove(readingLog);
            }
        }

        public void UpdateReadingLog(int id, int bookId, int rating, DateTime startDate, DateTime endDate, int userId, string review)
        {
            var readingLog = _readingLogRepository.GetById(id);
            if (readingLog != null)
            {
                readingLog.UserId = userId;
                readingLog.BookId = bookId;
                readingLog.Rating = rating;
                readingLog.Review = review;
                readingLog.StartDate = startDate;
                readingLog.EndDate = endDate;
                _readingLogRepository.Update(readingLog);
            }
        }

        public List<ReadingLog> GetAllReadingLogs()
        {
            return _readingLogRepository.GetAll();
        }

        public ReadingLog? GetReadingLogById(int id)
        {
            return _readingLogRepository.GetById(id);
        }

        public List<ReadingLog> GetReadingLogsByUserId(int userId)
        {
            return _readingLogRepository.GetByUser(userId);
        }
    }
}
