using Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class UserRepository
    {
        private readonly MyDbContext dbContext;

        public UserRepository(MyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<User> GetAll()        
            =>dbContext.Users.AsNoTracking().ToList();

        public User GetByUserName(string userName)
            =>dbContext.Users.AsNoTracking().Where(x=>x.UserName== userName).FirstOrDefault();
        
    }
}
