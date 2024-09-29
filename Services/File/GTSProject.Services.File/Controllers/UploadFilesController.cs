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

        [HttpPost("get-all-upload-file-mssql")]
        public async Task<IActionResult> GetMssqlUploadFileList()
        {
            var values = await _uploadFileService.GetAllFilesMssqlAsync();
            return Ok(values);
        }
        [HttpPost("get-all-upload-file-mongo")]
        public async Task<IActionResult> GetMongoUploadFileList()
        {
            var values = await _uploadFileService.GetAllFilesMongoAsync();
            return Ok(values);
        }

        [HttpPost("get-by-id-upload-file")]
        public async Task<IActionResult> GetUploadFileById(ResultGetByIdUploadFileRequestDto resultGetByIdUploadFileRequestDto)
        {
            var values = await _uploadFileService.GetFileByIdAsync(resultGetByIdUploadFileRequestDto);
            return Ok(values);
        }

        [HttpPost("add-upload-file")]
        public async Task<IActionResult> CreateUploadFile([FromForm] CreateUploadFileRequestDto createUploadFileRequestDto)
        {
            await _uploadFileService.AddFileAsync(createUploadFileRequestDto);
            return Ok("Dosya başarıyla eklendi");
        }
        [HttpPost("add-multiple-upload")]
        public async Task<IActionResult> CreateMultipleUploadFile([FromForm] CreateMultipleUploadFileRequestDto createMultipleUploadFileRequestDto)
        {
            await _uploadFileService.AddMultipleFilesAsync(createMultipleUploadFileRequestDto);
            return Ok("Dosya başarıyla eklendi");
        }

        [HttpDelete("delete-upload-file")]
        public async Task<IActionResult> DeleteUploadFile(DeleteUploadFileRequestDto deleteUploadFileRequestDto)
        {
            await _uploadFileService.DeleteFileAsync(deleteUploadFileRequestDto);
            return Ok("Dosya başarıyla silindi");
        }

        //[HttpPut("update-upload-file")]
        //public async Task<IActionResult> UpdateUploadFile(UpdateUploadFileDto updateUploadFileDto)
        //{
        //    await _uploadFileService.UpdateFileAsync(updateUploadFileDto);
        //    return Ok("Dosya başarıyla güncellendi");
        //}
    }
}
