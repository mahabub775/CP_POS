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
using Microsoft.AspNetCore.Components.Routing;

namespace CP_POS.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _RoleManager;
        private  CpPosContext _CpPosContext;
        private readonly IConfiguration _configuration;
        private readonly SignInManager<IdentityUser> _SignInManager;
        public UserController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<IdentityUser> signInManager, CpPosContext CpPosContext, IConfiguration configuration)
        {
            _userManager = userManager;
            _SignInManager = signInManager;
            _RoleManager = roleManager;
            _CpPosContext = CpPosContext;
            _configuration = configuration;
        }


        #region User

        [HttpGet("Gets")]
        public async Task<ActionResult> Gets()
        {

            var usersWithRoles = await (from user in _CpPosContext.ApplicationUser 
                                  select new
                                  {
                                      UserId = user.Id,
                                      Username = user.UserName,
                                      Name = user.Name,
                                      Email = user.Email,
                                      PhoneNumber = user.PhoneNumber,
                                      Address = user.Address,
                                      
                                      RoleNames = (from userRole in _RoleManager.Roles
                                                   join role in _CpPosContext.UserRoles on userRole.Id
                                                   equals role.RoleId where user.Id ==role.UserId
                                                   select userRole.Name).ToList()
                                  }).ToListAsync();
            return Ok(usersWithRoles);
        }

        [HttpGet("Get")]
        public async Task<ActionResult> Get(string Userid)
        {

            //var tokenExpiration = User.FindFirst("exp")?.Value;

            //// Check if the token expiration claim exists
            //if (tokenExpiration == null)
            //{
            //    return Unauthorized("Token does not contain an expiration claim.");
            //}

            //// Parse the token expiration time
            //var expirationTime = DateTimeOffset.FromUnixTimeSeconds(long.Parse(tokenExpiration));

            //// Compare with the current time
            //if (expirationTime <= DateTimeOffset.UtcNow)
            //{
            //    return Unauthorized("Token has expired.");
            //}



            var result = await _userManager.FindByIdAsync(Userid);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public async Task<ActionResult> Delete(string Userid)
        {
            var oUser = await _userManager.FindByIdAsync(Userid);
            var result = await _userManager.DeleteAsync(oUser);
          
            return Ok(result);
        }

        [HttpPost("Registration")]  
        public async Task<ActionResult> Registration(RegisterModel oModel)
        {

            var oUser = new ApplicationUser { UserName = oModel.UserName, Email = oModel.Email, Name = oModel.Name , PhoneNumber = oModel.PhoneNumber, Address = oModel.Address};
            var result = await _userManager.CreateAsync(oUser, oModel.Password);
            if (result.Succeeded)
            {
                return Ok(new {message = "1"});
            }
            else
            {
                string sErrorMessage = string.Empty;
                foreach (var error in result.Errors)
                {
                    sErrorMessage+= error.Description;
                }
                return Ok(new { message = sErrorMessage });
            }

        }


        [HttpPut("UpdateUser")]
        public async Task<ActionResult> Updateuser(ApplicationUser oUser)
        {
            ApplicationUser oExistUser = (ApplicationUser) await _userManager.FindByIdAsync(oUser.Id);
            if (oExistUser == null)
            {
                return NotFound();
            }
            oExistUser.UserName = oUser.UserName;
            oExistUser.Email = oUser.Email;
            oExistUser.Name = oUser.Name;
            oExistUser.PhoneNumber = oUser.PhoneNumber;
            oExistUser.Address = oUser.Address;

            var result = await _userManager.UpdateAsync(oExistUser);
            if (result.Succeeded)
            {
                return Ok(new { message = "2" });
            }
            else
            {
                string sErrorMessage = string.Empty;
                foreach (var error in result.Errors)
                {
                    sErrorMessage += error.Description;
                }
                return Ok(new { message = sErrorMessage });
            }

        }       
        [HttpPut("ChangePassword")]
        public async Task<ActionResult> ChangePassword(ChangePasswordModel oModel)
        {
            var user = await _userManager.FindByIdAsync(oModel.userId);

            if (user == null)
            {
                return NotFound($"User with ID {oModel.userId} not found.");
            }

            //var token = await _userManager.GeneratePasswordResetTokenAsync(user);
           // var result = await _userManager.ResetPasswordAsync(user, token, newPassword);

            var result = await _userManager.ChangePasswordAsync(user, oModel.currentPassword, oModel.newPassword);

            if (result.Succeeded)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }

        #endregion

        #region expiration

        #endregion

        #region Role Mgt
        [HttpPost("RoleEntry")]
        
        public async Task<ActionResult> RoleEntry(ApplicationRole oRole)
        {
            var oApplicationRole = new ApplicationRole { Name = oRole.Name, NormalizedName = oRole.NormalizedName};
            var result = await _RoleManager.CreateAsync(oApplicationRole);
            if (result.Succeeded)
            {
                return Ok(result);
            }
            else
            {
                string sErrorMessage = string.Empty;
                foreach (var error in result.Errors)
                {
                    sErrorMessage += error.Description;
                }
                return Ok(sErrorMessage);
            }

        }
        [Authorize]
        [HttpPost("UserWiseRoleAssign")]
        public async Task<ActionResult> UserWiseRoleAssign(UserWiseRoleModel oUserWiseRoleModel)
        {
            var oUser = await _userManager.FindByIdAsync(oUserWiseRoleModel.UserId);
            var result = await _userManager.AddToRoleAsync(oUser, oUserWiseRoleModel.RoleName);
            if (result.Succeeded)
            {
                return Ok(result);
            }
            else
            {
                string sErrorMessage = string.Empty;
                foreach (var error in result.Errors)
                {
                    sErrorMessage += error.Description;
                }
                return Ok(sErrorMessage);
            }

        }
      
        
        
        #endregion
    }
}
