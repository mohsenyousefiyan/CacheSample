using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace CacheSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        
        private readonly IUserService userService;

        public UserController(IUserService userService )
        {            
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult GetUser(string userName)
        {
            var user = userService.GetByUserName(userName);
            if(user == null)
                return NotFound();

            return Ok(user);
        }
    }
}
