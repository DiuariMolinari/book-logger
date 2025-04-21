using BookLogger.Domain.Entities;
using BookLogger.Domain.Interfaces;

namespace BookLogger.Application.Services
{
    public class AuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public void AddAuthor(Author author)
        {
            _authorRepository.Add(author);
        }

        public void RemoveAuthor(Author author)
        {
            _authorRepository.Remove(author);
        }

        public void UpdateAuthor(Author author)
        {
            _authorRepository.Update(author);
        }

        public IList<Author> GetAllAuthors()
        {
            return _authorRepository.GetAll();
        }

        public Author? GetAuthorById(int id)
        {
            return _authorRepository.GetById(id);
        }

        public Author? GetAuthorByName(string authorName)
        {
            return _authorRepository.GetByName(authorName);
        }
    }
}
