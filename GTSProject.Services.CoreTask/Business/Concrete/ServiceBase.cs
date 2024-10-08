using AutoMapper;
using GTSProject.Services.Core.Business.Abstract;
using GTSProject.Services.Core.Business.Constants;
using GTSProject.Services.Core.Entities;
using GTSProject.Services.Core.UnitOfWork;
using GTSProject.Services.Core.Utilities.Results;
using Microsoft.EntityFrameworkCore;

namespace GTSProject.Services.Core.Business.Concrete
{
    public class ServiceBase<TEntity, TCreateDto, TUpdateDto, TGetByIdDto, TResultDto, TContext>
    where TEntity : class, IEntity, new()
    where TContext : DbContext, new()
    {
        private readonly IUnitOfWork<TContext> _unitOfWork;
        private readonly IMapper _mapper;

        public ServiceBase(IUnitOfWork<TContext> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IResult> AddAsync(TCreateDto createDto)
        {
            var entity = _mapper.Map<TEntity>(createDto);
            await _unitOfWork.GetRepository<TEntity>().AddAsync(entity);
            await _unitOfWork.CompleteAsync();
            return new SuccessResult(Messages<TEntity>.EntityAdded);
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            var entity = await _unitOfWork.GetRepository<TEntity>().GetAsync(x => x.Id == id);
            if (entity == null)
            {
                return new ErrorResult(Messages<TEntity>.EntityNotFound);
            }

            await _unitOfWork.GetRepository<TEntity>().DeleteAsync(entity);
            await _unitOfWork.CompleteAsync();

            return new SuccessResult(Messages<TEntity>.EntityDeleted);
        }

        public async Task<IResult> UpdateAsync(TUpdateDto updateDto)
        {
            var entity = await _unitOfWork.GetRepository<TEntity>().GetAsync(x => x.Id == (int)typeof(TUpdateDto).GetProperty("Id").GetValue(updateDto));

            if (entity == null)
            {
                return new ErrorResult(Messages<TEntity>.EntityNotFound);
            }

            _mapper.Map(updateDto, entity);
            await _unitOfWork.GetRepository<TEntity>().UpdateAsync(entity);
            await _unitOfWork.CompleteAsync();

            return new SuccessResult(Messages<TEntity>.EntityUpdated);
        }

        public async Task<IDataResult<TGetByIdDto>> GetByIdAsync(int id)
        {
            var entity = await _unitOfWork.GetRepository<TEntity>().GetAsync(x => x.Id == id);

            if (entity == null)
            {
                return new ErrorDataResult<TGetByIdDto>(Messages<TEntity>.EntityNotFound);
            }

            var resultDto = _mapper.Map<TGetByIdDto>(entity);

            return new SuccessDataResult<TGetByIdDto>(resultDto, Messages<TEntity>.EntityIdListed);
        }

        public async Task<IDataResult<List<TResultDto>>> GetAllAsync()
        {
            var entities = await _unitOfWork.GetRepository<TEntity>().GetAllAsync();
            var resultDtos = _mapper.Map<List<TResultDto>>(entities);

            return new SuccessDataResult<List<TResultDto>>(resultDtos, Messages<TEntity>.EntityListed);
        }
    }
}
