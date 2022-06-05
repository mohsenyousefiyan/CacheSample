using DAL;
using Domain;
using System.Collections.Generic;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly UserRepository userRepository;
        private readonly ICacheProviderService cacheProviderService;

        public UserService(UserRepository userRepository, ICacheProviderService cacheProviderService)
        {
            this.userRepository = userRepository;
            this.cacheProviderService = cacheProviderService;
        }
        public User GetByUserName(string userName)
        {
            var user = cacheProviderService.Get<User>(CacheNameSpace.User.ToString(), userName);
            if (user == null)
            {
                user = userRepository.GetByUserName(userName);
                if (user is not null)
                    cacheProviderService.Set(CacheNameSpace.User.ToString(), userName, user);
            }

            return user;
        }

        public List<User> GetUsers()
            => userRepository.GetAll();

    }
}
