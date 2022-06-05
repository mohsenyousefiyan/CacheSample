using DAL;
using Domain;

namespace Services
{
    public class StartupSystemService : IStartupSystemService
    {
        
        private readonly IUserService userService;
        private readonly ICacheProviderService cacheProviderService;

        public StartupSystemService(IUserService userService,ICacheProviderService cacheProviderService)
        {            
            this.userService = userService;
            this.cacheProviderService = cacheProviderService;
        }
        public void Start()
        {
            CacheAllUser();
        }

        private void CacheAllUser()
        {
            var users=userService.GetUsers();
            foreach (var user in users)
                cacheProviderService.Set(CacheNameSpace.User.ToString(), user.UserName, user);
        }
    }
}
