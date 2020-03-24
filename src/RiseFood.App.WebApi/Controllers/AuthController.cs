using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RiseFood.App.WebAPi.DTO;

namespace RiseFood.App.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : MainConttroller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public AuthController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(UserDto userDto)
        {
            var user = new IdentityUser
            {
                UserName =  userDto.UserName,
                Email =  userDto.Email,
                EmailConfirmed = true
            };

            var result =  await _userManager.CreateAsync(user, userDto.Password);

            if (!result.Succeeded) return BadRequest(result.Errors);

            await _signInManager.SignInAsync(user, false);

            return Ok();
            
        }
    }
}