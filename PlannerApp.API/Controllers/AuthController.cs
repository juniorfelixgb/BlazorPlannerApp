using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlannerApp.API.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : Controller
    {
        [HttpPost]
        [Route("/register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [Route("/login")]
        public IActionResult Login(string email, string password)
        {
            return View();
        }
    }
}
