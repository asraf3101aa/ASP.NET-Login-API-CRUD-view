using Login_And_CRUD_API.Data;
using Login_And_CRUD_API.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace Login_And_CRUD_API.Controllers
{
    [ApiController]
    [Route("api/Login")]
    public class AccessController : Controller
    {
        private readonly LoginDbContext logindbContext;

        public AccessController(LoginDbContext logindbContext)
        {
            this.logindbContext = logindbContext;
        }
        
        [HttpGet]
        [Route("{email}")]
        public async Task<IActionResult> Login([FromRoute] string email)
        {
            var user = await logindbContext.Users.SingleOrDefaultAsync(item => item.Email == email);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

    }
}
