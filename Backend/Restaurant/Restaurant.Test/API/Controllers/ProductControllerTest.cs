using Xunit;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Restaurant.Application.Controllers;
using Restaurant.Domain.Models.Product;
using Restaurant.Domain.Enums;
using Restaurant.Domain.Interfaces.Services;
using Restaurant.Domain.Entities;
using System;

namespace Restaurant.Tests.API.Controllers
{
    public class ProductControllerTest : TestBase
    {
        [Fact]
        public void Post_NewProduct_ShouldReturnOK()
        {
            // Arrange
            var product = new CreateProductModel()
            {
                Description = "It's a test",
                Type = ProductType.Breakfast,
                Price = decimal.Parse("10")
            };

            var productResponse = new Product()
            {
                Description = "It's a test",
                Type = ProductType.Breakfast,
                Price = decimal.Parse("10")
            };

            var productController = AutoMocker.CreateInstance<ProductsController>();

            AutoMocker.GetMock<IProductService>().Setup(service => service.New(It.IsAny<CreateProductModel>()))
                .Returns(productResponse);
            // Act
            var result = productController.Post(product);

            // Assert
            Assert.IsType<OkResult>(result);
        }

        [Fact]
        public void Post_NewProduct_ShouldReturnBadRequest()
        {
            // Arrange
            var product = new CreateProductModel()
            {
                Description = "It's a test",
                Type = ProductType.Breakfast,
                Price = decimal.Parse("10")
            };
            var productController = AutoMocker.CreateInstance<ProductsController>();

            // Act
            var result = productController.Post(product);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void Put_UpdateProduct_ShouldReturnOK()
        {
            // Arrange
            var product = new UpdateProductModel()
            {
                Description = "It's a test",
                Type = ProductType.Breakfast,
                Price = decimal.Parse("10")
            };

            var productResponse = new Product()
            {
                Description = "It's a test",
                Type = ProductType.Breakfast,
                Price = decimal.Parse("10")
            };

            var productController = AutoMocker.CreateInstance<ProductsController>();

            AutoMocker.GetMock<IProductService>().Setup(service => service.Update(It.IsAny<UpdateProductModel>()))
                .Returns(productResponse);

            // Act
            var result = productController.Put(product);

            // Assert
            Assert.IsType<OkResult>(result);
        }

        [Fact]
        public void Put_UpdateProduct_ShouldReturnBadRequest()
        {
            // Arrange
            var product = new UpdateProductModel()
            {
                Description = "It's a test",
                Type = ProductType.Breakfast,
                Price = decimal.Parse("10")
            };

            var productController = AutoMocker.CreateInstance<ProductsController>();

            // Act
            var result = productController.Put(product);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void Delete_ProductExists_shouldReturnOK()
        {
            var productController = AutoMocker.CreateInstance<ProductsController>();

            // Act
            var result = productController.Delete(new Guid());

            // Assert
            Assert.IsType<OkResult>(result);
        }

        [Fact]
        public void Get_ProductNotExists_ShouldReturnBadRequest()
        {
            var productController = AutoMocker.CreateInstance<ProductsController>();

            // Act
            var result = productController.Get(new Guid());

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }
    }
}
