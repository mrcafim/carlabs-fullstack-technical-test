using Restaurant.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Domain.Entities
{
    public class Menu : Entity
    {
        public MealType Type { get; set; }
        public List<Product> Products { get; set; }
    }
}
