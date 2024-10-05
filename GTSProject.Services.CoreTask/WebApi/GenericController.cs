using Microsoft.AspNetCore.Mvc;
using GTSProject.Services.Core.Business.Abstract;
using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Core.WebApi
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenericController<TEntity, TCreateDto, TUpdateDto, TGetByIdDto, TResultDto> : CustomBaseController where TEntity : class, IEntity, new()
    {
        private readonly IService<TEntity, TCreateDto, TUpdateDto, TGetByIdDto, TResultDto> _service;

        public GenericController(IService<TEntity, TCreateDto, TUpdateDto, TGetByIdDto, TResultDto> service)
        {
            _service = service;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync();
            return CreateActionResult(result);
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            return CreateActionResult(result);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] TCreateDto createDto)
        {
            var result = await _service.AddAsync(createDto);
            return CreateActionResult(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] TUpdateDto updateDto)
        {
            var result = await _service.UpdateAsync(updateDto);
            return CreateActionResult(result);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _service.DeleteAsync(id);
            return CreateActionResult(result);
        }
    }
}