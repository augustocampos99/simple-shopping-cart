using ShoppingCart.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Domain.Interfaces.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAll(int offset, int limit);
        Task<Product?> GetById(int id);
        Task<Product?> GetByGuid(Guid guid);
        Task<List<Product>> SearchByTerm(string term);
        Task<Product> Create(Product entity);
        Task<Product> Update(Product entity);
        Task<int> Delete(Product entity);
    }
}
