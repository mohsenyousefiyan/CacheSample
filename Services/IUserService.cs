using Domain;
using System.Collections.Generic;

namespace Services
{
    public interface IUserService
    {
        List<User> GetUsers();
        User GetByUserName(string  userName);
    }
}
