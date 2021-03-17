using Restaurant.Domain.Entities;
using Restaurant.Domain.Enums;
using System;
using Xunit;

namespace Restaurant.Tests.Entities
{
    public class ProductTest
    {
        [Fact]
        public void DefaultConstrutor_WithoutData_ShouldCreateObject()
        {
            // Arrange
            var product = new Product();

            // Assert
            Assert.NotNull(product);
        }

        [Fact]
        public void ConstructorWithParameters_ValidData_ShouldCreateObject()
        {
            // Arrange
            const string description = "It's a test";
            const ProductType type = ProductType.Breakfast;
            const decimal price = 10;
            Guid menuId = new Guid();

            // Act
            var product = new Product(description, type, price, menuId);

            // Assert
            Assert.NotNull(product);
        }
    }
}
