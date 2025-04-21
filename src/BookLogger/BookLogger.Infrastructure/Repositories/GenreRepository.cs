using BookLogger.Domain.Entities;
using BookLogger.Domain.Interfaces;

namespace BookLogger.Infrastructure.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        static readonly List<Genre> _genreList = new List<Genre>();

        public GenreRepository()
        {

        }

        public void Add(Genre genre)
        {
            _genreList.Add(genre);
        }

        public void Remove(Genre genre)
        {
            _genreList.Remove(genre);
        }

        public void Update(Genre genre)
        {
            var index = _genreList.IndexOf(genre);
            if (index != -1)
            {
                _genreList[index] = genre;
            }
        }
        public List<Genre> GetAll()
        {
            return _genreList;
        }

        public Genre? GetById(int id)
        {
            return _genreList.FirstOrDefault(b => b.Id == id);
        }

        public Genre? GetByName(string genreName)
        {
            return _genreList.FirstOrDefault(b => b.Name == genreName);
        }
    }
}
