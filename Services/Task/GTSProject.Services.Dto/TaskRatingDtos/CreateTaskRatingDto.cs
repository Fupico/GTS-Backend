﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskRatingDtos
{
    public class CreateTaskRatingDto
    {
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public int AssigneeId { get; set; }
        public int CategoryId { get; set; }
    }
}