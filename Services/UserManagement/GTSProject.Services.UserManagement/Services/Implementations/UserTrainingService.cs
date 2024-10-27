using GTSProject.Services.UserManagement.Models.Dtos.UserTrainingDtos;
using GTSProject.Services.UserManagement.Models.Entities;
using GTSProject.Services.UserManagement.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Models.DbConfig;
using UserManagementSystem.Models.Dtos.BaseDtos;
using UserManagementSystem.Models.Entities;

namespace GTSProject.Services.UserManagement.Services.Implementations
{
    public class UserTrainingService : IUserTrainingService
    {
        private readonly UserManager<FupiUser> _userManager;
        private readonly UserDataDto _dataDto;
        private readonly FupiContext _context; // DbContext'inizi FupiContext olarak ayarladık

        public UserTrainingService(UserManager<FupiUser> userManager, UserDataDto dataDto, FupiContext context)
        {
            _userManager = userManager;
            _dataDto = dataDto;
            _context = context;
        }

        public async Task<ResponseDto<NoDataDto>> AddUserTraining(AddUserTrainingDto addUserTrainingDto)
        {
            var user = await _userManager.Users.Where(u => u.Id == _dataDto.UserId.ToString()).FirstOrDefaultAsync();

            if (user == null)
            {
                return new ResponseDto<NoDataDto>
                {
                    IsSuccessful = false,
                    errors = new ErrorDto("User not found.", true),
                    status = 404
                };
            }

            var training = await _context.Training.Where(u => u.Id == addUserTrainingDto.TrainingId).FirstOrDefaultAsync();

            if (training == null)
            {
                return new ResponseDto<NoDataDto>
                {
                    IsSuccessful = false,
                    errors = new ErrorDto("Training not found.", true),
                    status = 404
                };
            }

            // Kullanıcının daha önce bu eğitimi alıp almadığını kontrol et
            var existingUserTraining = await _context.UserTraining
                .FirstOrDefaultAsync(ut => ut.UserId == user.Id && ut.TrainingId == addUserTrainingDto.TrainingId);

            if (existingUserTraining != null)
            {
                return new ResponseDto<NoDataDto>
                {
                    IsSuccessful = false,
                    errors = new ErrorDto("User has already attended this training.", true),
                    status = 404 // Bad Request
                };
            }

            var userTraining = new UserTraining
            {
                User = user,
                UserId = user.Id,
                Training = training,
                TrainingId = addUserTrainingDto.TrainingId,
                Attended = true // Kullanıcı eğitime katıldı olarak ayarlıyoruz
            };

            await _context.UserTraining.AddAsync(userTraining);
            await _context.SaveChangesAsync();

            return new ResponseDto<NoDataDto>
            {
                Data = new NoDataDto { Message = "User training added successfully." },
                status = 200,
                IsSuccessful = true
            };
        }

        public async Task<ResponseDto<NoDataDto>> UpdateUserTraining(UpdateUserTrainingDto updateUserTrainingDto)
        {
            var user = await _userManager.Users.Where(u => u.Id == _dataDto.UserId.ToString()).FirstOrDefaultAsync();

            if (user == null)
            {
                return new ResponseDto<NoDataDto>
                {
                    IsSuccessful = false,
                    errors = new ErrorDto("User not found.", true),
                    status = 404
                };
            }

            var training = await _context.Training.Where(u => u.Id == updateUserTrainingDto.TrainingId).FirstOrDefaultAsync();

            if (training == null)
            {
                return new ResponseDto<NoDataDto>
                {
                    IsSuccessful = false,
                    errors = new ErrorDto("Training not found.", true),
                    status = 404
                };
            }

            var userTraining = await _context.UserTraining
                .FirstOrDefaultAsync(ut => ut.UserId == user.Id && ut.TrainingId == updateUserTrainingDto.TrainingId);

            if (userTraining == null)
            {
                return new ResponseDto<NoDataDto>
                {
                    IsSuccessful = false,
                    errors = new ErrorDto("User training not found.", true),
                    status = 404
                };
            }

            userTraining.Attended = updateUserTrainingDto.Attended;

            _context.UserTraining.Update(userTraining);
            await _context.SaveChangesAsync();

            return new ResponseDto<NoDataDto>
            {
                Data = new NoDataDto { Message = "User training updated successfully." },
                status = 200,
                IsSuccessful = true
            };
        }

