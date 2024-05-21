using ShoppingCart.Domain.Entities;
using ShoppingCart.Domain.Interfaces.Repositories;
using ShoppingCart.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Product>> GetAll(int offset, int limit)
        {
            try
            {
                var result = await _productRepository.GetAll(offset, limit);
                return result.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Product?> GetByGuid(Guid guid)
        {
            try
            {
                var result = await _productRepository.GetByGuid(guid);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Product?> GetById(int id)
        {
            try
            {
                var result = await _productRepository.GetById(id);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Product>> SearchByTerm(string term)
        {
            try
            {
                var result = await _productRepository.SearchByTerm(term);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Product> Update(Product entity)
        {
            try
            {
                var result = await _productRepository.Update(entity);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Product> Create(Product entity)
        {
            try
            {
                var result = await _productRepository.Create(entity);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<int> Delete(Product entity)
        {
            try
            {
                var result = await _productRepository.Delete(entity);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
