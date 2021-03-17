using Restaurant.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Restaurant.Domain.Interfaces.Repositories
{
    public interface IProductRepository : IDisposable
	{
		Product Add(Product product);
		Product Update(Product product);
		Product GetById(Guid id);
		List<Product> Get();
		void Delete(Product product);
    }
}