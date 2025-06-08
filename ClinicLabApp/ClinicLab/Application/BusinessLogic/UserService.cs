using System;
using System.Collections.Generic;
using ClinicLab.Application.Models;
using ClinicLab.DataAccess.Repositories;

namespace ClinicLab.Application.BusinessLogic
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        // Merr të gjithë përdoruesit (mund ta kufizosh në varësi të rolit)
        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        // Merr përdoruesin me id
        public User GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }

        // Shton përdorues të ri, vetëm Admin mund ta bëjë
        public void AddUser(User currentUser, User newUser)
        {
            if (currentUser.Role != UserRole.Admin)
                throw new UnauthorizedAccessException("Vetëm admin mund të shtojë përdorues.");

            // Shto këtu validime të tjera nëse do
            _userRepository.AddUser(newUser);
        }

        // Përditëson përdoruesin, vetëm Admin mund ta bëjë
        public void UpdateUser(User currentUser, User updatedUser)
        {
            if (currentUser.Role != UserRole.Admin)
                throw new UnauthorizedAccessException("Vetëm admin mund të përditësojë përdorues.");

            _userRepository.UpdateUser(updatedUser);
        }

        // Fshin përdoruesin me id, vetëm Admin mund ta bëjë
        public void DeleteUser(User currentUser, int id)
        {
            if (currentUser.Role != UserRole.Admin)
                throw new UnauthorizedAccessException("Vetëm admin mund të fshijë përdorues.");

            _userRepository.DeleteUser(id);
        }
    }
}
