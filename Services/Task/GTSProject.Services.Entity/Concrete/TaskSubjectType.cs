﻿namespace GTSProject.Services.Entity.Concrete
{
    public class TaskSubjectType // Talep konu türlerini tutar.(Müşteri ilişkileri departmanı)
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SlaGroup { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
