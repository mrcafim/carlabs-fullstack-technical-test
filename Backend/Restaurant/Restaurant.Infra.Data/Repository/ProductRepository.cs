using Microsoft.EntityFrameworkCore;
using Restaurant.Domain.Entities;
using Restaurant.Domain.Interfaces.Repositories;
using Restaurant.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.Infra.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }

		public Product Add(Product product)
		{
			_context.Products.Add(product);
			_context.SaveChanges();

			return product;
		}

		public Product Update(Product product)
		{
			_context.Products.Update(product);
			_context.SaveChanges();

			return product;
		}

		public Product GetById(Guid id)
		{
			return _context
				.Products
				.FirstOrDefault(x => x.Id == id);
		}
		public List<Product> Get()
		{
			return _context.Products.ToList();
		}

		public void Delete(Product product)
		{
			_context.Products.Remove(product);
			_context.SaveChanges();
		}


		public void Dispose()
		{
			_context.Dispose();
		}

	}
}
