using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskAutoAssignRuleDtos
{
    public class GetByIdTaskAutoAssignRuleDto
    {
        public int Id { get; set; }
        public string? RuleType { get; set; }
        public string? Key { get; set; }
        public string? Value { get; set; }
        public string? Key2 { get; set; }
        public string? Value2 { get; set; }
        public string? Key3 { get; set; }
        public string? Value3 { get; set; }
        public string? Key4 { get; set; }
        public string? Value4 { get; set; }
        public int AssigneeId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
    }
}
