using BetaTesters.Data;
using Microsoft.EntityFrameworkCore;

namespace BetaTesters.Infrastructure.Data.Common
{
    public class Repository : IRepository
    {
        private readonly DbContext context;
        public Repository(BetaTestersDbContext _context)
        {
            context = _context;
        }
        public IQueryable<T> All<T>() where T : class
            => DbSet<T>();

        public IQueryable<T> AllReadOnly<T>() where T : class
            => DbSet<T>().AsNoTracking();

        private DbSet<T> DbSet<T>() where T : class
            => context.Set<T>();

        public async Task AddAsync<T>(T entity) where T : class
            => await DbSet<T>().AddAsync(entity);

        public async Task<int> SaveChangesAsync()
            => await context.SaveChangesAsync();

        public async Task<T?> GetByIdAsync<T>(Guid id) where T : class
            => await DbSet<T>().FindAsync(id);

        public async Task DeleteAsync<T>(Guid id) where T : class
        {
            T? entity = await GetByIdAsync<T>(id);

            if (entity != null)
            {
                DbSet<T>().Remove(entity);
            }
        }

        public void DeleteRange<T>(IEnumerable<T> items) where T : class
        {
            DbSet<T>().RemoveRange(items);
        }
    }
}
