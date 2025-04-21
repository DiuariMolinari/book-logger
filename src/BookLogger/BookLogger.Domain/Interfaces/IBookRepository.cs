using BookLogger.Domain.Entities;

namespace BookLogger.Domain.Interfaces
{
    public interface IBookRepository
    {
        void Add(Book book);
        void Remove(Book book);
        void Update(Book book);
        List<Book> GetAll();
        Book? GetById(int id);
        Book? GetByAuthor(int authorId);
    }
}