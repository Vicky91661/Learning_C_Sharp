using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using UserService.Data;
using UserService.Models;
using Microsoft.AspNetCore.Authorization;


namespace UserService.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UsersController:ControllerBase
    {
        private readonly UserContext _context;
        private readonly IConfiguration _configuration;
        private readonly ILogger<UsersController> _logger;

        public UsersController(UserContext context,IConfiguration configuration, ILogger<UsersController> logger){
            _configuration = configuration;
            _context = context;
            _logger=logger;
        }

        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(User user){
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetUser),new{id=user.Id},user);


        }
        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(User user){
            var dbUser = await _context.Users.FirstOrDefaultAsync(u=>u.Username==user.Username && u.Password == user.Password);
            if(dbUser == null){
                return Unauthorized();
            }
            var token = GenerateJwtToken(dbUser);
            return Ok(token);
        }
        private string GenerateJwtToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Username),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        [HttpGet("validate")]
        [Authorize]
        public IActionResult ValidateToken()
        {
            // If the token is valid, this endpoint will be hit.
           try
            {
                // Logging for debugging
                _logger.LogInformation("Request received for token validation");
                Console.WriteLine("Request received for token validation");

                var userId = User.FindFirst("sub")?.Value; // Get the user ID from the token if needed
                return Ok(new { Message = "Token is valid", UserId = userId });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in ValidateToken");
                Console.WriteLine($"Error in ValidateToken: {ex.Message}");
                return Unauthorized();
            }
        }
    }
}