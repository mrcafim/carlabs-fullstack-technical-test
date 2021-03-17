using Moq;
using Restaurant.Domain.Entities;
using Restaurant.Domain.Enums;
using Restaurant.Domain.Interfaces.Repositories;
using Restaurant.Infra.Data.Repository;
using Xunit;

namespace Restaurant.Tests.Data.Repositories
{
    public class ProductRepositoryTest : TestBase
    {
        [Fact]
        public void New_ValidProduct_ShouldReturnProduct()
        {
            // Arrange
            var productResponse = new Product()
            {
                Description = "It's a test",
                Type = ProductType.Breakfast,
                Price = decimal.Parse("10")
            };

            var context = GetContext();

            var productRepository = new Mock<ProductRepository>(context);

            // Act
            var result = productRepository.Object.Add(productResponse);

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void Update_ValidProduct_ShouldUpdate()
        {
            // Arrange
            var productResponse = new Product()
            {
                Description = "It's a test",
                Type = ProductType.Breakfast,
                Price = decimal.Parse("10")
            };

            var context = GetContext();
            context.Products.Add(productResponse);
            context.SaveChanges();

            const string newDescription = "It's a new test";
            productResponse.Description = newDescription;

            var productRepository = new Mock<ProductRepository>(context);

            // Act
            productRepository.Object.Update(productResponse);

            // Assert
            var result = productRepository.Object.GetById(productResponse.Id);
            Assert.NotNull(result);
            Assert.IsType<Product>(result);
            Assert.Equal(newDescription, result.Description);
        }

        [Fact]
        public void Delete_ValidProduct_ShouldDelete()
        {
            // Arrange
            var productResponse = new Product()
            {
                Description = "It's a test",
                Type = ProductType.Breakfast,
                Price = decimal.Parse("10")
            };

            var context = GetContext();
            context.Products.Add(productResponse);
            context.SaveChanges();

            var productRepository = new Mock<ProductRepository>(context);

            // Act
            productRepository.Object.Delete(productResponse);

            // Assert
            var result = productRepository.Object.GetById(productResponse.Id);
            Assert.Null(result);
        }

        [Fact]
        public void Get_Id_ShouldReturnProduct()
        {
            // Arrange
            var productResponse = new Product()
            {
                Description = "It's a test",
                Type = ProductType.Breakfast,
                Price = decimal.Parse("10")
            };

            var context = GetContext();
            context.Products.Add(productResponse);
            context.SaveChanges();

            var productRepository = new Mock<ProductRepository>(context);

            // Act
            var result = productRepository.Object.GetById(productResponse.Id);

            // Assert
            Assert.NotNull(result);
        }

    }
}
