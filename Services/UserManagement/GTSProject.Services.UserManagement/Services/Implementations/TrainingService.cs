using GTSProject.Services.UserManagement.Models.Dtos.TrainingDtos;
using GTSProject.Services.UserManagement.Models.Entities;
using GTSProject.Services.UserManagement.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Models.DbConfig;
using UserManagementSystem.Models.Dtos.BaseDtos;

namespace GTSProject.Services.UserManagement.Services.Implementations
{
    public class TrainingService : ITrainingService
    {
        private readonly FupiContext _context;
        public TrainingService(FupiContext context)
        {
            _context = context;
        }

        // Eğitimleri Listeleme
        public async Task<ResponseDto<List<GetTrainingDto>>> GetTraining()
        {
            var trainings = await _context.Training
                .Select(training => new GetTrainingDto
                {
                    Id = training.Id,
                    Name = training.Name,
                    Description = training.Description,
                    Duration = training.Duration,
                    StartDate = training.StartDate,
                    EndDate = training.EndDate,
                    Location = training.Location,
                    CreatedDate = training.CreatedDate,
                    UpdatedDate = training.UpdatedDate,
                    Statu = training.EndDate > DateTime.Now // Eğitim durumu
                }).ToListAsync();

            return new ResponseDto<List<GetTrainingDto>>
            {
                Data = trainings,
                IsSuccessful = true
            };
        }

        // Eğitim Ekleme
        public async Task<ResponseDto<NoDataDto>> InsertTraining(InsertTrainingDto insertTrainingDto)
        {
            var training = new Training
            {
                Id = Guid.NewGuid().ToString(),
                Name = insertTrainingDto.Name,
                Description = insertTrainingDto.Description,
                Duration = insertTrainingDto.Duration,
                StartDate = insertTrainingDto.StartDate,
                EndDate = insertTrainingDto.EndDate,
                Location = insertTrainingDto.Location,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };

            await _context.Training.AddAsync(training);
            await _context.SaveChangesAsync();

            return new ResponseDto<NoDataDto>
            {
                IsSuccessful = true,
                status = 200
                //Message = "Training inserted successfully"
            };
        }

        // Eğitim Güncelleme
        public async Task<ResponseDto<NoDataDto>> UpdateTraining(UpdateTrainingDto updateTrainingDto)
        {
            var training = await _context.Training.FindAsync(updateTrainingDto.Id);

            if (training == null)
            {
                return new ResponseDto<NoDataDto>
                {
                    IsSuccessful = false,
                    status = 404,
                    errors = new ErrorDto("Training not found.", true)
                };
            }

            // Sadece null olmayan değerleri güncelle
            if (!string.IsNullOrEmpty(updateTrainingDto.Name))
                training.Name = updateTrainingDto.Name;

            if (!string.IsNullOrEmpty(updateTrainingDto.Description))
                training.Description = updateTrainingDto.Description;

            if (updateTrainingDto.Duration.HasValue)
                training.Duration = updateTrainingDto.Duration.Value;

            if (updateTrainingDto.StartDate.HasValue)
                training.StartDate = updateTrainingDto.StartDate.Value;

            if (updateTrainingDto.EndDate.HasValue)
                training.EndDate = updateTrainingDto.EndDate.Value;

            if (!string.IsNullOrEmpty(updateTrainingDto.Location))
                training.Location = updateTrainingDto.Location;

            if (updateTrainingDto.Statu.HasValue)
                training.Statu = updateTrainingDto.Statu.Value;

            // Güncelleme tarihini ayarla
            training.UpdatedDate = DateTime.Now;

            _context.Training.Update(training);
            await _context.SaveChangesAsync();

            return new ResponseDto<NoDataDto>
            {
                IsSuccessful = true,
                status = 200
            };
        }
        // Eğitim Pasif Duruma Getirme ve Güncelleme Tarihini Ayarlama
        public async Task<ResponseDto<NoDataDto>> DeleteTraining(DeleteTrainingDto deleteTrainingDto)
        {
            // Gelen ID'ye göre eğitim kaydını bul
            var training = await _context.Training.FindAsync(deleteTrainingDto.Id);

            if (training == null)
            {
                return new ResponseDto<NoDataDto>
                {
                    IsSuccessful = false,
                    errors = new ErrorDto("Training not found.", true),
                    status = 404
                };
            }

            // Eğitimin durumunu pasif hale getir ve güncelleme tarihini ayarla
            training.Statu = false;
            training.UpdatedDate = DateTime.UtcNow;

            // Değişiklikleri kaydet
            _context.Training.Update(training);
            await _context.SaveChangesAsync();

            return new ResponseDto<NoDataDto>
            {
                IsSuccessful = true,
                status = 200
                //Message = "Training status updated to inactive successfully"
            };
        }
        // Idsi Verilen Eğimi Getirme
        public async Task<ResponseDto<GetTrainingDto>> GetTrainingById(string id)
        {
            var training = await _context.Training.FindAsync(id);

            if (training == null)
            {
                return new ResponseDto<GetTrainingDto>
                {
                    IsSuccessful = false,
                    status = 404,
                    errors = new ErrorDto("Training not found.", true)
                };
            }

            var trainingDto = new GetTrainingDto
            {
                Id = training.Id,
                Name = training.Name,
                Description = training.Description,
                Duration = training.Duration,
                StartDate = training.StartDate,
                EndDate = training.EndDate,
                Location = training.Location,
                CreatedDate = training.CreatedDate,
                UpdatedDate = training.UpdatedDate,
                Statu = training.Statu
            };

            return new ResponseDto<GetTrainingDto>
            {
                IsSuccessful = true,
                Data = trainingDto,
                status = 200
            };
        }

    }
}