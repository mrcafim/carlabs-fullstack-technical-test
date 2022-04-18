using Microsoft.Extensions.Configuration;
using System;
using Moq.AutoMock;
using Restaurant.Infra.Data;

namespace Restaurant.Tests
{
    public class TestBase
    {
        public readonly AutoMocker AutoMocker = new AutoMocker();

        public IConfiguration GetConfiguration()
        {
            return new ConfigurationBuilder()
                .AddJsonFile("appsettings.test.json")
                .Build();
        }

        public DataContext GetContext()
        {
            return DatabaseContextMocker.CreateContext();
        }
    }
}
