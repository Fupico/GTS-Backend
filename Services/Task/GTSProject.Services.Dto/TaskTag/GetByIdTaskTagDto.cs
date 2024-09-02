using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskTag
{
    public class GetByIdTaskTagDto
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int ApplicationType { get; set; }
        public string Name { get; set; }
        public string ReporterName { get; set; }
        public string ReporterType { get; set; }
        public string? TCKN { get; set; }
        public string? VKN { get; set; }
        public string? YKN { get; set; }
        public string? PassaportNumber { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? CellPhone { get; set; }
        public string? Product { get; set; }
        public int AgencyRegionId { get; set; }
        public string? PolicyNumber { get; set; }
        public string? OfferNumber { get; set; }
        public string? DamageNumber { get; set; }
        public string? Plate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime TanzimDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string IptKayit { get; set; }
    }
}
