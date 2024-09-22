﻿namespace GTSProject.Services.Entity.Concrete
{
    public class TaskAutoAssignRules // Otomatik talep atama kurallarını tutar.
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
        public bool IsActive { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}