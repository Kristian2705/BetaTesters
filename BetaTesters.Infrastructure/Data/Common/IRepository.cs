namespace BetaTesters.Infrastructure.Data.Common
{
    public interface IRepository
    {
        IQueryable<T> All<T>() where T : class;

        IQueryable<T> AllReadOnly<T>() where T : class;

        Task AddAsync<T>(T entity) where T : class;

        Task<int> SaveChangesAsync();

        Task<T?> GetByIdAsync<T>(Guid id) where T : class;

        Task DeleteAsync<T>(Guid id) where T : class;

        void DeleteRange<T>(IEnumerable<T> items) where T : class;
    }
}
