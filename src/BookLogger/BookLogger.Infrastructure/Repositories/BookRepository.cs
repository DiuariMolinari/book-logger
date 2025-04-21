using BookLogger.Domain.Entities;
using BookLogger.Domain.Interfaces;

namespace BookLogger.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        static List<Book> _bookList = new List<Book>();

        public BookRepository()
        {

        }

        public void Add(Book book)
        {
            _bookList.Add(book);
        }

        public void Remove(Book book)
        {
            _bookList.Remove(book);
        }

        public void Update(Book book)
        {
            var index = _bookList.IndexOf(book);
            if (index != -1)
            {
                _bookList[index] = book;
            }
        }
        public List<Book> GetAll()
        {
            return _bookList;
        }

        public Book? GetById(int id)
        {
            return _bookList.FirstOrDefault(b => b.Id == id);
        }

        public Book? GetByAuthor(int authorId)
        {
            return _bookList.FirstOrDefault(b => b.AuthorId == authorId);
        }
    }
}
