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
            _dbSet = _appDbContext.Set<TEntity>();
        }

        public async Task<TEntity?> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbSet.AsQueryable();
        }

        public async Task<TEntity?> Add(TEntity entity)
        {
            var addedEntity = await _dbSet.AddAsync(entity);
            await _appDbContext.SaveChangesAsync();

            return addedEntity.Entity;
        }

        public async Task<TEntity?> Update(int? id, TEntity entity)
        {
            var employeeEntity = await _dbSet.FindAsync(id);

            if (employeeEntity != null)
            {
                _dbSet.Update(entity);
                await _appDbContext.SaveChangesAsync();

                return employeeEntity;
            }

            return null;
        }

        public async Task Delete(int id)
        {
            var employeeEntity = await _dbSet.FindAsync(id);

            if (employeeEntity == null)
            {
                return;
            }

            _dbSet.Remove(employeeEntity);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
