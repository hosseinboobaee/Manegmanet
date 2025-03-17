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
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        public UnitOfWork(DataContext context)
        {
                _context = context;
        }
        public DbContext context => _context;

        public IGenericRepository<T> Repository<T>() where T : BaseEntity
        {
           return new GenericRepository<T>(_context);
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
