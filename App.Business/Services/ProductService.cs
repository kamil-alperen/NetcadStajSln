using App.Data.Context;
using App.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Business.Services
{
    public class ProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Product>> GetProductList()
        {
            var list = await _context.Products.ToListAsync();
            return list;
        }

        public async Task<Product> AddProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product> SaveProduct(Product request)
        {
            var product = await _context.Products.FindAsync(request.Id);
            if (product == null)
            {
                return null;
            }

            product.Model = request.Model;
            product.Memory = request.Memory;
            product.Cpu = request.Cpu;
            product.Price = request.Price;
            product.Description = request.Description;
            product.Image = request.Image;

            await _context.SaveChangesAsync();

            return request;
        }

        public async Task<List<Product>> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return null;
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            var list = await _context.Products.ToListAsync();
            return list;
        }
    }
}