        public async Task<ResponseDto<List<GetUserTrainingDto>>> GetUserAttendedTrainings()
        {
            var user = await _userManager.Users.Where(u => u.Id == _dataDto.UserId.ToString()).FirstOrDefaultAsync();
            if (user == null)
            {
                return new ResponseDto<List<GetUserTrainingDto>>
                {
                    IsSuccessful = false,
                    errors = new ErrorDto("User not found.", true),
                    status = 404
                };
            }

            var attendedTrainings = await _context.UserTraining
                .Where(ut => ut.UserId == user.Id && ut.Attended)
                .Include(ut => ut.Training)
                .Select(ut => new GetUserTrainingDto
                {
                    Id = ut.Id,
                    TrainingId = ut.TrainingId,
                    TrainingName = ut.Training.Name,
                    TrainingDescription = ut.Training.Description,
                    TrainingStartDate = ut.Training.StartDate,
                    TrainingEndDate = ut.Training.EndDate,
                    Attended = ut.Attended
                })
                .ToListAsync();

            return new ResponseDto<List<GetUserTrainingDto>>
            {
                Data = attendedTrainings,
                status = 200,
                IsSuccessful = true
            };
        }

        public async Task<ResponseDto<List<GetUserTrainingDto>>> GetUserNotAttendedTrainings()
        {
            var user = await _userManager.Users.Where(u => u.Id == _dataDto.UserId.ToString()).FirstOrDefaultAsync();
            if (user == null)
            {
                return new ResponseDto<List<GetUserTrainingDto>>
                {
                    IsSuccessful = false,
                    errors = new ErrorDto("User not found.", true),
                    status = 404
                };
            }

            var notAttendedTrainings = await _context.UserTraining
                .Where(ut => ut.UserId == user.Id && !ut.Attended)
                .Include(ut => ut.Training)
                .Select(ut => new GetUserTrainingDto
                {
                    Id = ut.Id,
                    TrainingId = ut.TrainingId,
                    TrainingName = ut.Training.Name,
                    TrainingDescription = ut.Training.Description,
                    TrainingStartDate = ut.Training.StartDate,
                    TrainingEndDate = ut.Training.EndDate,
                    Attended = ut.Attended
                })
                .ToListAsync();

            return new ResponseDto<List<GetUserTrainingDto>>
            {
                Data = notAttendedTrainings,
                status = 200,
                IsSuccessful = true
            };
        }

        public async Task<ResponseDto<List<GetUserTrainingDto>>> GetUserRecommendedTrainings()
        {
            var user = await _userManager.Users.Where(u => u.Id == _dataDto.UserId.ToString()).FirstOrDefaultAsync();
            if (user == null)
            {
                return new ResponseDto<List<GetUserTrainingDto>>
                {
                    IsSuccessful = false,
                    errors = new ErrorDto("User not found.", true),
                    status = 404
                };
            }

            // Kullanıcının katılmadığı ve hiç almadığı eğitimleri sorguluyoruz
            var recommendedTrainings = await _context.Training
                .Where(t => !_context.UserTraining.Any(ut => ut.UserId == user.Id && ut.TrainingId == t.Id))
                .Select(t => new GetUserTrainingDto
                {
                    TrainingId = t.Id,
                    TrainingName = t.Name,
                    TrainingDescription = t.Description,
                    TrainingStartDate = t.StartDate,
                    TrainingEndDate = t.EndDate,
                    Attended = false // Kullanıcı bu eğitimi hiç almadı
                })
                .ToListAsync();

            return new ResponseDto<List<GetUserTrainingDto>>
            {
                Data = recommendedTrainings,
                status = 200,
                IsSuccessful = true
            };
        }

        public async Task<ResponseDto<GetUserTrainingDto>> GetRandomNotAttendedTraining()
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == _dataDto.UserId.ToString());
            if (user == null)
            {
                return new ResponseDto<GetUserTrainingDto>
                {
                    IsSuccessful = false,
                    errors = new ErrorDto("User not found.", true),
                    status = 404
                };
            }

            var notAttendedTrainings = await _context.Training
                .Where(t => !_context.UserTraining.Any(ut => ut.UserId == user.Id && ut.TrainingId == t.Id))
                .ToListAsync();

            if (!notAttendedTrainings.Any())
            {
                return new ResponseDto<GetUserTrainingDto>
                {
                    IsSuccessful = false,
                    errors = new ErrorDto("No available trainings for recommendation.", true),
                    status = 404
                };
            }

            var randomTraining = notAttendedTrainings.OrderBy(x => Guid.NewGuid()).FirstOrDefault();

            var resultDto = new GetUserTrainingDto
            {
                TrainingId = randomTraining.Id,
                TrainingName = randomTraining.Name,
                TrainingDescription = randomTraining.Description,
                TrainingStartDate = randomTraining.StartDate,
                TrainingEndDate = randomTraining.EndDate,
                Attended = false // Kullanıcı katılmadığı için false
            };

            return new ResponseDto<GetUserTrainingDto>
            {
                Data = resultDto,
                status = 200,
                IsSuccessful = true
            };
        }


    }
}
