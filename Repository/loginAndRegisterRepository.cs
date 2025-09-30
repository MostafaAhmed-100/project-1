using Microsoft.EntityFrameworkCore;
using WebApplication1.Entitys;

namespace WebApplication1.Repository
{
    public class loginAndRegisterRepository : ILoginAndRegisterRepository
    {
        private readonly AppDbContext _AppDbcontext;

        public loginAndRegisterRepository(AppDbContext appDbcontext)
        {
            _AppDbcontext = appDbcontext;
        }

        public async Task<User> CreateUser(User user)
        {
            var CreateUser = await _AppDbcontext.Users.AddAsync(user);
            await _AppDbcontext.SaveChangesAsync();
            return user;
        }

        public async Task<User?> GetByEmail(string email)
        {
            var UserEmail =await _AppDbcontext.Users.FirstOrDefaultAsync(u => u.UserEmail == email);
            return UserEmail;
        }
    }      
}          
           
           