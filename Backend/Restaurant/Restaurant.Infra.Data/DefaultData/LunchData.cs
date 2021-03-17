using Restaurant.Domain.Entities;
using Restaurant.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;
namespace Restaurant.Infra.Data.DefaultData
{
    public static class LunchData
    {
        public static void AddLunchData(DataContext context)
        {
            Menu breakfastMenu = new Menu();
            breakfastMenu.Type = MealType.Lunch;
            breakfastMenu.Products = AddProductData(context);

            context.Menus.Add(breakfastMenu);
            context.SaveChanges();
        }


        private static List<Product> AddProductData(DataContext context)
        {
            List<Product> productList = new List<Product>();

            var product1 = new Product
            {
                Description = "Hamburguer 01",
                Type = ProductType.Hamburguer,
                Price = decimal.Parse("2")
            };
            productList.Add(product1);

            var product2 = new Product
            {
                Description = "Hamburguer 02",
                Type = ProductType.Hamburguer,
                Price = decimal.Parse("5")
            };
            productList.Add(product2);

            var product3 = new Product
            {
                Description = "Hamburguer 03",
                Type = ProductType.Hamburguer,
                Price = decimal.Parse("1")
            };
            productList.Add(product3);

            return productList;
        }
    }
}