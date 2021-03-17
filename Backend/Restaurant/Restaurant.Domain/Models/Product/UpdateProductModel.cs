using Restaurant.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Domain.Models.Product
{
    public class UpdateProductModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public ProductType Type { get; set; }
        public decimal Price { get; set; }
    }
}
