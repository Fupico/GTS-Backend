﻿namespace GTSProject.Services.Entity.Concrete
{
    public class TaskSmartStatus // Talep durumlarını tutar. (hangi durumdan hangi duruma gider)
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public int AvailableStatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
