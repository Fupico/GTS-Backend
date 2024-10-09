using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskWatcherDtos
{
    public class ResultTaskWatcherDto : BaseDto
    {
        public int Id { get; set; }
        public int TaskId { get; set; } // Gözlemlenen görev ID'si
        public int UserId { get; set; } // Kullanıcı ID'si (gözlemcinin ID'si)
        public int WatcherId { get; set; } // Takip edenin ID'si (gözlemci)
    }
}
