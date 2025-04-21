using BookLogger.Domain.Entities;

namespace BookLogger.Domain.Interfaces
{
    public interface IGenreRepository
    {
        void Add(Genre genre);
        void Remove(Genre genre);
        void Update(Genre genre);
        List<Genre> GetAll();
        Genre? GetById(int id);
        Genre? GetByName(string genreName);
    }
}