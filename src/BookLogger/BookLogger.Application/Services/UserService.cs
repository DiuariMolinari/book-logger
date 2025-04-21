using BookLogger.Domain.Entities;
using BookLogger.Domain.Interfaces;

namespace BookLogger.Application.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddUser(string name, string email, string password)
        {
            var user = new User
            {
                Name = name,
                Email = email,
            };
            _userRepository.Add(user);
        }

        public void RemoveUser(int id)
        {
            var user = _userRepository.GetById(id);
            if (user != null)
            {
                _userRepository.Remove(user);
            }
        }
        public void UpdateUser(int id, string name, string email, string password)
        {
            var user = _userRepository.GetById(id);
            if (user != null)
            {
                user.Name = name;
                user.Email = email;
                _userRepository.Update(user);
            }
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAll();
        }

        public User? GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }

        public User? GetUserByEmail(string email)
        {
            return _userRepository.GetByEmail(email);
        }

        public User? GetUserByUsername(string username)
        {
            return _userRepository.GetByUsername(username);
        }
    }
}
