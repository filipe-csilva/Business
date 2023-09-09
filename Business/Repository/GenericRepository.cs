using Business.Data;
using Business.Models;
using Business.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Business.Repository
{
    public abstract class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public readonly SystemContext _dbContext;

        public GenericRepository(SystemContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            _dbContext.Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Delete(params object[] keys)
        {
            TEntity entity = await GetById(keys);
            _dbContext.Remove(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<ICollection<TEntity>> GetAll()
        {
            return await _dbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(params object[] keys)
        {
            return await _dbContext.FindAsync<TEntity>(keys) ?? throw new NotImplementedException();
        }

        public async Task<TEntity?> SearchById(params object[] keys)
        {
            return await _dbContext.FindAsync<TEntity>(keys);
        }

        public async Task<TEntity> Update(TEntity entity, params object[] keys)
        {
            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
