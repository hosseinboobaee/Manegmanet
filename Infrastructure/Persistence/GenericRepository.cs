using Application.Contracts;
using Domain.entity;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly DataContext _dataContext;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
            _dbSet = _dataContext.Set<T>();
        }
        public async Task<T> AddAsync(T entity)
        {
            _dbSet.AddAsync(entity);
            return await Task.FromResult(entity);
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<T> UpdateAsync(T entity)
        {
            _dataContext.Entry(entity).State = EntityState.Modified;
            return Task.FromResult(entity);
        }
        public async Task<bool> ExistsAsync(long id) => await _dbSet.AnyAsync(e => e.Id == id);
        public IQueryable<T> Query() => _dbSet.AsQueryable();
    }
}
