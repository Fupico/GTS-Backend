﻿namespace GTSProject.Services.Entity.Concrete
{
    public class TaskRating // Talep değerlendirmelerini tutar.
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public string Note { get; set; }

        #region İlişkiler
        public Guid TaskId { get; set; }
        public Task Task { get; set; }

        public Guid UserId { get; set; } // User servisten gelecek
        public int AssigneeId { get; set; } // User servisten gelecek

        public int CategoryId { get; set; }
        public TaskCategory TaskCategory { get; set; }
        #endregion
    }
}
