using Restaurant.Domain.Entities;
using Restaurant.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;
namespace Restaurant.Infra.Data.DefaultData
{
    public static class DinnerData
    {
        public static void AddDinnerData(DataContext context)
        {
            Menu breakfastMenu = new Menu();
            breakfastMenu.Type = MealType.Dinner;
            breakfastMenu.Products = AddProductData(context);

            context.Menus.Add(breakfastMenu);
            context.SaveChanges();
        }


        private static List<Product> AddProductData(DataContext context)
        {
            List<Product> productList = new List<Product>();

            var product1 = new Product
            {
                Description = "Pepperoni",
                Type = ProductType.Pizza,
                Price = decimal.Parse("5")
            };
            productList.Add(product1);

            var product2 = new Product
            {
                Description = "Salad",
                Type = ProductType.Salad,
                Price = decimal.Parse("8")
            };
            productList.Add(product2);

            var product3 = new Product
            {
                Description = "Chicken Soup",
                Type = ProductType.Soup,
                Price = decimal.Parse("3")
            };
            productList.Add(product3);

            return productList;
        }
    }
}