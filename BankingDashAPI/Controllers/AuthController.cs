using BankingDashAPI.Data;
using BankingDashAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BankingDashAPI.Controllers
{
    [ApiController]                       
    [Route("api/[controller]")]           // gives /api/auth


    
    public class AuthController : ControllerBase   //  use ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]               // /api/auth/login
        public IActionResult Login([FromBody] LoginRequest request)
        {
            var user = _context.AdminUsers
         .FirstOrDefault(x =>
             x.UserName == request.userName &&
             x.PasswordHash == request.password);

            if (user == null)
                return Unauthorized("Invalid username or password");

            return Ok(new LoginResponse
            {
                Token = "Fake-JWT-Token"
            });
        }
    }
}
