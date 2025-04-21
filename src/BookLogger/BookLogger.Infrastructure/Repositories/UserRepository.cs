using BookLogger.Domain.Entities;
using BookLogger.Domain.Interfaces;

namespace BookLogger.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        static readonly List<User> _userList = new List<User>();

        public UserRepository()
        {

        }

        public void Add(User user)
        {
            _userList.Add(user);
        }

        public void Remove(User user)
        {
            _userList.Remove(user);
        }

        public void Update(User user)
        {
            var index = _userList.IndexOf(user);
            if (index != -1)
            {
                _userList[index] = user;
            }
        }
        public List<User> GetAll()
        {
            return _userList;
        }

        public User? GetById(int id)
        {
            return _userList.FirstOrDefault(b => b.Id == id);
        }

        public User? GetByEmail(string email)
        {
            return _userList.FirstOrDefault(b => b.Email == email);
        }

        public User? GetByUsername(string username)
        {
            return _userList.FirstOrDefault(b => b.Name == username);
        }
    }
}
