using Contracts.Services;
using Contracts.Services.DTO.FamilyMembers;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[login]")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _service;

        public LoginController(ILoginService service)
        {
            _service = service;
        }

        [HttpPost("/login")]
        public async Task<IActionResult> Login([FromBody] LoginDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _service.Login(model);
            if (result.Succeeded)
            {
                return Ok(result);
            }

            return BadRequest(new { message = "Invalid username or password." });
        }

        [HttpPost("/register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto model)
        {
            var result = await _service.Register(model);
            if (result.Id > 0)
            {
                return Ok(result);
            }

            return BadRequest(new { message = "Invalid username or password." });
        }

        [HttpGet("/get-all-members")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAll();
            if (result.Any())
            {
                return Ok(result);
            }

            return BadRequest(new { message = "No member has been found!" });
        }
    }
}
