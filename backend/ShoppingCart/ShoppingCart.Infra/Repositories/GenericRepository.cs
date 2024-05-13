﻿using Microsoft.EntityFrameworkCore;
using ShoppingCart.Domain.Interfaces.Repositories;
using ShoppingCart.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Infra.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbSet<T>? _DB;
        private readonly MySQLContext _context;

        public GenericRepository(MySQLContext context)
        {
            _context = context;
        }

        public async Task<IQueryable<T>> GetAll(int offset, int limit)
        {
            var result = await _DB.Skip(offset)
                .Take(limit)
                .ToListAsync();

            return result.AsQueryable();
        }

        public async Task<T> Create(T entity)
        {
            _DB.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<int> Delete(T entity)
        {
            _DB.Remove(entity);
            int result = await _context.SaveChangesAsync();
            return result;
        }

        public async Task<T> Update(T entity)
        {
            _DB.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
