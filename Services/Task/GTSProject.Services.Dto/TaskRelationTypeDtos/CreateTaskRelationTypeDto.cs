﻿using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskRelationTypeDtos
{
    public class CreateTaskRelationTypeDto : BaseDto
    {
        public string Name { get; set; }  // İlişki türünün adı
    }
}