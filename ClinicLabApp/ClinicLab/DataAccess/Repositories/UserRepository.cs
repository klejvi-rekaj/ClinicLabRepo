using System.Collections.Generic;
using System.Linq;
using ClinicLab.Application.Models;

namespace ClinicLab.DataAccess.Repositories
{
    public class UserRepository
    {
        private static List<User> _users = new List<User>();

        public List<User> GetAllUsers()
        {
            return _users.ToList();
        }

        public User GetUserById(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }

        public void AddUser(User user)
        {
            user.Id = _users.Count > 0 ? _users.Max(u => u.Id) + 1 : 1;
            _users.Add(user);
        }

        public void UpdateUser(User user)
        {
            var existingUser = GetUserById(user.Id);
            if (existingUser != null)
            {
                existingUser.Username = user.Username;
                existingUser.PasswordHash = user.PasswordHash;
                existingUser.Role = user.Role;
                existingUser.FullName = user.FullName;
                existingUser.Email = user.Email;
            }
        }

        public void DeleteUser(int id)
        {
            var user = GetUserById(id);
            if (user != null)
            {
                _users.Remove(user);
            }
        }
    }
}
