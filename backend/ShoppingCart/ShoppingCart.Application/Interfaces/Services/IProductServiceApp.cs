using ShoppingCart.Application.Dtos;
using ShoppingCart.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Application.Interfaces.Services
{
    public interface IProductServiceApp
    {
        Task<BaseResultDto<List<Product>>> GetAll(int offset, int limit);
        Task<BaseResultDto<Product>> GetById(int id);
        Task<BaseResultDto<Product>> GetByGuid(Guid guid);
        Task<BaseResultDto<List<Product>>> SearchByTerm(string term);
        Task<BaseResultDto<Product>> Create(Product entity);
        Task<BaseResultDto<Product>> Update(Product entity);
        Task<BaseResultDto<int>> Delete(Product entity);
    }
}
