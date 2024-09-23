﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskStatus
{
    public class CreateTaskStatusDto
    {
        public int KanbanStatusId { get; set; }
        public string Tag { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Order { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}