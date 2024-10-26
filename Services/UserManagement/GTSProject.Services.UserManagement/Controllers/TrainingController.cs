using GTSProject.Services.UserManagement.Models.Dtos.TrainingDtos;
using GTSProject.Services.UserManagement.Models.Dtos.UserDtos;
using GTSProject.Services.UserManagement.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UserManagementSystem.Controllers;
using UserManagementSystem.Services.Interfaces;

namespace GTSProject.Services.UserManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController: CustomizedController
    {
        private readonly ITrainingService _trainingService;

        public TrainingController(ITrainingService trainingService)
        {
            _trainingService = trainingService;
        }

        [HttpGet("GetTraining")]
        [AllowAnonymous]
        public async Task<IActionResult> GetTraining()
        {
            var result = await _trainingService.GetTraining();

            return ActionResultInstance(result);
        }

        [HttpPost("InsertTraining")]
        [AllowAnonymous]
        public async Task<IActionResult> InsertTraining(InsertTrainingDto insertTrainingDto)
        {
            var result = await _trainingService.InsertTraining(insertTrainingDto);

            return ActionResultInstance(result);
        }

        [HttpPut("UpdateTraining")]
        [AllowAnonymous]
        public async Task<IActionResult> UpdateTraining(UpdateTrainingDto updateTrainingDto)
        {
            var result = await _trainingService.UpdateTraining(updateTrainingDto);

            return ActionResultInstance(result);
        }       

        [HttpDelete("DeleteTraining")]
        [AllowAnonymous]
        public async Task<IActionResult> DeleteTraining(DeleteTrainingDto deleteTrainingDto)
        {
            var result = await _trainingService.DeleteTraining(deleteTrainingDto);

            return ActionResultInstance(result);
        }

        [HttpGet("GetTrainingById/{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetTrainingById(string id)
        {
            var result = await _trainingService.GetTrainingById(id);

            return ActionResultInstance(result);
        }
    }
}
