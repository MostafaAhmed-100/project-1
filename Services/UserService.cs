using WebApplication1.DTOS;
using WebApplication1.Entitys;
using WebApplication1.Models;
using WebApplication1.Repository;
using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Services
{
    public class UserService : IUserService 
    {
        private readonly IUserRepository _userRepository;

        private readonly PasswordHasher<string> _passwordHasher = new PasswordHasher<string>();

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<List<UserModel>> GetUsers()
        {
            var users = await _userRepository.GetUsersAsync();
            return users.Select(x => new UserModel
            {
                UserId = x.UserId,
                UserName = x.UserName,
                UserEmail = x.UserEmail,
                AddressId = x.AddressId,

            }).ToList();
        }
        public async Task<UserModel?> GetUserById(int id)
        {
            var Result =await _userRepository.GetByIdAsync(id);
            if (Result == null) {return null;}
            return new UserModel
            {
                UserId = Result.UserId,
                UserName = Result.UserName,
                UserEmail = Result.UserEmail,
                AddressId = Result.AddressId,
            };
        }

        public async Task<UserModel> CreateUser(UserDTO userdto)
        {
            var user = new User
            {
                UserId = userdto.UserId,
                UserName = userdto.UserName,
                UserEmail = userdto.UserEmail,
                UserPassword = _passwordHasher.HashPassword(userdto.UserEmail + userdto.UserName, userdto.UserPassword)
            };
            var Create = await _userRepository.CreateUser(user);
            return new UserModel
            {
                UserId = Create.UserId,
                UserName = Create.UserName,
                UserEmail = Create.UserEmail,
            };
        }
        public async Task<UserDTO?> UpdateUser(int id, User user)
        {
            var Result = await _userRepository.UpdateByIdAsync(id, user);
            if (Result == null) return null;

            return new UserDTO
            {
                UserId = Result.UserId,
                UserName = Result.UserName,
                UserEmail = Result.UserEmail,
                UserPassword = Result.UserPassword,
                AddressId = Result.AddressId,
            };
        }


        public async Task<bool?> DeleteUser(int id)
        {
            var Result = await _userRepository.DeleteByIdAsync(id);
            if (Result == false) { return false; }
            return true;
        }



    }
}
