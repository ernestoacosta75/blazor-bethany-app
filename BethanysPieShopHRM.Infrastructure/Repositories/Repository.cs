using BethanysPieShopHTM.Core.DomainServices.DatabaseContext;
using BethanysPieShopHTM.Core.DomainServices.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShopHRM.Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly AppDbContext _appDbContext;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(IDbContextFactory<AppDbContext> dbContextFactory)
        {
            _appDbContext = dbContextFactory.CreateDbContext();
        }

        public async Task<TEntity?> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbSet.AsQueryable();
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            if (_appDbContext.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }

            _dbSet.Remove(entity);
        }
    }
}
