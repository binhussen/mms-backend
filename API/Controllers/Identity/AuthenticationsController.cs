﻿using AutoMapper;
using Contracts.Service;
using DataModel.Identity.Models;
using DataModel.Identity.Services;
using DataModel.Models.DTOs.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Identity
{
    [Route("api/authentications")]
    [ApiController]
    public class AuthenticationsController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IAuthenticationService _authManager;
        public AuthenticationsController(ILoggerManager logger, IMapper mapper, UserManager<ApplicationUser> userManager, IAuthenticationService authManager)
        {
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
            _authManager = authManager;
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser([FromBody] UserForRegistrationDto userForRegistration)
        {
            var user = _mapper.Map<ApplicationUser>(userForRegistration);

            var result = await _userManager.CreateAsync(user, userForRegistration.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }

                return BadRequest(ModelState);
            }

            if (!userForRegistration.Roles.Any())
            {
                _logger.LogInfo("Roles doesn't exist in the registration DTO object, adding the default one.");
                await _userManager.AddToRoleAsync(user, "Manager");
            }
            else
            {
                await _userManager.AddToRolesAsync(user, userForRegistration.Roles);
            }

            return StatusCode(201);
        }


        [HttpPost("login")]
        public async Task<IActionResult> Authenticate([FromBody] UserForAuthenticationDto user)
        {
            var result = await _authManager.Login(user);

            if (result.Succeeded)
            {
                return Ok(new { WellCome = await _authManager.CreateToken() });
            }
            if (result.IsLockedOut)
            {
                _logger.LogWarn($"{nameof(Authenticate)}: Your account is locked out.");
                return StatusCode(423, "The account is locked out for 5 minutes");
            }
            else
            {
                _logger.LogWarn($"{nameof(Authenticate)}: Authentication failed. Wrong user name or password.");
                return Unauthorized();
            }
        }
    }
}
