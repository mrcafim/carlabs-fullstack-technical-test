using Restaurant.Domain.Entities;
using Restaurant.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;
namespace Restaurant.Infra.Data.DefaultData
{
	public static class BreakfastData
	{
		public static void AddBreakfastData(DataContext context)
		{
            Menu breakfastMenu = new Menu();
            breakfastMenu.Type = MealType.Breakfast;
            breakfastMenu.Products = AddProductData(context);

            context.Menus.Add(breakfastMenu);
            context.SaveChanges();
		}


        private static List<Product> AddProductData(DataContext context)
        {
            List<Product> productList = new List<Product>();

            var product1 = new Product
            {
                Description = "Scrambled Eggs",
                Type = ProductType.Breakfast,
                Price = decimal.Parse("1")
            };
            productList.Add(product1);

            var product2 = new Product
            {
                Description = "Waffles",
                Type = ProductType.Breakfast,
                Price = decimal.Parse("2")
            };
            productList.Add(product2);

            var product3 = new Product
            {
                Description = "Pancakes",
                Type = ProductType.Breakfast,
                Price = decimal.Parse("4")
            };
            productList.Add(product3);

            return productList;
        }
    }
}