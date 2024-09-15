<<<<<<< HEAD
﻿using GTSProject.Services.Entity.Concrete;

namespace GTSProject.Services.Entity.Concrete
=======
﻿namespace GTSProject.Services.Entity.Concrete
>>>>>>> DB-Infrastractures
{
    public class DailyTaskStatusLog : IEntity // Günlük talep durumlarının kayıtları içerir.
    {
        public int Id { get; set; }
<<<<<<< HEAD
        public DateTime TaskCreateDate { get; set; }
        public DateTime TaskUpdateDate { get; set; }

        #region İlişkiler
        public Guid TaskId { get; set; }
        public Task Task { get; set; }

        public Guid AssigneeId { get; set; } // User Idsi

=======
        public int AssigneeId { get; set; } // User Idsi
        public DateTime TaskCreateDate { get; set; }
        public DateTime TaskUpdateDate { get; set; }
        public int SprintId { get; set; } // Bununla ilgili class oluşturulacak

        #region İlişkiler
        public int TaskId { get; set; }
        public Task Task { get; set; }

>>>>>>> DB-Infrastractures
        public int StatusId { get; set; }
        public TaskStatus TaskStatus { get; set; }
        #endregion
    }
}
