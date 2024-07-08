using Microsoft.EntityFrameworkCore;
using System;
using UserManagementSystem.Models.DbConfig;
using UserManagementSystem.Services.Interfaces;

namespace UserManagementSystem.Services.Implementations
{
    public class UnitOfWorkService : IUnitOfWorkService
    {
        private readonly DbContext _context;

        public UnitOfWorkService(FupiContext appDbContext)
        {
            _context = appDbContext;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
