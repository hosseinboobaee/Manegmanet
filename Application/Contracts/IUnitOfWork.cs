using Domain.entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts
{
    public interface IUnitOfWork
    {
        DbContext context { get; }
        Task<int> Save();
        IGenericRepository<T> Repository<T>() where T : BaseEntity;
    }
}
