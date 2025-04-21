using BookLogger.Domain.Entities;

namespace BookLogger.Domain.Interfaces
{
    public interface IUserRepository
    {
        void Add(User user);
        void Remove(User user);
        void Update(User user);
        User? GetById(int id);
        List<User> GetAll();
        User? GetByEmail(string email);
        User? GetByUsername(string username);
    }
}