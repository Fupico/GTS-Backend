﻿namespace GTSProject.Services.Entity.Concrete
{
    public class TaskRating // Talep değerlendirmelerini tutar.
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public int AssigneeId { get; set; }
        public int CategoryId { get; set; }
    }
}