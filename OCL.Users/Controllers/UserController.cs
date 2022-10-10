using Microsoft.AspNetCore.Mvc;
using OCL.Users.Models;

namespace OCL.Users.Controllers
{
    [ApiController]
    [Route("/api/[controller]/{id}")]
    public class UserController : ControllerBase
    {
        [HttpGet]
       public User GetUserBy(int id)
        {
            return Models.User.GetUsers()
                .FirstOrDefault(p => p.Id == id) ?? new User();

        }
    }
}
