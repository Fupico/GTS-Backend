using GTSProject.Services.Core.Entities;
using GTSProject.Services.Core.Utilities.Results;

namespace GTSProject.Services.Core.Business.Abstract
{
    public interface IService<TEntity, TCreateDto, TUpdateDto, TGetByIdDto, TResultDto>
        where TEntity : class, IEntity, new()
    {
        Task<IResult> AddAsync(TCreateDto createDto);
        Task<IResult> UpdateAsync(TUpdateDto updateDto);
        Task<IResult> DeleteAsync(int id);
        Task<IDataResult<TGetByIdDto>> GetByIdAsync(int id);
        Task<IDataResult<List<TResultDto>>> GetAllAsync();
    }
}
