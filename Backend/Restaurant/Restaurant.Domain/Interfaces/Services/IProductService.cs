using Flunt.Notifications;
using Restaurant.Domain.Entities;
using Restaurant.Domain.Models.Product;
using System;
using System.Collections.Generic;

namespace Restaurant.Domain.Interfaces.Services
{
    public interface IProductService
    {
        Product New(CreateProductModel product);
        Product Update(UpdateProductModel product);
        List<Product> Get();
        Product Get(Guid id);
        void Delete(Guid id);
    }
}