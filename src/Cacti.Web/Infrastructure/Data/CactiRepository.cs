using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cacti.Web.Core.Entities;
using Cacti.Web.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Cacti.Web.Infrastructure.Data
{
    public abstract class CactiRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly DbSet<T> _dbSet;
        protected readonly CactiDbContext _dbContext;

        protected CactiRepository(CactiDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public T Add(T entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _dbContext.SaveChanges();
        }

        public T GetById(int id)
        {
            return _dbSet.FirstOrDefault(i => i.Id == id);
        }

        public List<T> List()
        {
            return _dbSet.ToList();
        }

        public async Task<List<T>> ListAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}