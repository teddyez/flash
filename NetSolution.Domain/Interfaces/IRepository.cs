using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetSolution.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task AddAsync(T entity);
        Task<T?> GetByIdAsync(Guid id);
        Task<IEnumerable<T>> GetAllAsync();
        // Add more generic methods as needed
    }
}