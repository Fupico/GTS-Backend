using GTSProject.Services.File.Entities;
using Microsoft.EntityFrameworkCore;

namespace GTSProject.Services.File.DbSettings.Concrete
{
    public class MssqlDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public MssqlDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<UploadFile> UploadFiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // appsettings.json dosyasından bağlantı dizesini al
            var connectionString = _configuration.GetConnectionString("MSSQL");
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UploadFile>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
        }
    }
}
