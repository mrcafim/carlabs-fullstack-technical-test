using Restaurant.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Domain.Entities
{
    public class Product : Entity
    {
        public string Description { get; set; }
        public ProductType Type { get; set; }
        public decimal Price { get; set; }
        public Guid MenuId { get; set; }

        public Product()
        { }

        public Product(string description, ProductType type, decimal price, Guid menuId)
        {
            Description = description;
            Type = type;
            Price = price;
            MenuId = menuId;
        }
    }
}
