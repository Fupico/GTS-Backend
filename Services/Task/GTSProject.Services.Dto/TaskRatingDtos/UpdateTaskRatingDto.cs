using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskRatingDtos
{
    public class UpdateTaskRatingDto : BaseDto
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public string Note { get; set; }

        // İlişkili alanlar
        public int TaskId { get; set; }
        public int UserId { get; set; }  // User Id
        public int AssigneeId { get; set; }  // Assignee User Id
        public int CategoryId { get; set; }  // Task Category Id
    }
}
