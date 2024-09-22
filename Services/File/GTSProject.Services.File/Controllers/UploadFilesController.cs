using GTSProject.Services.File.Dtos.RequestDtos.UploadFileRequestDtos;
using GTSProject.Services.File.Dtos.UploadFileDtos;
using GTSProject.Services.File.Services.UploadFileServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GTSProject.Services.File.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadFilesController : ControllerBase
    {
        private readonly IUploadFileService _uploadFileService;

        public UploadFilesController(IUploadFileService uploadFileService)
        {
            _uploadFileService = uploadFileService;
        }

        [HttpGet]
        public async Task<IActionResult> UploadFileList()
        {
            var values = await _uploadFileService.GetAllFilesAsync("mssql");
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUploadFileById(Guid id)
        {
            var values = await _uploadFileService.GetFileByIdAsync(id, "mssql");
            return Ok(values);
        }

        //[HttpPost]
        //public async Task<IActionResult> CreateUploadFile([FromForm]  CreateUploadFileDto createUploadFileDto)
        //{
        //    await _uploadFileService.CreateUploadFileAsync(createUploadFileDto);
        //    return Ok("Dosya başarıyla eklendi");
        //}

        [HttpPost]
        public async Task<IActionResult> CreateUploadFile([FromForm] CreateUploadFileRequestDto createUploadFileRequestDto)
        {
            await _uploadFileService.AddFileAsync(createUploadFileRequestDto);
            return Ok("Dosya başarıyla eklendi");
        }
        [HttpPost("multiple-upload")]
        public async Task<IActionResult> CreateMultipleUploadFile([FromForm] CreateMultipleUploadFileRequestDto createMultipleUploadFileRequestDto)
        {
            await _uploadFileService.AddMultipleFilesAsync(createMultipleUploadFileRequestDto);
            return Ok("Dosya başarıyla eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUploadFile(Guid id)
        {
            await _uploadFileService.DeleteFileAsync(id, "mssql");
            return Ok("Dosya başarıyla silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUploadFile(UpdateUploadFileDto updateUploadFileDto)
        {
            await _uploadFileService.UpdateFileAsync(updateUploadFileDto);
            return Ok("Dosya başarıyla güncellendi");
        }
    }
}
