using BookLogger.Domain.Entities;
using BookLogger.Domain.Interfaces;

namespace BookLogger.Infrastructure.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        static readonly List<Author> _authorList = new List<Author>();

        public AuthorRepository()
        {

        }

        public void Add(Author author)
        {
            _authorList.Add(author);
        }

        public void Remove(Author author)
        {
            _authorList.Remove(author);
        }

        public void Update(Author author)
        {
            var index = _authorList.IndexOf(author);
            if (index != -1)
            {
                _authorList[index] = author;
            }
        }
        public IList<Author> GetAll()
        {
            return _authorList;
        }

        public Author? GetById(int id)
        {
            return _authorList.FirstOrDefault(b => b.Id == id);
        }

        public Author? GetByName(string authorName)
        {
            return _authorList.FirstOrDefault(b => b.Name == authorName);
        }
    }
}
