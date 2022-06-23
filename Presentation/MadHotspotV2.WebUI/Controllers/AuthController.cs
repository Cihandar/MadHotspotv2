using MadHotspotV2.Application.Dtos.AppUsers;
using MadHotspotV2.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MadHotspotV2.WebUI.Controllers
{
    [AllowAnonymous]
    [Route("Auth")]
    public class AuthController : Controller
    {
        IAuthCommand _authCommand;

        public AuthController(IAuthCommand authCommand)
        {
            _authCommand = authCommand;
        }

        [Route("Login")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("Login")]
        public async Task<ActionResult> Login(LoginRequestDto loginRequestDto)
        {
            var loginResponseDto = await _authCommand.LoginAsync(loginRequestDto);
            return Json(loginResponseDto);
        }
    }
}
