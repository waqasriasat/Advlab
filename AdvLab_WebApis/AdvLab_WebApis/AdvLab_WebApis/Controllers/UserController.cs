using AdvLab_WebApis.Models;
using AdvLab_WebApis.Models.Temp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AdvLab_WebApis.Controllers
{
    [Route("API/Users")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly AppDBContext _appDBContext;
        private readonly IConfiguration _configuration;

        public UserController(AppDBContext appDBContext, IConfiguration configuration)
        {
            _appDBContext = appDBContext;
            _configuration = configuration;
        }
        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> GetLoginStatus([FromBody] Login logins)
        {
            try
            {
                var query = from us in _appDBContext.Users
                            join adcl in _appDBContext.AddConnLabs
                                on us.CNL equals adcl.LocCate into adclGroup
                            from adcl in adclGroup.DefaultIfEmpty()
                            join adl in _appDBContext.AddLocations
                                on us.Location equals adl.LocCate into adlGroup
                            from adl in adlGroup.DefaultIfEmpty()
                            where us.EmpID == logins.EmpID && us.UPassword == logins.UPassword
                            select new { User = us, AddConnLab = adcl, AddLocation = adl };

                var result = await query.FirstOrDefaultAsync();

                if (result == null || result.User == null)
                {
                    return NotFound("Wrong UserID and UserPassword");
                }

                var user = result.User;
                var adcl1 = result.AddConnLab;
                var adl1 = result.AddLocation;

                if (adcl1 != null && adcl1.LocActive == "No")
                {
                    return NotFound("Your ConnectingLab is Deactive");
                }

                if (adl1 != null && adl1.LocActive == "No")
                {
                    return NotFound("Your Location is Deactive");
                }

                if (user.Status == "No")
                {
                    return BadRequest("Your ID is Deactive");
                }

                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim("Userid", Convert.ToUInt32(user.EmpID).ToString()),
                    new Claim("UserName", user.UName),
                    new Claim("RoleID", Convert.ToUInt32(user.RoleID).ToString()),
                    new Claim("Roles", "Admin"), // Adjust based on user's actual role
                    new Claim("Date", DateTime.Now.ToString())
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    _configuration["Jwt:Issuer"],
                    _configuration["Jwt:Audience"],
                    claims,
                    expires: DateTime.Now.AddMinutes(120),
                    signingCredentials: signIn);

                var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);

                var loginLog = new LoginLog
                {
                    CompName = "YourCompName", // Replace with actual values
                    CompUser = "YourCompUser",
                    IP = "127.0.0.1",
                    MacAddress = "00:00:00:00:00:00",
                    LoginStatus = "Successful",
                    UserID = user.EmpID,
                    UserName = user.UName
                };
                //await InsertLoginLog(loginLog);

                return Ok(new
                {
                    user.EmpID,
                    user.UName,
                    user.CNL,
                    user.ClientV,
                    user.Depart,
                    user.SubDepart,
                    user.Placement,
                    user.Designation,
                    user.RoleID,
                    user.Location,
                    Token = jwtToken,
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpGet("{empId}")]
        [Authorize]
        public async Task<IActionResult> GetUserByEmpId(int empId)
        {
            try
            {
                var user = await _appDBContext.Users
                                .Where(us => us.EmpID == empId)
                                .FirstOrDefaultAsync();

                if (user == null)
                {
                    return NotFound($"User with EmpId {empId} not found.");
                }

                var userIdClaim = User.FindFirst("Userid")?.Value;

                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAllUsers()
        {
            try
            {
                var users = await _appDBContext.Users.ToListAsync();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> InsertUser([FromBody] User newUser)
        {
            try
            {
                _appDBContext.Users.Add(newUser);
                await _appDBContext.SaveChangesAsync();

                return Ok(newUser);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpPut("{empId}")]
        [Authorize]
        public async Task<IActionResult> UpdateUser(int empId, [FromBody] User updatedUser)
        {
            try
            {
                var existingUser = await _appDBContext.Users
                    .FirstOrDefaultAsync(us => us.EmpID == empId);

                if (existingUser == null)
                {
                    return NotFound($"User with EmpId {empId} not found.");
                }

                // Update properties based on your requirements
                existingUser.UName = updatedUser.UName;
                existingUser.Status = updatedUser.Status;
                existingUser.Location = updatedUser.Location;
                existingUser.ClientV = updatedUser.ClientV;
                existingUser.Depart = updatedUser.Depart;
                existingUser.Placement = updatedUser.Placement;


                await _appDBContext.SaveChangesAsync();

                return Ok(existingUser);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpDelete("{empId}")]
        [Authorize]
        public async Task<IActionResult> DeleteUser(int empId)
        {
            try
            {
                var userToDelete = await _appDBContext.Users
                    .FirstOrDefaultAsync(us => us.EmpID == empId);

                if (userToDelete == null)
                {
                    return NotFound($"User with EmpId {empId} not found.");
                }

                _appDBContext.Users.Remove(userToDelete);
                await _appDBContext.SaveChangesAsync();

                return Ok($"User with EmpId {empId} deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
