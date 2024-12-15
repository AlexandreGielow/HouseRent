using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TheCoffee.src.Infrastructure.Data;
using TheCoffee.src.Domain.Model.Products;
using TheCoffee.src.User_Interface.Contracts.Requests;

namespace TheCoffee.src.Infrastructure.Repositories
{
    public class ProductRepository : Controller, IProductRepository
    {
        private readonly TheCoffeeContext _context;
        public ProductRepository(TheCoffeeContext context)
        {
            _context = context;
        }
        public ICollection<Product> GetProducts()
        {
            return [.. _context.Products.Where(p => p.Status == ProductStatus.Active)];
        }
        public ICollection<Product> GetFilteredProducts(GetProductQuery filter)
        {
            return  _context.Products
                .Where(p => p.Status == ProductStatus.Active && p.Name.Contains(filter.Name))
                .ToList();
        }
        public ICollection<Product> GetProductsAndCharacteristics(GetProductQuery filter)
        {
            return _context.Products
                .Where(p => p.Status == ProductStatus.Active)
                .Include(a => a.Characteristics)
                .ToList();
        }
        public ICollection<Characteristic> GetProductsCharacteristics()
        {
            return _context.Characteristics
                .ToList();
        }
        public Product GetProduct(int id)
        {
            var Property =  _context.Products.First();
            if (Property == null)
            {
                return null;
            }
            return Property;
        }
        public Product AddProduct(Product Product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(Product);
                _context.SaveChanges();
            }
            var result = _context.Products.ToList().Last();
            return result;
        }
        public Product UpdateProduct(Product Product)
        {
            var result = _context.Products.Where(p => p.Id == Product.Id)
                .ToList().Last();
            if (result == null)
            {
                return null;
            }
            _context.Update(Product);
            _context.SaveChanges();
            result = _context.Products.ToList().Last();
            return result;
        }

    }
}
