using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlannerApp.API.Services;
using PlannerApp.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlannerApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        // api/auth/register
        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterRequest model)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.RegisterUserAsync(model);
                if (result.IsSuccess)
                    return Ok(result);
                return BadRequest(result);
            }
            return BadRequest("Some properties are not valid.");
        }

        // api/auth/login
        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginRequest model)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.LoginUserAsync(model);
                if (result.IsSuccess)
                    return Ok(result);
            }
            return BadRequest("Some properties are not valid.");
        }
    }
}
