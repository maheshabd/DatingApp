using API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext dataContext1;
        public UsersController(DataContext dataContext)
        {
            this.dataContext1 = dataContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await dataContext1.Users.ToListAsync();
            return Ok(users);
        }

        [HttpPost("id")]
        public async Task<IActionResult> GetUsers(int id)
        {
            var users = await dataContext1.Users.FindAsync(id);
            return Ok(users);
        }
    }
}
