using BookLogger.Domain.Entities;
using BookLogger.Domain.Interfaces;

namespace BookLogger.Application.Services
{
    public class BookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void AddBook(string title, int authorId, int genreId, int yearPublished)
        {
            var book = new Book
            {
                Title = title,
                AuthorId = authorId,
                GenreId = genreId,
                YearPublished = yearPublished
            };
            _bookRepository.Add(book);
        }

        public void RemoveBook(int id)
        {
            var book = _bookRepository.GetById(id);
            if (book != null)
            {
                _bookRepository.Remove(book);
            }
        }

        public void UpdateBook(int id, string title, int authorId, int genreId, int yearPublished)
        {
            var book = _bookRepository.GetById(id);
            if (book != null)
            {
                book.Title = title;
                book.AuthorId = authorId;
                book.GenreId = genreId;
                book.YearPublished = yearPublished;
                _bookRepository.Update(book);
            }
        }

        public List<Book> GetAllBooks()
        {
            return _bookRepository.GetAll();
        }

        public Book? GetBookById(int id)
        {
            return _bookRepository.GetById(id);
        }

        public Book? GetBookByAuthor(int authorId)
        {
            return _bookRepository.GetByAuthor(authorId);
        }
    }
}
