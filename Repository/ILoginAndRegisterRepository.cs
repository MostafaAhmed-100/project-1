﻿using WebApplication1.Entitys;

namespace WebApplication1.Repository
{
    public interface ILoginAndRegisterRepository
    {
        public Task<User> CreateUser(User user);
        
        public Task<User?> GetByEmail(string email);
    }
}
