using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> GetById(int id);
        Task<T> GetByGuid(Guid guid);
        Task<IQueryable<T>> GetAll();
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        void Delete(T entity);
    }
}
