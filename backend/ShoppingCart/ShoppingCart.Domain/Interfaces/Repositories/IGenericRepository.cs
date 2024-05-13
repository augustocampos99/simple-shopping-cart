using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Domain.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IQueryable<T>> GetAll(int offset, int limit);
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task<int> Delete(T entity);
    }
}
