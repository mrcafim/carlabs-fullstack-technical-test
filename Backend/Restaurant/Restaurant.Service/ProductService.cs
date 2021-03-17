using System;
using System.Collections.Generic;
using System.Text;
using Restaurant.Domain.Entities;
using Restaurant.Domain.Interfaces.Repositories;
using Restaurant.Domain.Interfaces.Services;
using Restaurant.Domain.Models.Product;

namespace Restaurant.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public Product New(CreateProductModel product)
        {
            var productNew = new Product
            {
                Description = product.Description,
                Type = product.Type,
                Price = product.Price
            };

            return _repository.Add(productNew);
        }
        public Product Update(UpdateProductModel product)
        {
            var productItem = _repository.GetById(product.Id);

            productItem.Description = product.Description;
            productItem.Type = product.Type;
            productItem.Price = product.Price;

            return _repository.Update(productItem);
        }
        public List<Product> Get()
        {
            return _repository.Get();
        }
        public Product Get(Guid id)
        {
            return _repository.GetById(id);
        }

        public void Delete(Guid id)
        {
            var deleteProduct = _repository.GetById(id);

            _repository.Delete(deleteProduct);
        }


    }
}
