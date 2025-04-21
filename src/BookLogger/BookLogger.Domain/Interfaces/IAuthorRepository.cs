using BookLogger.Domain.Entities;

namespace BookLogger.Domain.Interfaces
{
    public interface IAuthorRepository
    {
        void Add(Author author);
        void Remove(Author author);
        void Update(Author author);
        IList<Author> GetAll();
        Author? GetById(int id);
        Author? GetByName(string authorName);
    }
}