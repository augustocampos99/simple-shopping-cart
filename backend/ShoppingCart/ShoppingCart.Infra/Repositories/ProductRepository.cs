using Microsoft.EntityFrameworkCore;
using ShoppingCart.Domain.Entities;
using ShoppingCart.Domain.Interfaces.Repositories;
using ShoppingCart.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Infra.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly MySQLContext _context;

        public ProductRepository(MySQLContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Product?> GetByGuid(Guid guid)
        {
            var result = await _context.Products
                .Where(e => e.Guid == guid)
                .FirstOrDefaultAsync();

            return result;
        }

        public async Task<Product?> GetById(int id)
        {
            var result = await _context.Products
                .Where(e => e.Id == id)
                .FirstOrDefaultAsync();

            return result;
        }

        public async Task<List<Product>> SearchByTerm(string term)
        {
            var result = await _context.Products
                .Where(e => e.Name.ToLower().Contains(term.ToLower()) || e.Description.ToLower().Contains(term.ToLower()))
                .ToListAsync();

            return result;
        }

    }
}
