using GTSProject.Services.UserManagement.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Models.Dtos.BaseDtos;
using UserManagementSystem.Models.Entities;

namespace UserManagementSystem.Models.DbConfig
{
    public class FupiContext : IdentityDbContext<FupiUser, IdentityRole, string>
    {
        public FupiContext(DbContextOptions<FupiContext> options) : base(options)

        {

        }
        public DbSet<UserRefreshTokenDto> UserRefreshTokens { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<UserTraining> UserTraining { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            base.OnModelCreating(builder);

            //       builder.Entity<IncomeExpense>()
            //.HasOne<Workplace>(i => i.Workplace)
            //.WithMany(w => w.IncomeExpenses)
            //.HasForeignKey(i => i.WorkplaceId)
            //.OnDelete(DeleteBehavior.Restrict);
        }
    }
}
