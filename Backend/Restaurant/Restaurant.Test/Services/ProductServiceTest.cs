using Moq;
using Restaurant.Domain.Entities;
using Restaurant.Domain.Enums;
using Restaurant.Domain.Interfaces.Services;
using Restaurant.Domain.Models.Product;
using Restaurant.Service;
using Xunit;

namespace Restaurant.Tests.Services
{
    public class ProductServiceTest : TestBase
    {
        //[Fact]
        //public void New_ValidProduct_ShouldReturnProduct()
        //{
        //    // Arrange
        //    var product = new CreateProductModel()
        //    {
        //        Description = "It's a test",
        //        Type = ProductType.Breakfast,
        //        Price = decimal.Parse("10")
        //    };

        //    var productResponse = new Product()
        //    {
        //        Description = "It's a test",
        //        Type = ProductType.Breakfast,
        //        Price = decimal.Parse("10")
        //    };

        //    var productService = AutoMocker.CreateInstance<ProductService>();

        //    AutoMocker.GetMock<IProductService>().Setup(repository => repository.New(It.IsAny<CreateProductModel>()))
        //        .Returns(productResponse);


        //    // Act
        //    var result = productService.New(product);

        //    // Assert
        //    Assert.IsType<Product>(result);
        //}

    }
}
