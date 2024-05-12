using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CP_POS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;

namespace CP_POS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _RoleManager;
        private  CpPosContext _CpPosContext;
        private readonly IConfiguration _configuration;
        private readonly SignInManager<IdentityUser> _SignInManager;
        public AuthController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<IdentityUser> signInManager, CpPosContext CpPosContext, IConfiguration configuration)
        {
            _userManager = userManager;
            _SignInManager = signInManager;
            _RoleManager = roleManager;
            _CpPosContext = CpPosContext;
            _configuration = configuration;
        }



      
        [HttpPost("Login")]  
        public async Task<ActionResult> Login(LoginModel oModel)
        {
            var user = (ApplicationUser) await _userManager.FindByNameAsync (oModel.UserName);
            if(user == null)
            {
                    return NotFound();   
            }
            if (user != null && await _userManager.CheckPasswordAsync(user, oModel.Password))
            {
                var userRoles = await _userManager.GetRolesAsync(user);

                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };
                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }
                var token = GetToken(authClaims);

                return Ok(new
                {
                    user = user,
                    userRoles = userRoles,
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
            }
           
            return Unauthorized();
        }

        private JwtSecurityToken GetToken(List<Claim> authClaims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddHours(2),//allow max 2 hrs
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

            return token;
        }

        [HttpGet("LogOut")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(IdentityConstants.ApplicationScheme); 
            return Ok(new { message = "LogOut" });
        }



        #region Role Mgt
       
        
        
        #endregion
    }
}
