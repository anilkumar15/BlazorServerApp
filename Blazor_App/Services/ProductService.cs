using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blazor_App.Models;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace Blazor_App.Services
{
    public class ProductService : IService<Product,int>
    {
        private readonly ProductCatalogContext _context;
        public ProductService(ProductCatalogContext context)
        {
            _context = context;
        }

        public async Task<Product> CreateAsync(Product entity)
        {
            var record = await _context.Products.AddAsync(entity);
            await _context.SaveChangesAsync();
            return record.Entity;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var prd = await _context.Products.FindAsync(id);
            if (prd == null)
            {
                return false;
            }
            _context.Products.Remove(prd);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Product>> GetAsync()
        {
            var records = await _context.Products.ToListAsync();
            return records;
        }

        public async Task<Product> GetAsync(int id)
        {
            var prd = await _context.Products.FindAsync(id);
            return prd;
        }

        public async Task<Product> UpdateAsync(int id, Product entity)
        {
            var prd = await _context.Products.FindAsync(id);
            if (id != entity.ProductRowId || prd == null)
            {
                return null;
            }
            var record = _context.Update<Product>(entity);
            await _context.SaveChangesAsync();
            return record.Entity;
        }
    }
}
