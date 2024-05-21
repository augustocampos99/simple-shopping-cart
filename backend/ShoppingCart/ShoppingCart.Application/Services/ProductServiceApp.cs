using ShoppingCart.Application.Dtos;
using ShoppingCart.Application.Interfaces.Services;
using ShoppingCart.Domain.Entities;
using ShoppingCart.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Application.Services
{
    public class ProductServiceApp : IProductServiceApp
    {
        private readonly IProductService _productService;
        public ProductServiceApp(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<BaseResultDto<List<Product>>> GetAll(int offset, int limit)
        {
            try
            {
                var products = await _productService.GetAll(offset, limit);

                var resultBase = new BaseResultDto<List<Product>>()
                {
                    Success = true,
                    Result = products.ToList()
                };

                return resultBase;
            }
            catch (Exception ex)
            {
                return new BaseResultDto<List<Product>>()
                {
                    Success = false,
                    Result = null,
                    Message = ex.Message
                };
            }
        }

        public async Task<BaseResultDto<Product>> GetByGuid(Guid guid)
        {
            try
            {
                var product = await _productService.GetByGuid(guid);

                var resultBase = new BaseResultDto<Product>()
                {
                    Success = true,
                    Result = product
                };

                return resultBase;
            }
            catch (Exception ex)
            {
                return new BaseResultDto<Product>()
                {
                    Success = false,
                    Result = null,
                    Message = ex.Message
                };
            }
        }

        public async Task<BaseResultDto<Product>> GetById(int id)
        {
            try
            {
                var product = await _productService.GetById(id);

                var resultBase = new BaseResultDto<Product>()
                {
                    Success = true,
                    Result = product
                };

                return resultBase;
            }
            catch (Exception ex)
            {
                return new BaseResultDto<Product>()
                {
                    Success = false,
                    Result = null,
                    Message = ex.Message
                };
            }
        }

        public async Task<BaseResultDto<List<Product>>> SearchByTerm(string term)
        {
            try
            {
                var products = await _productService.SearchByTerm(term);

                var resultBase = new BaseResultDto<List<Product>>()
                {
                    Success = true,
                    Result = products.ToList()
                };

                return resultBase;
            }
            catch (Exception ex)
            {
                return new BaseResultDto<List<Product>>()
                {
                    Success = false,
                    Result = null,
                    Message = ex.Message
                };
            }
        }

        public async Task<BaseResultDto<Product>> Update(Product entity)
        {
            try
            {
                var product = await _productService.Update(entity);

                var resultBase = new BaseResultDto<Product>()
                {
                    Success = true,
                    Result = product
                };

                return resultBase;
            }
            catch (Exception ex)
            {
                return new BaseResultDto<Product>()
                {
                    Success = false,
                    Result = null,
                    Message = ex.Message
                };
            }
        }

        public async Task<BaseResultDto<Product>> Create(Product entity)
        {
            try
            {
                var product = await _productService.Create(entity);

                var resultBase = new BaseResultDto<Product>()
                {
                    Success = true,
                    Result = product
                };

                return resultBase;
            }
            catch (Exception ex)
            {
                return new BaseResultDto<Product>()
                {
                    Success = false,
                    Result = null,
                    Message = ex.Message
                };
            }
        }

        public async Task<BaseResultDto<int>> Delete(Product entity)
        {
            try
            {
                var count = await _productService.Delete(entity);

                var resultBase = new BaseResultDto<int>()
                {
                    Success = true,
                    Result = count
                };

                return resultBase;
            }
            catch (Exception ex)
            {
                return new BaseResultDto<int>()
                {
                    Success = false,
                    Result = 0,
                    Message = ex.Message
                };
            }
        }
    }
}
