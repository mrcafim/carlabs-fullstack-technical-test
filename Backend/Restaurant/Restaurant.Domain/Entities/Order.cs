using Restaurant.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Domain.Entities
{
    public class Order : Entity
    {
        public int TableNumber { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
