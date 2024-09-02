﻿namespace GTSProject.Services.Entity.Concrete
{
    public class TaskWatcher // Talep gözlemcilerini tutar. (Takip edenler)
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int WatcherId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
