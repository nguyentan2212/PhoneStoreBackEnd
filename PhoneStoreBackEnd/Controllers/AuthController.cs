using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PhoneStoreBackEnd.Models;
using PhoneStoreBackEnd.Resources;
using PhoneStoreBackEnd.Services;

namespace PhoneStoreBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService authService;
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        #region AuthController Constructor
        public AuthController(IAuthService authService, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.authService = authService;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }
        #endregion

        [HttpGet("get")] 
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Administrator")]
        public async Task<AppUser> GetUser()
        {
            var result = await userManager.FindByNameAsync("admin");
            return result;
        }

        #region Application's user login
        [HttpPost("login")]
        public async Task<ActionResult<AuthResource>> Login([FromBody] LoginResource model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await userManager.FindByNameAsync(model.UserName);

            if (user == null)
            {
                return BadRequest(new { username = "no user with this name" });
            }

            var passwordValid = userManager.PasswordHasher.VerifyHashedPassword(user, user.PasswordHash, model.Password);
            if (passwordValid != PasswordVerificationResult.Success)
            {
                return BadRequest(new { password = "invalid password" });
            }
            var roles = await userManager.GetRolesAsync(user);
            return authService.GetAuthData(user.Id, roles.FirstOrDefault());
        }
        #endregion

        #region Customer register
        [HttpPost("register")]
        public async Task<ActionResult<AuthResource>> Register([FromBody] RegisterResource model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // user with this name already exists
            var user = await userManager.FindByNameAsync(model.UserName);
            if (user != null)
            {
                return BadRequest(new { username = "user with this name already exists" });
            }

            // create new application user
            var appUser = new AppUser() { UserName = model.UserName, PhoneNumber = model.PhoneNumber };
            var result = await userManager.CreateAsync(appUser, model.Password); 
      
            // find a role named staff
            var role = await roleManager.FindByNameAsync("Customer");
            // if staff role didn't exits, created ones
            if (role is null)
            {
                await roleManager.CreateAsync(new IdentityRole("Customer"));
            }
            await userManager.AddToRoleAsync(appUser, "Customer");

            if (result != IdentityResult.Success)
            {
                return BadRequest(new { error = result.Errors.ToList() });
            }

            return authService.GetAuthData(appUser.Id, "Customer");          
        }
        #endregion

        #region Create new role
        [HttpPost("newRole")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Administrator")]
        public async Task<ActionResult> NewRole([FromBody] string roleName)
        {
            var role = await roleManager.FindByNameAsync(roleName);
            // if staff role didn't exits, created ones
            if (role is null)
            {
                var result = await roleManager.CreateAsync(new IdentityRole(roleName));
                if (result != IdentityResult.Success)
                {
                    return BadRequest(new { error = result.Errors.ToList() });
                }
            }

            return Ok("Success");
        }
        #endregion
    }
}
