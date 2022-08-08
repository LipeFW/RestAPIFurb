using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RestAPIFurb.Models.Dto.Login;
using RestAPIFurb.Service;

namespace RestAPIFurb.Controllers
{
    [ApiController]
    [Route("ApiRESTFurb/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly TokenService _token;

        public AuthController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, TokenService token)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _token = token;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromBody] LoginRequestDto content)
        {
            var result = await _signInManager.PasswordSignInAsync(content.Username, content.Password, false, true);

            if (result.Succeeded)
                return Ok(new { token = _token.GenerateToken(content.Username) });

            return BadRequest("Usuário e/ou senha inválidos");
        }

        [Authorize]
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> CreateAccount([FromBody] LoginRequestDto content)
        {
            var user = new IdentityUser
            {
                UserName = content.Username
            };

            var result = await _userManager.CreateAsync(user, content.Password);

            if (!result.Succeeded)
                return BadRequest(result.Errors);

            await _signInManager.SignInAsync(user, false);

            return Ok();
        }
    }
}
