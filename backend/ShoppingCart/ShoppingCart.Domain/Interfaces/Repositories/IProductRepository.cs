using ShoppingCart.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Domain.Interfaces.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<Product?> GetById(int id);
        Task<Product?> GetByGuid(Guid guid);
        Task<List<Product>> SearchByTerm(string term);
    }
}
