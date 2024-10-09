using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskProjectDtos
{
    public class ResultTaskProjectDto : BaseDto
    {
        public int Id { get; set; }
        // Proje bilgileri
        public string Name { get; set; }  // Proje ismi
        public string Description { get; set; }  // Proje açıklaması
        public string Color { get; set; }  // Proje rengi
        public bool ShowToAllUser { get; set; }  // Proje herkes tarafından görülebilir mi?

        // İlişkiler
        public Guid OwnerId { get; set; }  // Proje sahibi (User Id)
    }
}
