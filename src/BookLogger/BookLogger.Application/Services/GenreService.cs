using BookLogger.Domain.Entities;
using BookLogger.Domain.Interfaces;

namespace BookLogger.Application.Services
{
    public class GenreService
    {
        private readonly IGenreRepository _genreRepository;

        public GenreService(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public void AddGenre(string genreName)
        {
            var genre = new Genre
            {
                Name = genreName
            };
            _genreRepository.Add(genre);
        }

        public void RemoveGenre(int id)
        {
            var genre = _genreRepository.GetById(id);
            if (genre != null)
            {
                _genreRepository.Remove(genre);
            }
        }

        public void UpdateGenre(int id, string genreName)
        {
            var genre = _genreRepository.GetById(id);
            if (genre != null)
            {
                genre.Name = genreName;
                _genreRepository.Update(genre);
            }
        }

        public List<Genre> GetAllGenres()
        {
            return _genreRepository.GetAll();
        }

        public Genre? GetGenreById(int id)
        {
            return _genreRepository.GetById(id);
        }

        public Genre? GetGenreByName(string genreName)
        {
            return _genreRepository.GetByName(genreName);
        }
    }
}
