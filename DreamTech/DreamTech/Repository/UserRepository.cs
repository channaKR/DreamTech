using DreamTech.Data;
using DreamTech.Interface;
using DreamTech.Model;
using Microsoft.EntityFrameworkCore;

namespace DreamTech.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _dbcontext;

        public UserRepository(DataContext dbcontext) 
        {
            _dbcontext = dbcontext;
        }

        public User GetUser(int id)
        {
           return _dbcontext.users.Where(u => u.UserId == id).FirstOrDefault();
        }

        public ICollection<User> GetUsers()
        {
            return _dbcontext.users.OrderBy(u=>u.UserId).ToList();  
        }
    }
}
