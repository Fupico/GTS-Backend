﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskWatcher
{
    public class GetByIdTaskWatcherDto
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int WatcherId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}