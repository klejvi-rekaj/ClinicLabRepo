using ClinicLab.Application.Models;
using ClinicLab.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClinicLab.Application.BusinessLogic
{
    public class AuthService
    {
        private readonly ClinicLabDbContext _context;

        public AuthService(ClinicLabDbContext context)
        {
            _context = context;
        }

        public bool Register(string username, string password, string role)
        {
            if (_context.Users.Any(u => u.Username == username))
                return false;

            CreatePasswordHash(password, out byte[] hash, out byte[] salt);

            var user = new User { Username = username, PasswordHash = hash, PasswordSalt = salt, Role = role };
            _context.Users.Add(user);
            _context.SaveChanges();
            return true;
        }

        public User Login(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == username);
            if (user == null || !VerifyPassword(password, user.PasswordHash, user.PasswordSalt))
                return null;
            return user;
        }

        private void CreatePasswordHash(string password, out byte[] hash, out byte[] salt)
        {
            using var hmac = new HMACSHA256();
            salt = hmac.Key;
            hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        }

        private bool VerifyPassword(string password, byte[] storedHash, byte[] storedSalt)
        {
            using var hmac = new HMACSHA256(storedSalt);
            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            return storedHash.SequenceEqual(computedHash);
        }

        internal User Login(object text1, object text2)
        {
            throw new NotImplementedException();
        }
    }
}
