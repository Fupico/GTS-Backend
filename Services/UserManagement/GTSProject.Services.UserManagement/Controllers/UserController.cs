using GTSProject.Services.UserManagement.Models.Dtos.UserDtos;
using GTSProject.Services.UserManagement.Models.Dtos.UserTrainingDtos;
using GTSProject.Services.UserManagement.Services.Interfaces;
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
        private readonly IUserTrainingService _userTrainingService;

        public UserController(IUserService userService, IUserTrainingService userTrainingService)
        {
            _userService = userService;
            _userTrainingService = userTrainingService;
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

        //Kullanıcının Eğitim Aldığını Ekleme
        [HttpPost("AddUserTraining")]
        [AllowAnonymous]
        public async Task<IActionResult> AddUserTraining([FromBody] AddUserTrainingDto addUserTrainingDto)
        {
            var result = await _userTrainingService.AddUserTraining(addUserTrainingDto);
            return ActionResultInstance(result);
        }

        //Kullanıcının Aldığı Eğitimi Güncelleme
        [HttpPut("UpdateUserTraining")]
        public async Task<IActionResult> UpdateUserTraining([FromBody] UpdateUserTrainingDto updateUserTrainingDto)
        {
            var result = await _userTrainingService.UpdateUserTraining(updateUserTrainingDto);
            return ActionResultInstance(result);
        }

        //Kullanıcının Katıldığı Eğitimleri Çekme
        [HttpGet("GetUserAttendedTrainings")]
        [AllowAnonymous]
        public async Task<IActionResult> GetUserAttendedTrainings()
        {
            var result = await _userTrainingService.GetUserAttendedTrainings();
            return ActionResultInstance(result);
        }

        //Kullanıcının Katılmadığı Eğitimleri Çekme
        [HttpGet("GetUserNotAttendedTrainings")]
        [AllowAnonymous]
        public async Task<IActionResult> GetUserNotAttendedTrainings()
        {
            var result = await _userTrainingService.GetUserNotAttendedTrainings();
            return ActionResultInstance(result);
        }

        // Kullanıcının Önerilen Eğitimlerini Çekme
        [HttpGet("GetUserRecommendedTrainings")]
        [AllowAnonymous]
        public async Task<IActionResult> GetUserRecommendedTrainings()
        {
            var result = await _userTrainingService.GetUserRecommendedTrainings();
            return ActionResultInstance(result);
        }

        // Kullanıcının Katılmadığı Rastgele Eğitim Çekme
        [HttpGet("GetRandomNotAttendedTraining")]
        [AllowAnonymous]
        public async Task<IActionResult> GetRandomNotAttendedTraining()
        {
            var result = await _userTrainingService.GetRandomNotAttendedTraining();
            return ActionResultInstance(result);
        }


    }
}
