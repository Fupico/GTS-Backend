namespace UserManagementSystem.Services.Interfaces
{
    public interface IUnitOfWorkService
    {
        Task CommitAsync();

        void Commit();
    }
}
