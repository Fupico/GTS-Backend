using GTSProject.Services.UserManagement.Models.Dtos.UserDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserManagementSystem.Models.Dtos.BaseDtos;
using UserManagementSystem.Models.Dtos.LoginDtos;
using UserManagementSystem.Models.Dtos.UserDtos;
using UserManagementSystem.Services.Implementations;
using UserManagementSystem.Services.Interfaces;

namespace UserManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : CustomizedController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetUserProfile")]
        [AllowAnonymous]
        public async Task<IActionResult> GetUserProfile()
        {
            var result = await _userService.GetUserProfile();

            return ActionResultInstance(result);
        }

        [HttpGet("GetBirthdaysThisWeek")]
        [AllowAnonymous]
        public async Task<IActionResult> GetBirthdaysThisWeek()
        {
            var result = await _userService.GetBirthdaysThisWeek();

            return ActionResultInstance(result);
        }


        [HttpPost("UpdateUserProfile")]
        [AllowAnonymous]
        public async Task<IActionResult> UpdateUserProfile(UpdateUserProfileDto updateUserProfileDto)
        {
            var result = await _userService.UpdateUserProfile(updateUserProfileDto);

            return ActionResultInstance(result);
        }
    }
}
